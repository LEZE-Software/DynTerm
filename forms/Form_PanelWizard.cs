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
    public partial class Form_PanelWizard : Form
    {
        public Form_PanelWizard(Form_Center mainFM)
        {
            this.mainFM = mainFM;
            InitializeComponent();
        }

        Form_Center mainFM;
        Mode currentMode = Mode.New;

        PanelType newType = PanelType.Button;
        ClickAction newAction = ClickAction.SendSerial;

        private void Form_PanelWizard_FormClosing(object sender, FormClosingEventArgs e)
        {
            SubFormManager.ExternCloseSubForm(SubFormManager.SubFormIndex.PanelEditor);           
        }

        private void Form_PanelWizard_Load(object sender, EventArgs e)
        {
            foreach (Function f in FunctionManager.GetListOfFunctions)
            {
                cob_ParentFunction.Items.Add(f.name);
            }

            cob_PanelType.SelectedIndex = 0;
        }

        private void SwitchMode(Mode m)
        {

        }

        private void SwitchType(PanelType t)
        {
            switch(t)
            {
                case PanelType.Display:
                case PanelType.Input:
                case PanelType.Select:
                    {
                        cob_ClickAction.Enabled = false;
                        lbl_ClickAciton.Enabled = false;
                        cob_ActionElement.Enabled = false;
                        lbl_ActionElement.Enabled = false;
                        break;
                    }
                case PanelType.Button:
                    {
                        cob_ClickAction.Enabled = true;
                        lbl_ClickAciton.Enabled = true;
                        cob_ActionElement.Enabled = true;
                        lbl_ActionElement.Enabled = true;
                        break;
                    }
            }
        }

        private enum ClickAction
        {
            SendSerial,
            LAST_INDEX
        }

        private enum PanelType
        {
            Display,
            Input,
            Select,
            Button,
            LAST_INDEX
        }

        private enum Mode
        {
            New,
            Edit,
            LAST_INDEX
        }

        private void cob_PanelType_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idx = cob_PanelType.SelectedIndex;

            SwitchType((PanelType)idx);
        }

        private void cmd_save_Click(object sender, EventArgs e)
        {
            SubFormManager.form_playground.Text = "Gurke";

            string title = txt_Title.Text;
            string subTitle = txt_SubTitle.Text;

            Point newLocation = Props.PanelToEdit.Location;

            SubFormManager.form_playground.Controls.Remove(Props.PanelToEdit);
            SubFormManager.form_playground.Controls.Add(CreateNewDisplayPanel(newLocation, title, subTitle));

            foreach( Control c in SubFormManager.form_playground.Controls)
            {
                c.Show();
            }

            // TODO: Add object to function.
            // TODO: Add all other types of panels.
        }

        private Panel CreateNewDisplayPanel(Point newLocation, string title, string subTitle)
        {
            Panel ret = new Panel()
            {
                BackColor = SystemColors.ControlLight,
                Name = "panel_frank",
                Size = new Size(157, 90),
                BorderStyle = BorderStyle.FixedSingle,
                Tag = newType.ToString(),
                Location = newLocation
            };

            Label titleLable = new Label()
            {
                Name = "lbl_title",
                Text = title,
                Font = new Font("Microsoft YaHei",9.75f,FontStyle.Bold),
                ForeColor = Color.Crimson,
                Location = new Point(5,5),
                BackColor = SystemColors.ControlLight
            };

            // TODO: Add all other parts of the panel.

            ret.Controls.Add(titleLable);

            return ret;
        }
    }
}
