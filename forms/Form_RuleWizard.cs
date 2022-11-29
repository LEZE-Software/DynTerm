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
    public partial class Form_NewEditRule : Form
    {
        public Form_NewEditRule(Form_Center mainFM, bool edit)
        {
            this.mainFM = mainFM;
            InitializeComponent();

            if(edit && RuleManager.GetListOfRules.Count>0)
            {
                SwitchMode(Mode.View);
            }
            else
            {
                SwitchMode(Mode.New);
            }
        }

        Form_Center mainFM;
        Function selectedFunction;

        private void Form_NewEditRule_Load(object sender, EventArgs e)
        {
            foreach (fRule r in RuleManager.GetListOfRules)
            {
                list_show.Items.Add(r.keyWord);
            }

            foreach (Function f in FunctionManager.GetListOfFunctions)
            {
                cob_function.Items.Add(f.name);
            }

            // Prepare form.
            cob_positiveOutput.SelectedIndex = (int)SerialIndex.None;
            cob_negativeOutput.SelectedIndex = (int)SerialIndex.None;
        }

        private void cmd_save_Click(object sender, EventArgs e)
        {
            string key = txt_keyword.Text;
            string comment = "No comment.";
            bool active = chb_activate.Checked;

            selectedFunction = FunctionManager.GetFunctionFromName(cob_function.Text);

            if (key != "" && cob_function.SelectedIndex != -1 && cob_CheckOperation.SelectedIndex != -1)
            {
                fRule newRule = new fRule(
                key,
                (KeywordCheckOperation)cob_CheckOperation.SelectedIndex,
                GetSerialPart(),
                GetOutputPart(),
                comment,
                active,
                selectedFunction);

                RuleManager.AddRule(newRule);

                list_show.Items.Add(newRule.keyWord + "*" + newRule.OperationIndex.ToString());
            }
            else
            {
                MessageBox.Show("Prüfen Sie Ihre Eingaben!", "Warnung", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }          
        }

        private OutputOption GetOutputPart()
        {
            OutputOption ret = new OutputOption();

            if (chb_output.Checked != false)
            {
                ret.postiveIndex = (OutputIndex)cob_positiveOutput.SelectedIndex;
                ret.negativeIndex = (OutputIndex)cob_negativeOutput.SelectedIndex;

                ret.nameOfPositiveControlElement = cob_outputElementPos.Text;
                ret.nameOfNegativeControlElement = cob_outputElementNeg.Text;

                if (ret.postiveIndex == OutputIndex.IndividualText)
                {
                    ret.positiveText = cob_positiveOutput.Text;
                }

                if(ret.negativeIndex == OutputIndex.IndividualText)
                {
                    ret.negativeText = cob_negativeOutput.Text;
                }
            }
            else
            {
                ret.postiveIndex = OutputIndex.None;
                ret.negativeIndex = OutputIndex.None;
            }

            return ret;
        }

        private SerialOption GetSerialPart()
        {
            if (chb_serialOption.Checked != false)
            {
                SerialIndex work = SerialIndex.None;

                if (chb_sendIfPositive.Checked && chb_sendIfNegative.Checked)
                {
                    work = SerialIndex.Both;
                }
                else
                {
                    if (chb_sendIfNegative.Checked && !chb_sendIfPositive.Checked)
                    {
                        work = SerialIndex.Negative;
                    }
                    else if (!chb_sendIfNegative.Checked && chb_sendIfPositive.Checked)
                    {
                        work = SerialIndex.Positive;
                    }
                }
                return new SerialOption(txt_sendIfPositive.Text, txt_sendIfNegative.Text, work);
            }
            else
            {
                return new SerialOption(SerialIndex.None);
            }
        }

        private void SwitchMode(Mode m)
        {

        }

        private enum Mode
        {
            View,
            New,
            Edit,
            LAST_INDEX
        }

        private void Form_NewEditRule_FormClosing(object sender, FormClosingEventArgs e)
        {
            SubFormManager.ExternCloseSubForm(SubFormManager.SubFormIndex.RuleEditor);
        }

        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox senderBox = sender as CheckBox;
            KeywordCheckOperation checkOp = (KeywordCheckOperation)cob_CheckOperation.SelectedIndex;
            int idx = Convert.ToInt32(senderBox.Checked);

            senderBox.Image = images_activate.Images[idx];

            switch(senderBox.Tag.ToString())
            {
                case "send_pos":
                    {
                        txt_sendIfPositive.Enabled = senderBox.Checked;
                        break;
                    }
                case "send_neg":
                    {
                        txt_sendIfNegative.Enabled = senderBox.Checked;
                        break;
                    }
                case "serial":
                    {
                        chb_sendIfPositive.Enabled = senderBox.Checked;

                        if(checkOp != KeywordCheckOperation.ExecuteAlways)
                        {
                            chb_sendIfNegative.Enabled = senderBox.Checked;
                        }                                        

                        if(senderBox.Checked == false)
                        {
                            chb_sendIfNegative.Checked = senderBox.Checked;
                            chb_sendIfPositive.Checked = senderBox.Checked;

                            txt_sendIfPositive.Enabled = senderBox.Checked;
                            txt_sendIfNegative.Enabled = senderBox.Checked;
                        }
                        
                        break;
                    }
                case "active":
                    {
                        // Nothing happens here.
                        break;
                    }
                case "output":
                    {
                        cob_positiveOutput.Enabled = senderBox.Checked;
                        cob_outputElementPos.Enabled = senderBox.Checked;

                        if (checkOp != KeywordCheckOperation.ExecuteAlways)
                        {
                            cob_outputElementNeg.Enabled = senderBox.Checked;
                            cob_negativeOutput.Enabled = senderBox.Checked;
                        }

                        break;
                    }
            }
        }

        private void list_show_SelectedIndexChanged(object sender, EventArgs e)
        {
            SwitchMode(Mode.Edit);

            fRule edit = RuleManager.GetRuleFromName(list_show.SelectedItem.ToString());

            DisplayRuleValues(edit);
        }

        private void DisplayRuleValues(fRule edit)
        {
            txt_keyword.Text = edit.keyWord;
            cob_CheckOperation.SelectedIndex = (int)edit.OperationIndex;
            cob_function.SelectedIndex = edit.ParentFunction.index;
            chb_activate.Checked = edit.isActive;

            chb_serialOption.Checked = (edit.SerialAction.serialOutputIndex != SerialIndex.None);
            chb_output.Checked = ( (edit.OutputAction.negativeIndex != OutputIndex.None) && (edit.OutputAction.postiveIndex != OutputIndex.None));
        }

        private void cob_CheckOperation_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idx = cob_CheckOperation.SelectedIndex;

            bool allowNegativeOption = ((KeywordCheckOperation)idx != KeywordCheckOperation.ExecuteAlways);

            if(allowNegativeOption)
            {
                if(chb_output.Checked)
                {
                    cob_negativeOutput.Enabled =
                    lbl_negOutput_Title.Enabled =
                    lbl_negOutputElement.Enabled = true;
                }

                if(chb_serialOption.Checked)
                {
                    lbl_sendNeg.Enabled =
                    chb_sendIfNegative.Enabled = true;
                }
            }
            else
            {
                cob_negativeOutput.Enabled =
                    lbl_negOutput_Title.Enabled =
                    lbl_negOutputElement.Enabled =
                     lbl_sendNeg.Enabled =
                    chb_sendIfNegative.Enabled =
                    chb_sendIfNegative.Checked =
                    txt_sendIfNegative.Enabled = false;
            }            
        }

        /// <summary>
        /// Display all panels which are part of the previos selected function.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cob_outputElement_DropDown(object sender, EventArgs e)
        {
            ComboBox senderBox = sender as ComboBox;

            senderBox.Items.Clear();

            foreach(Panel p in selectedFunction.targetObjects)
            {
                senderBox.Items.Add(p.Name);
            }
        }

        private void cob_function_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedFunction = FunctionManager.GetFunctionFromName(cob_function.Text);
        }
    }
}
