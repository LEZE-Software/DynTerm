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

        public void ExecuteSerialAction(bool positive, string serialAnswer)
        {
            if (SerialAction.serialOutputIndex == SerialIndex.Both)
            {
                Serial_Manager.SendCommand(SerialAction.messageToSendPos);
            }

            if(positive && SerialAction.serialOutputIndex == SerialIndex.Positive)
            {
                Serial_Manager.SendCommand(SerialAction.messageToSendPos);
            }

            if(!positive && SerialAction.serialOutputIndex == SerialIndex.Negative)
            {
                Serial_Manager.SendCommand(SerialAction.messageToSendNeg);
            }
        }

        private void ExecuteOutputReaction(bool positive, string serialAnswer)
        {
            if(positive)
            {
                if (OutputAction.postiveIndex == OutputIndex.IndividualText)
                {
                    SubFormManager.PerformOutputAction(this, OutputAction.nameOfPositiveControlElement, OutputAction.positiveText);
                }
                else if(OutputAction.postiveIndex == OutputIndex.RawValue)
                {
                    SubFormManager.PerformOutputAction(this, OutputAction.nameOfPositiveControlElement, serialAnswer);
                }
            }
            else
            {
                if (OutputAction.negativeIndex == OutputIndex.IndividualText)
                {
                    SubFormManager.PerformOutputAction(this, OutputAction.nameOfNegativeControlElement, OutputAction.negativeText);
                }
                else if (OutputAction.negativeIndex == OutputIndex.RawValue)
                {
                    SubFormManager.PerformOutputAction(this, OutputAction.nameOfNegativeControlElement, serialAnswer);
                }
            }
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
                            if(SerialAction.serialOutputIndex != SerialIndex.None)
                            {
                                ExecuteSerialAction(true, serialAnswer);
                            }

                            if (OutputAction.postiveIndex != OutputIndex.None)
                            {
                                ExecuteOutputReaction(true, serialAnswer);
                            }
                        }
                        // Contains not.
                        else
                        {
                            if (SerialAction.serialOutputIndex == SerialIndex.Both)
                            {
                                ExecuteSerialAction(true, serialAnswer);
                            }
                            else if (SerialAction.serialOutputIndex == SerialIndex.Negative)
                            {
                                ExecuteSerialAction(false, serialAnswer);
                            }

                            if (OutputAction.negativeIndex != OutputIndex.None)
                            {
                                ExecuteOutputReaction(false, serialAnswer);
                            }
                        }
                        break;
                    }
                case KeywordCheckOperation.ContainsNot:
                    {
                        // Contains not.
                        if (!serialAnswer.Contains(keyWord))
                        {
                            if (SerialAction.serialOutputIndex != SerialIndex.None)
                            {
                                ExecuteSerialAction(true, serialAnswer);
                            }

                            if (OutputAction.postiveIndex != OutputIndex.None)
                            {
                                ExecuteOutputReaction(true, serialAnswer);
                            }
                        }
                        // Contains.
                        else
                        {
                            if (SerialAction.serialOutputIndex == SerialIndex.Both)
                            {
                                ExecuteSerialAction(true, serialAnswer);
                            }
                            else if (SerialAction.serialOutputIndex == SerialIndex.Negative)
                            {
                                ExecuteSerialAction(false, serialAnswer);
                            }

                            if (OutputAction.negativeIndex != OutputIndex.None)
                            {
                                ExecuteOutputReaction(false, serialAnswer);
                            }
                        }
                        break;
                    }
                case KeywordCheckOperation.IsEqual:
                    {
                        // Equals.
                        if (serialAnswer ==keyWord)
                        {
                            if (SerialAction.serialOutputIndex != SerialIndex.None)
                            {
                                ExecuteSerialAction(true, serialAnswer);
                            }

                            if (OutputAction.postiveIndex != OutputIndex.None)
                            {
                                ExecuteOutputReaction(true, serialAnswer);
                            }
                        }
                        // Equals not.
                        else
                        {
                            if (SerialAction.serialOutputIndex == SerialIndex.Both)
                            {
                                ExecuteSerialAction(true, serialAnswer);
                            }
                            else if (SerialAction.serialOutputIndex == SerialIndex.Negative)
                            {
                                ExecuteSerialAction(false, serialAnswer);
                            }

                            if (OutputAction.negativeIndex != OutputIndex.None)
                            {
                                ExecuteOutputReaction(false, serialAnswer);
                            }
                        }
                        break;
                    }
                case KeywordCheckOperation.ExecuteAlways:
                    {
                        if (SerialAction.serialOutputIndex != SerialIndex.None)
                        {
                            ExecuteSerialAction(true, serialAnswer);
                        }

                        if (OutputAction.postiveIndex != OutputIndex.None)
                        {
                            ExecuteOutputReaction(true, serialAnswer);
                        }
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
