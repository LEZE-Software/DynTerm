using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace term
{
    public partial class Form_CreateNewRule : Form
    {
        public Form_CreateNewRule(Form_Center mainFM)
        {
            this.mainFM = mainFM;
            InitializeComponent();
        }

        Form_Center mainFM;

        private void cob_displayOperation_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cob_displayOperation.SelectedIndex;

            switch (index)
            {
                case (Int32)DisplayOperation.DisplayText:
                    {
                        txt_displayText1.Visible = 
                            lbl_displayText1.Visible = true;

                        lbl_displayText1.Text = "Ausgabetext";

                        txt_displayText2.Visible = 
                            lbl_displayText2.Visible = false;

                        break;
                    }
                default:
                    {
                        lbl_displayText1.Visible =
                            lbl_displayText2.Visible =
                            txt_displayText1.Visible =
                            txt_displayText2.Visible = false;
                        break;
                    }
            }
        }

        private void cob_chooseFunction_DropDown(object sender, EventArgs e)
        {
            ComboBox senderBox = sender as ComboBox;

            senderBox.Items.Clear();
            foreach (Function f in mainFM.AllFunctions)
            {
                senderBox.Items.Add(f.name);
            }
        }

        public KindOfOutputIndex CreateKindOfOutput(bool serial, bool display)
        {
            if (serial && display)
            {
                return KindOfOutputIndex.Both;
            }
            else if (serial && !display)
            {
                return KindOfOutputIndex.Serial;
            }
            else if (display && !serial)
            {
                return KindOfOutputIndex.Visual;
            }
            return KindOfOutputIndex.None;
        }

        private void cmd_addNewRule_Click(object sender, EventArgs e)
        {
            #region Variables.
            int
                parentIndex = cob_parentFunction.SelectedIndex,
                targetObjectIndex = cob_targetObject.SelectedIndex,
                operationIndex = cob_operation.SelectedIndex,
                displayIndex = cob_displayOperation.SelectedIndex,
                answerIndex = cob_sendOption.SelectedIndex,
                serialSourceIndexPos = cob_posObject.SelectedIndex,
                serialSourceIndexNeg = cob_negObject.SelectedIndex;

            bool
                enableSerialAnswer = chb_sendSerial.Checked,
                enableDisplayAction = chb_useOutput.Checked;
            #endregion

            Keyword key = new Keyword
            {
                text = txt_keyword.Text,
                CheckIdx = (KeywordCheckOperation)operationIndex
            };

            SerialAnswer serial = new SerialAnswer
            {
                sendIdx = (SendOperationIndex)answerIndex
            };

            TargetProp target = new TargetProp
            {
                DispIxd = (DisplayOperation)displayIndex,

            };

            FunctionRule newF = new FunctionRule()
            {
                // Values needed in every case.
                ParentFunction = mainFM.AllFunctions[parentIndex],
                kindOfOutput = CreateKindOfOutput(enableSerialAnswer, enableDisplayAction)
            };

            // Creating a rule to display something.
            if(enableDisplayAction)
            {
                target.textToDisplay = txt_displayText1.Text;
                target.targetObject = mainFM.AllObjects[targetObjectIndex];

                if(displayIndex==(Int32)DisplayOperation.YesNo)
                {
                    target.displayTextPos = txt_displayText1.Text;
                    target.displayTextNeg = txt_displayText2.Text;
                }
            }

            if (enableSerialAnswer)
            {
                serial.sendIdx = (SendOperationIndex)answerIndex;

                if(serial.sendIdx == SendOperationIndex.YesNo)
                {
                    serial.answerPos = txt_posText.Text;
                    serial.answerNeg = txt_negText.Text;
                }
            }

            if(serialSourceIndexPos!=-1)
            {
                serial.sourceObjectPos = mainFM.AllFunctions[parentIndex].targetObjects[serialSourceIndexPos];
            }
            if(serialSourceIndexNeg!=-1)
            {
                serial.sourceObjectPos = mainFM.AllFunctions[parentIndex].targetObjects[serialSourceIndexNeg];
            }

            newF.key = key;
            newF.serial = serial;
            newF.target = target;

            mainFM.AllRules.Add(newF);
        }

        private void cob_operation_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cob_operation.SelectedIndex;

            switch (index)
            {
                case (Int32)KeywordCheckOperation.DisplayKeywordWithoutCheck:
                    {
                        txt_keyword.Enabled = false;
                        cob_targetObject.SelectedIndex = (Int32)DisplayOperation.RawData;
                        break;
                    }
                default:
                    {
                        txt_keyword.Enabled = true;
                        break;
                    }
            }
        }

        private void chb_sendSerial_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox senderBox = sender as CheckBox;

            grp_sendSettings.Enabled = senderBox.Checked;

            if (senderBox.Checked)
            {
                cob_sendOption.SelectedIndex = 0;
            }
            else if (!senderBox.Checked)
            {
                cob_sendOption.SelectedIndex = -1;
            }
        }

        private void chb_useOutput_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox senderBox = sender as CheckBox;

            // The display-function is locked if there are no target objects.
            if(mainFM.AllObjects.Count==0 && senderBox.Checked)
            {
                MessageBox.Show(Messages.noTargetObjectAvailable, Messages.title);
                senderBox.Checked = false;
            }
            else if(mainFM.AllObjects.Count>0 && senderBox.Checked)
            {
                foreach(ControlObject c in mainFM.AllObjects)
                {
                    if(c.parentFunction.index!=0)
                    {
                        cob_targetObject.Items.Add(c.rootObject.Name);
                    }
                }
            }

            grp_outputSettings.Enabled = senderBox.Checked;

            if (senderBox.Checked)
            {
                cob_targetObject.SelectedIndex = 0;
                cob_displayOperation.SelectedIndex = 0;
            }
            else if (!senderBox.Checked)
            {
                cob_targetObject.SelectedIndex = -1;
                cob_displayOperation.SelectedIndex = -1;
            }
        }

        private void cob_posNegObject_DropDown(object sender, EventArgs e)
        {
            ComboBox senderBox = sender as ComboBox;

            senderBox.Items.Clear();

            int index = cob_parentFunction.SelectedIndex;

            foreach (Function f in mainFM.AllFunctions)
            {
                if (f.index == index)
                {
                    foreach (dynamic targetObject in f.targetObjects)
                    {
                        senderBox.Items.Add(targetObject.Name);
                    }
                }
            }
        }

        private void cob_targetObject_DropDown(object sender, EventArgs e)
        {
            cob_targetObject.Items.Clear();

            foreach(ControlObject c in mainFM.AllObjects)
            {
                cob_targetObject.Items.Add(c.rootObject.Name);
            }
        }
    }
}
