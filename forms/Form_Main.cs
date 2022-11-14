using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace term
{
    public partial class Form_Center : Form
    {
        // TODO: Add AllAnswers to the SerialManager class.

        public Form_Center()
        {
            InitializeComponent();
        }

          

        public List<fRule> AllRules = new List<fRule>();
        public List<Function> AllFunctions = new List<Function>();
        public List<ControlObject> AllObjects = new List<ControlObject>();
        public List<TextBox> AllTextBoxes = new List<TextBox>();

        /**********************/
        /*** IMPLEMENTATION ***\
        /**********************/

        private void Form1_Load(object sender, EventArgs e)
        {
            Serial_Manager.Initialize();


            // Create Displayfunction.
            Function displayFunction = new Function()
            {
                index = 0,
                name = "Anzeiger"
            };
            AllFunctions.Add(displayFunction);
        }

        private void cmd_openPlayground_Click(object sender, EventArgs e)
        {
            if (SubFormManager.IsFormOpen(SubFormManager.SubFormIndex.Playground))
            {
                SubFormManager.CloseSubForm(SubFormManager.SubFormIndex.Playground);
            }
            else
            {
                SubFormManager.OpenSubForm(SubFormManager.SubFormIndex.Playground, this, false);
            }
        }

        private void menu_createNewRule_Click(object sender, EventArgs e)
        {
            if (SubFormManager.IsFormOpen(SubFormManager.SubFormIndex.RuleEditor))
            {
                SubFormManager.CloseSubForm(SubFormManager.SubFormIndex.RuleEditor);
            }
            else
            {
                SubFormManager.OpenSubForm(SubFormManager.SubFormIndex.RuleEditor, this, false);
            }
        }

        private void Form_Center_FormClosing(object sender, FormClosingEventArgs e)
        {
            Props.shallClose = true;
        }

        private void cmd_openConnectionSettings_Click(object sender, EventArgs e)
        {
            SubFormManager.OpenSubForm(SubFormManager.SubFormIndex.SerialSettings, this, false);
        }

        private void cmd_About_Click(object sender, EventArgs e)
        {
            MessageBox.Show("DynTerm Version 0.1.2\n08. Nov. 2022\n\nLEZE-Software - 2022 \n https://github.com/LEZE-Software ", "Versionsinformation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cmd_showSerialTraffic_Click(object sender, EventArgs e)
        {
            if(SubFormManager.IsFormOpen(SubFormManager.SubFormIndex.Traffic))
            {
                SubFormManager.CloseSubForm(SubFormManager.SubFormIndex.Traffic);
            }
            else
            {
                SubFormManager.OpenSubForm(SubFormManager.SubFormIndex.Traffic, this, false);
            }
        }

        private void cmd_connect_Click(object sender, EventArgs e)
        {
            Serial_functions.OpenClosePort();
        }

        private void cmd_editRule_Click(object sender, EventArgs e)
        {
            if (SubFormManager.IsFormOpen(SubFormManager.SubFormIndex.RuleEditor))
            {
                SubFormManager.CloseSubForm(SubFormManager.SubFormIndex.RuleEditor);
            }
            else
            {
                SubFormManager.OpenSubForm(SubFormManager.SubFormIndex.RuleEditor, this, true);
            }
        }

        private void cmd_editFunction_Click(object sender, EventArgs e)
        {
            if (SubFormManager.IsFormOpen(SubFormManager.SubFormIndex.FunctionEditor))
            {
                SubFormManager.CloseSubForm(SubFormManager.SubFormIndex.FunctionEditor);
            }
            else
            {
                SubFormManager.OpenSubForm(SubFormManager.SubFormIndex.FunctionEditor, this, true);
            }
        }

        private void cmd_createNewFunction_Click(object sender, EventArgs e)
        {
            if (SubFormManager.IsFormOpen(SubFormManager.SubFormIndex.FunctionEditor))
            {
                SubFormManager.CloseSubForm(SubFormManager.SubFormIndex.FunctionEditor);
            }
            else
            {
                SubFormManager.OpenSubForm(SubFormManager.SubFormIndex.FunctionEditor, this, false);
            }
        }

        private void menuItem_functions_Click(object sender, EventArgs e)
        {
            cmd_editFunction.Enabled = (FunctionManager.FunctionCount > 0);
        }

        private void menuItem_rules_Click(object sender, EventArgs e)
        {
            cmd_editRule.Enabled = (RuleManager.RuleCount > 0);
        }

        private void cmd_Settings_Click(object sender, EventArgs e)
        {
            if (SubFormManager.IsFormOpen(SubFormManager.SubFormIndex.Settings))
            {
                SubFormManager.CloseSubForm(SubFormManager.SubFormIndex.Settings);
            }
            else
            {
                SubFormManager.OpenSubForm(SubFormManager.SubFormIndex.Settings, this, true);
            }
        }
    }    
}
