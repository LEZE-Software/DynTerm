using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace term
{
    public class fRule
    {
        /// <summary>
        /// Generate a new instance of fRule.
        /// </summary>
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

        private List<string> connectedPanels = new List<string>();
        #endregion

        public void AddPanelToFunction(string val)
        {
            connectedPanels.Add(val);
        }

        public void RemovePanelFromFunction(string val)
        {
            connectedPanels.Remove(val);
        }

        public bool IsPanelConnectedToFunction(string val)
        {
            return connectedPanels.Contains(val);
        }

        public void ExecuteReaction(string serialAnswer)
        {
            switch(SerialAction.serialOutputIndex)
            {
                // No serial action expected.
                case SerialIndex.None:
                    {
                        break;
                    }
                // Action expected when positive.
                case SerialIndex.Positive:
                    {
                        break;
                    }
                // Action expected when negative.
                case SerialIndex.Negative:
                    {
                        break;
                    }
                // Action expected when positive or negative.
                case SerialIndex.Both:
                    {
                        break;
                    }
            }
        }

        public void ExecuteSendOperation(string serialAnswer)
        {

        }

        public void ExecuteDisplayOperation(string serialAnswer, Form_Center mainFM)
        {

        }

        /// <summary>
        /// Run a check with the serial answer. 
        /// Depending on the functionality of this rule a result is returned.
        /// </summary>
        public void ExecuteRule(string serialAnswer)
        {
            switch (OperationIndex)
            {
                // Message contains keyword.
                case KeywordCheckOperation.Contains:
                    {
                        // Contains.
                        if (serialAnswer.Contains(keyWord))
                        {
                            // Execute positive serial action.
                            if (SerialAction.serialOutputIndex == SerialIndex.Positive)
                            {
                                throw new NotImplementedException();
                            }

                            // Execute positive output action.
                            if (OutputAction.postiveIndex != OutputIndex.None)
                            {
                                throw new NotImplementedException();
                            }
                        }
                        // Contains not.
                        else
                        {
                            // Execute negative serial action.
                            if (SerialAction.serialOutputIndex == SerialIndex.Negative)
                            {
                                throw new NotImplementedException();
                            }

                            // Execute negative output action.
                            if (OutputAction.negativeIndex != OutputIndex.None)
                            {
                                throw new NotImplementedException();
                            }
                        }
                        break;
                    }
                case KeywordCheckOperation.ContainsNot:
                    {
                        // Contains. This is the negative part here.
                        if (serialAnswer.Contains(keyWord))
                        {
                            // Execute negative serial action.
                            if (SerialAction.serialOutputIndex == SerialIndex.Negative)
                            {
                                throw new NotImplementedException();
                            }

                            // Execute positive output action.
                            if (OutputAction.negativeIndex != OutputIndex.None)
                            {
                                throw new NotImplementedException();
                            }
                        }
                        // Contains not. This is the positive part here.
                        else
                        {
                            // Execute positive serial action.
                            if (SerialAction.serialOutputIndex == SerialIndex.Positive)
                            {
                                throw new NotImplementedException();
                            }

                            // Execute positive output action.
                            if (OutputAction.postiveIndex != OutputIndex.None)
                            {
                                throw new NotImplementedException();
                            }
                        }
                        break;
                    }
                case KeywordCheckOperation.IsEqual:
                    {
                        if (serialAnswer == keyWord)
                        {
                            // Execute positive serial action.
                            if (SerialAction.serialOutputIndex == SerialIndex.Positive)
                            {

                            }

                            // Execute positive output action.
                            if (OutputAction.postiveIndex != OutputIndex.None)
                            {

                            }
                        }
                        else
                        {
                            // Execute positive serial action.
                            if (SerialAction.serialOutputIndex == SerialIndex.Positive)
                            {

                            }

                            // Execute positive output action.
                            if (OutputAction.postiveIndex != OutputIndex.None)
                            {

                            }
                        }
                        break;
                    }
                case KeywordCheckOperation.ExecuteAlways:
                    {
                        break;
                    }
            }
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
