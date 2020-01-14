using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public class FunctionRule
    {
        public string
            keyWord,
            displayTextPos,
            displayTextNeg,
            serialAnswerPos,
            serialAnswerNeg;

        public int
            keywordOperationIndex,
            displayOperationIndex,
            answerOperationIndex;

        public bool
            sendSerialMessage,
            displaySomeContent;

        public Function ParentFunction;

        public dynamic
            targetLabel,
            sourceObjectAnswerPos,
            sourceObjectAnswerNeg;

        public void ExecuteReaction(string serialAnswer, Form_Center mainFM)
        {
            if(sendSerialMessage)
            {
                ExecuteSendOperation(serialAnswer);
            }
            
            if(displaySomeContent)
            {
                ExecuteDisplayOperation(serialAnswer, mainFM);
            }
        }

        public void ExecuteSendOperation(string serialAnswer)
        {
            try
            {
                if (sourceObjectAnswerPos != null)
                {
                    serialAnswerPos = sourceObjectAnswerPos.Text;
                }

                if (sourceObjectAnswerNeg != null)
                {
                    serialAnswerNeg = sourceObjectAnswerNeg.Text;
                }
            }
            catch
            {
                // Malfunction detected.
            }

            switch (answerOperationIndex)
            {
                case (Int32)Props.SendOperation.Always:
                    {
                        Serial_functions.SendCommand(serialAnswerPos);
                        break;
                    }
                case (Int32)Props.SendOperation.YesNo:
                    {
                        if (ExecuteOperation(serialAnswer))
                        {
                            Serial_functions.SendCommand(serialAnswerPos);
                        }
                        else
                        {
                            Serial_functions.SendCommand(serialAnswerPos);
                        }
                        break;
                    }

            }
        }

        public void ExecuteDisplayOperation(string serialAnswer, Form_Center mainFM)
        {
            string outputText = "leer";       

            switch (displayOperationIndex)
            {
                case (Int32)Props.DisplayOperation.DisplayText:
                    {
                        outputText = displayTextPos;
                        break;
                    }
                case (Int32)Props.DisplayOperation.Keyword:
                    {
                        outputText = keyWord;
                        //targetLabel.Text = keyWord;
                        break;
                    }
                case (Int32)Props.DisplayOperation.YesNo:
                    {
                        if (ExecuteOperation(serialAnswer))
                        {
                            outputText = "Ja";
                            targetLabel.Text = "Ja";
                        }
                        else
                        {
                            outputText = "Nein";
                            targetLabel.Text = "Nein";
                        }
                        break;
                    }
                case (Int32)Props.DisplayOperation.YesNoIndiv:
                    {
                        if (ExecuteOperation(serialAnswer))
                        {
                            targetLabel.Text = displayTextPos;
                        }
                        else
                        {
                            targetLabel.Text = displayTextNeg;
                        }
                        break;
                    }
                case (Int32)Props.DisplayOperation.RawData:
                    {
                        targetLabel.Text = serialAnswer;
                        break;
                    }
            }

            foreach (dynamic d in mainFM.ref_playground.Controls)
            {
                if (d.Name == targetLabel.Name)
                {
                    d.Text = outputText;
                }
            }
        }

        public bool ExecuteOperation(string serialAnswer)
        {
            switch (keywordOperationIndex)
            {
                case (Int32)Props.KeywordOperation.Contains:
                    {
                        if (serialAnswer.Contains(keyWord))
                        {
                            return true;
                        }

                        return false;
                    }
                case (Int32)Props.KeywordOperation.ContainsNot:
                    {
                        if (!serialAnswer.Contains(keyWord))
                        {
                            return true;
                        }

                        return false;
                    }
                case (Int32)Props.KeywordOperation.IsEqual:
                    {
                        if (serialAnswer == keyWord)
                        {
                            return true;
                        }

                        return false;
                    }
                case (Int32)Props.KeywordOperation.DisplayContent:
                    {
                        return true;
                        // This function is always true because it shall output the received string.
                    }
            }

            return false;
        }
    }
}
