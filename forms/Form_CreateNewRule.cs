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
    // OLD CLASS

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

        public RuleOutputType CreateKindOfOutput(bool serial, bool display)
        {
            if (serial && display)
            {
                return RuleOutputType.Both;
            }
            else if (serial && !display)
            {
                return RuleOutputType.Serial;
            }
            else if (display && !serial)
            {
                return RuleOutputType.Visual;
            }
            return RuleOutputType.None;
        }

        private void cmd_addNewRule_Click(object sender, EventArgs e)
        {
         
        }

        private void cob_operation_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cob_operation.SelectedIndex;

            switch (index)
            {
                case (Int32)KeywordCheckOperation.ExecuteAlways:
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
