using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace term
{
    public class FunctionRule
    {
        public KindOfOutputIndex kindOfOutput;

        public TargetProp target;
        public SerialAnswer serial;
        public Keyword key;

        public Function ParentFunction;

        public void ExecuteReaction(string serialAnswer, Form_Center mainFM)
        {
            switch(kindOfOutput)
            {
                case KindOfOutputIndex.Serial:
                    {
                        ExecuteSendOperation(serialAnswer);
                        break;
                    }
                case KindOfOutputIndex.Visual:
                    {
                        ExecuteDisplayOperation(serialAnswer, mainFM);
                        break;
                    }
                case KindOfOutputIndex.Both:
                    {
                        ExecuteDisplayOperation(serialAnswer, mainFM);
                        ExecuteSendOperation(serialAnswer);
                        break;
                    }
                case KindOfOutputIndex.None:
                    {
                        // Nothing.
                        break;
                    }
            }
        }

        public void ExecuteSendOperation(string serialAnswer)
        {
            switch(serial.sendIdx)
            {
                case SendOperationIndex.Always:
                    {
                        Serial_functions.SendCommand(serial.answer);
                        break;
                    }
                case SendOperationIndex.YesNo:
                    {
                        if(KeywordCheck(serialAnswer)==FunctionResultIndex.ResultYes)
                        {
                            Serial_functions.SendCommand(serial.answerPos);
                        }
                        else
                        {
                            Serial_functions.SendCommand(serial.answerNeg);
                        }
                        break;
                    }
            }
        }

        public void ExecuteDisplayOperation(string serialAnswer, Form_Center mainFM)
        {
            switch (target.DispIxd)
            {
                case DisplayOperation.Keyword:
                case DisplayOperation.DisplayText:
                    {
                        target.DisplayText(key);
                        break;
                    }
                case DisplayOperation.YesNo:
                    {
                        if (KeywordCheck(serialAnswer)==FunctionResultIndex.ResultYes)
                        {
                            target.DisplayTextPos();
                        }
                        else if (KeywordCheck(serialAnswer) == FunctionResultIndex.ResultNo)
                        {
                            target.DisplayTextPos();
                        }
                        break;
                    }
                case DisplayOperation.RawData:
                    {
                        target.DisplaySerialAnswer(serialAnswer);
                        break;
                    }
            }

            foreach (dynamic d in mainFM.ref_playground.Controls)
            {
                /*if (d.Name == targetObject.rootObject.Name)
                {
                    d.Text = outputText;
                    d.BackColor = backColorToSet;
                    d.ForeColor = fontColorToSet;
                }*/
            }
        }

        public FunctionResultIndex KeywordCheck(string serialAnswer)
        {
            switch (key.CheckIdx)
            {
                case KeywordCheckOperation.Contains:
                    {
                        if (serialAnswer.Contains(key.text))
                        {
                            return FunctionResultIndex.ResultYes;
                        }
                        break;
                    }
                case KeywordCheckOperation.ContainsNot:
                    {
                        if (!serialAnswer.Contains(key.text))
                        {
                            return FunctionResultIndex.ResultYes;
                        }
                        break;
                    }
                case KeywordCheckOperation.IsEqual:
                    {
                        if (serialAnswer == key.text)
                        {
                            return FunctionResultIndex.ResultYes;
                        }
                        break;
                    }
                case KeywordCheckOperation.DisplayKeywordWithoutCheck:
                    {
                        return FunctionResultIndex.ResultYes;
                        // This function is always true because it shall output the received string.
                    }
            }

            return FunctionResultIndex.ResultNo;
        }
    }
}
