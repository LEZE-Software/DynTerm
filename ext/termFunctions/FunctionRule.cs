using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace termFunctions
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
            displaySomeContent,
            changeColorOfTargetObject,
            interactWithPanel;

        public Function ParentFunction;

        public Color
            targetObjectColorPos,
            targetObjectColorNeg,
            targetPanelColorPos,
            targetPanelColorNeg;

        public ControlObject
            targetObject;

        public dynamic
            targetStatusPanel,
            sourceObjectAnswerPos,
            sourceObjectAnswerNeg;

        public void ExecuteReaction(string serialAnswer, Form_Center mainFM)
        {
            if (sendSerialMessage)
            {
                ExecuteSendOperation(serialAnswer);
            }

            if (displaySomeContent)
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
                case (Int32)Props.SendOperationIndex.Always:
                    {
                        Serial_functions.SendCommand(serialAnswerPos);
                        break;
                    }
                case (Int32)Props.SendOperationIndex.YesNo:
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
            Color
                backColorToSet = targetObject.commonBackColor,
                fontColorToSet = targetObject.commonFontColor;

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
                            targetObject.rootObject.Text = "Ja";
                        }
                        else
                        {
                            outputText = "Nein";
                            targetObject.rootObject.Text = "Nein";
                        }
                        break;
                    }
                case (Int32)Props.DisplayOperation.YesNoIndiv:
                    {
                        if (ExecuteOperation(serialAnswer))
                        {
                            targetObject.rootObject.Text = displayTextPos;
                        }
                        else
                        {
                            targetObject.rootObject.Text = displayTextNeg;
                        }
                        break;
                    }
                case (Int32)Props.DisplayOperation.RawData:
                    {
                        targetObject.rootObject.Text = serialAnswer;
                        break;
                    }
            }

            foreach (dynamic d in mainFM.ref_playground.Controls)
            {
                if (d.Name == targetObject.rootObject.Name)
                {
                    d.Text = outputText;
                    d.BackColor = backColorToSet;
                    d.ForeColor = fontColorToSet;
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
