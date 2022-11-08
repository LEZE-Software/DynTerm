using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace term
{
    public class fRule
    {
        // Constructor.
        public fRule(string _keyWord, KeywordCheckOperation _opx, SerialOption _serial, OutputOption _output, string _comment, bool _active, Function _parent)
        {
            keyWord = _keyWord;
            comment = _comment;
            SerialAction = _serial;
            OutputAction = _output;
            isActive = _active;
            ParentFunction = _parent;
            OperationIndex = _opx;
        }

        #region Properties.
        public KeywordCheckOperation OperationIndex { get; private set; }
        public string comment { get; private set; }
        public string keyWord { get; private set; }
        public bool isActive { get; private set; }
        public SerialOption SerialAction { get; private set; }
        public OutputOption OutputAction { get; private set; }
        public Function ParentFunction { get; private set; }
        #endregion

        public void ExecuteReaction(string serialAnswer, Form_Center mainFM)
        {

        }

        public void ExecuteSendOperation(string serialAnswer)
        {

        }

        public void ExecuteDisplayOperation(string serialAnswer, Form_Center mainFM)
        {

        }

        public FunctionResultIndex KeywordCheck(string serialAnswer)
        {
            switch (OperationIndex)
            {
                case KeywordCheckOperation.Contains:
                    {
                        if (serialAnswer.Contains(keyWord))
                        {
                            return FunctionResultIndex.ResultYes;
                        }
                        break;
                    }
                case KeywordCheckOperation.ContainsNot:
                    {
                        if (!serialAnswer.Contains(keyWord))
                        {
                            return FunctionResultIndex.ResultYes;
                        }
                        break;
                    }
                case KeywordCheckOperation.IsEqual:
                    {
                        if (serialAnswer == keyWord)
                        {
                            return FunctionResultIndex.ResultYes;
                        }
                        break;
                    }
                case KeywordCheckOperation.ExecuteAlways:
                    {
                        return FunctionResultIndex.ResultYes;
                        // This function is always true because it shall output the received string.
                    }
            }

            return FunctionResultIndex.ResultNo;
        }
    }

    /// <summary>
    /// Which kind of output shall be produced with this rule?
    /// </summary>
    public enum OutputIndex
    {
        None,
        RawValue,
        IndividualText,
        LAST_INDEX
    }

    public struct OutputOption
    {
        public string positiveText { get; set; }
        public string negativeText { get; set; }
        public string nameOfPositiveControlElement { get; set; }
        public string nameOfNegativeControlElement { get; set; }
        public OutputIndex postiveIndex { get; set; }
        public OutputIndex negativeIndex { get; set; }
    }

    public struct SerialOption
    {
        public SerialOption(SerialIndex none)
        {
            messageToSendPos = null;
            messageToSendNeg = null;
            serialOutputIndex = none;
        }

        public SerialOption(string pos, string neg, SerialIndex idx)
        {
            messageToSendPos = pos;
            messageToSendNeg = neg;
            serialOutputIndex = idx;
        }

        public string messageToSendPos { get; private set; }
        public string messageToSendNeg { get; private set; }
        public SerialIndex serialOutputIndex { get; private set; }
    }

    public enum SerialIndex
    {
        None,
        Positive,
        Negative,
        Both,
        LAST_INDEX
    }
}
