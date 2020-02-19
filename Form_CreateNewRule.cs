using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class Form_CreateNewRule : Form
    {
        public Form_CreateNewRule(Form_Center mainFM)
        {
            this.mainFM = mainFM;
            InitializeComponent();
        }

        Form_Center mainFM;

        private void Form_CreateNewRule_Load(object sender, EventArgs e)
        {

        }

        private void cob_displayOperation_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cob_displayOperation.SelectedIndex;

            switch (index)
            {
                case (Int32)Props.DisplayOperation.DisplayText:
                    {
                        txt_displayText1.Visible = 
                            lbl_displayText1.Visible = true;

                        lbl_displayText1.Text = "Ausgabetext";

                        txt_displayText2.Visible = 
                            lbl_displayText2.Visible = false;

                        break;
                    }
                case (Int32)Props.DisplayOperation.YesNoIndiv:
                    {
                        lbl_displayText1.Text = "Positive Ausgabe";
                        lbl_displayText1.Visible =
                            lbl_displayText2.Visible = 
                            txt_displayText1.Visible =
                            txt_displayText2.Visible = true;

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

        private void cmd_addNewRule_Click(object sender, EventArgs e)
        {
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

            FunctionRule newFunction = new FunctionRule()
            {
                keyWord = txt_keyword.Text,
                displayTextPos = txt_displayText1.Text,
                displayTextNeg = txt_displayText2.Text,

                sendSerialMessage = enableSerialAnswer,
                displaySomeContent = enableDisplayAction,
                serialAnswerPos = txt_posText.Text,
                serialAnswerNeg = txt_negText.Text,

                displayOperationIndex = displayIndex,
                keywordOperationIndex = operationIndex,

                ParentFunction = mainFM.AllFunctions[parentIndex],//

                targetObject = mainFM.AllObjects[targetObjectIndex]
            };

            if(answerIndex!=-1)
            {
                newFunction.answerOperationIndex = answerIndex;
            }



            if(serialSourceIndexPos!=-1)
            {
                newFunction.sourceObjectAnswerPos = mainFM.AllFunctions[parentIndex].targetObjects[serialSourceIndexPos];
            }
            if(serialSourceIndexNeg!=-1)
            {
                newFunction.sourceObjectAnswerNeg = mainFM.AllFunctions[parentIndex].targetObjects[serialSourceIndexNeg];
            }

            mainFM.AllRules.Add(newFunction);
        }

        private void cob_operation_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cob_operation.SelectedIndex;

            switch (index)
            {
                case (Int32)Props.KeywordOperation.DisplayContent:
                    {
                        txt_keyword.Enabled = false;
                        cob_targetObject.SelectedIndex = (Int32)Props.DisplayOperation.RawData;
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
            grp_sendSettings.Enabled = chb_sendSerial.Checked;

            if(!chb_useOutput.Checked && !chb_sendSerial.Checked)
            {
                cmd_createObject.Enabled = false;
            }
            else
            {
                cmd_createObject.Enabled = true;
            }
        }

        private void chb_useOutput_CheckedChanged(object sender, EventArgs e)
        {
            grp_outputSettings.Enabled = chb_useOutput.Checked;

            if (!chb_useOutput.Checked && !chb_sendSerial.Checked)
            {
                cmd_createObject.Enabled = false;
            }
            else
            {
                cmd_createObject.Enabled = true;
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
