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
        public Form_PanelWizard(Form_Center mainFM, bool edit)
        {
            this.mainFM = mainFM;

            if(edit)
            {
                SwitchMode(Mode.Edit);
            }
            else
            {
                SwitchMode(Mode.New);
            }

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
            currentMode = m;

            switch(currentMode)
            {
                case Mode.Edit:
                    {
                        EnterValuesFromPanel();
                        break;
                    }
                case Mode.New:
                    {
                        
                        break;
                    }
            }
        }

        private void EnterValuesFromPanel()
        {
            txt_Title.Text = Props.PanelToEdit.Controls["lbl_title"].Text;
        }

        private void SwitchType(PanelType t)
        {
            newType = t;

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

        private void cob_PanelType_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idx = cob_PanelType.SelectedIndex;

            SwitchType((PanelType)idx);
        }

        private void cmd_save_Click(object sender, EventArgs e)
        {
            string title = txt_Title.Text;
            string subTitle = txt_SubTitle.Text;
            int functionIndex = cob_ParentFunction.SelectedIndex;

            if(title != "" && subTitle != "" && functionIndex != -1)
            {
                Function connectedFunction = FunctionManager.GetFunctionFromIndex(functionIndex);
                Point newLocation = Props.PanelToEdit.Location;
                SubFormManager.form_playground.Controls.Remove(Props.PanelToEdit);
                Panel newPanel = new Panel();

                switch (newType)
                {
                    case PanelType.Display:
                        {
                            newPanel = CreateNewDisplayPanel(newLocation, title, subTitle);

                            connectedFunction.AddPanel(newPanel);
                            break;
                        }
                    case PanelType.Input:
                        {
                            newPanel = CreateNewInputPanel(newLocation, title, subTitle);

                            break;
                        }
                    case PanelType.Select:
                        {
                            newPanel = CreateNewSelectPanel(newLocation, title, subTitle);

                            break;
                        }
                    case PanelType.Button:
                        {
                            throw new NotImplementedException();
                        }
                }

                newPanel.Tag = "set";
                SubFormManager.form_playground.Controls.Add(newPanel);

                foreach (Control c in SubFormManager.form_playground.Controls)
                {
                    c.Show();
                }
            }
            else
            {
                MessageBox.Show("Prüfen Sie Ihre Eingaben!", "Warnung", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }          
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
                Location = newLocation,
                ContextMenuStrip = SubFormManager.form_playground.context_panel
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

            Label subTitleLabel = new Label()
            {
                Name = "lbl_SubTitle",
                Text = subTitle,
                Font = new Font("Microsoft YaHei", 8.00f, FontStyle.Underline),
                ForeColor = Color.Black,
                Location = new Point(10, 35),
                BackColor = SystemColors.ControlLight,
                TextAlign = ContentAlignment.TopLeft,
                Height = 16
            };

            TextBox txt_content = new TextBox()
            {
                Name = "txt_content",
                Text = "",
                Font = new Font("Consolas", 10.00f),
                ForeColor = Color.Black,
                Location = new Point(15, 52),
                Size = new Size(129, 23),
                ReadOnly = true,
                BackColor = SystemColors.Window
            };

            ret.Controls.Add(titleLable);
            ret.Controls.Add(subTitleLabel);
            ret.Controls.Add(txt_content);
            return ret;
        }

        private Panel CreateNewInputPanel(Point newLocation, string title, string subTitle)
        {
            Panel ret = new Panel()
            {
                BackColor = SystemColors.ControlLight,
                Name = "panel_frank",
                Size = new Size(157, 90),
                BorderStyle = BorderStyle.FixedSingle,
                Tag = newType.ToString(),
                Location = newLocation,
                ContextMenuStrip = SubFormManager.form_playground.context_panel
            };

            Label titleLable = new Label()
            {
                Name = "lbl_title",
                Text = title,
                Font = new Font("Microsoft YaHei", 9.75f, FontStyle.Bold),
                ForeColor = Color.Crimson,
                Location = new Point(5, 5),
                BackColor = SystemColors.ControlLight
            };

            Label subTitleLabel = new Label()
            {
                Name = "lbl_SubTitle",
                Text = subTitle,
                Font = new Font("Microsoft YaHei", 8.00f, FontStyle.Underline),
                ForeColor = Color.Black,
                Location = new Point(10, 35),
                BackColor = SystemColors.ControlLight,
                TextAlign = ContentAlignment.TopLeft,
                Height = 16
            };

            TextBox txt_content = new TextBox()
            {
                Name = "txt_content",
                Text = "",
                Font = new Font("Consolas", 10.00f),
                ForeColor = Color.Black,
                Location = new Point(15, 52),
                Size = new Size(129, 23),
                ReadOnly = false,
                BackColor = SystemColors.Window
            };

            ret.Controls.Add(titleLable);
            ret.Controls.Add(subTitleLabel);
            ret.Controls.Add(txt_content);
            return ret;
        }

        private Panel CreateNewSelectPanel(Point newLocation, string title, string subTitle)
        {
            Panel ret = new Panel()
            {
                BackColor = SystemColors.ControlLight,
                Name = "panel_frank",
                Size = new Size(157, 90),
                BorderStyle = BorderStyle.FixedSingle,
                Tag = newType.ToString(),
                Location = newLocation,
                ContextMenuStrip = SubFormManager.form_playground.context_panel
            };

            Label titleLable = new Label()
            {
                Name = "lbl_title",
                Text = title,
                Font = new Font("Microsoft YaHei", 9.75f, FontStyle.Bold),
                ForeColor = Color.Crimson,
                Location = new Point(5, 5),
                BackColor = SystemColors.ControlLight
            };

            Label subTitleLabel = new Label()
            {
                Name = "lbl_SubTitle",
                Text = subTitle,
                Font = new Font("Microsoft YaHei", 8.00f, FontStyle.Underline),
                ForeColor = Color.Black,
                Location = new Point(10, 35),
                BackColor = SystemColors.ControlLight,
                TextAlign = ContentAlignment.TopLeft,
                Height = 16
            };

            ComboBox cob_select = new ComboBox()
            {
                Name = "cob_select",
                Text = "",
                Font = new Font("Consolas", 10.00f),
                ForeColor = Color.Black,
                Location = new Point(15, 52),
                Size = new Size(129, 23),
                BackColor = SystemColors.Window,
                ContextMenuStrip = SubFormManager.form_playground.context_select
            };

            ret.Controls.Add(titleLable);
            ret.Controls.Add(subTitleLabel);
            ret.Controls.Add(cob_select);
            return ret;
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
    }
}
