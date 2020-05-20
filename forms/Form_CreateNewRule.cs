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

            FunctionRule newF = new FunctionRule()
            {
                // Values needed in every case.
                ParentFunction = mainFM.AllFunctions[parentIndex],
                keyWord = txt_keyword.Text,
                sendSerialMessage = enableSerialAnswer,
                displaySomeContent = enableDisplayAction,
                keywordOperationIndex = operationIndex,
            };

            // Creating a rule to display something.
            if(enableDisplayAction)
            {
                newF.targetObject = mainFM.AllObjects[targetObjectIndex];
                newF.displayOperationIndex = displayIndex;

                if(displayIndex==(Int32)Props.DisplayOperation.YesNoIndiv)
                {
                    newF.displayTextPos = txt_displayText1.Text;
                    newF.displayTextNeg = txt_displayText2.Text;
                }
            }

            if (enableSerialAnswer)
            {
                newF.answerOperationIndex = answerIndex;

                if(answerIndex==(Int32)Props.SendOperationIndex.YesNo)
                {
                    newF.serialAnswerPos = txt_posText.Text;
                    newF.serialAnswerNeg = txt_negText.Text;
                }
            }


            if(serialSourceIndexPos!=-1)
            {
                newF.sourceObjectAnswerPos = mainFM.AllFunctions[parentIndex].targetObjects[serialSourceIndexPos];
            }
            if(serialSourceIndexNeg!=-1)
            {
                newF.sourceObjectAnswerNeg = mainFM.AllFunctions[parentIndex].targetObjects[serialSourceIndexNeg];
            }

            mainFM.AllRules.Add(newF);
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
            if(mainFM.AllObjects.Count==0 && senderBox.Checked==true)
            {
                MessageBox.Show(Messages.noTargetObjectAvailable, Messages.title);
                senderBox.Checked = false;
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
