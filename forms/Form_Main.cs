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
        public Form_Center()
        {
            InitializeComponent();
        }

        public class ExtendedList<T> : List<T>
        {
            public event EventHandler OnAdd;

            public new void Add(T item) // "new" to avoid compiler-warnings, because we're hiding a method from base-class
            {
                base.Add(item);

                if (null != OnAdd)
                {
                    OnAdd(this, null);
                }
            }
        }       

        public List<fRule> AllRules = new List<fRule>();
        public ExtendedList<string> AllAnswers = new ExtendedList<string>();
        public List<Function> AllFunctions = new List<Function>();
        public List<ControlObject> AllObjects = new List<ControlObject>();
        public List<TextBox> AllTextBoxes = new List<TextBox>();

        /**********************/
        /*** IMPLEMENTATION ***\
        /**********************/

        private void Form1_Load(object sender, EventArgs e)
        {
            AllAnswers = new ExtendedList<string>();

            AllAnswers.OnAdd += new EventHandler(ParseReceivedAnswer);

            //SubFormManager.OpenSubForm(SubFormManager.SubFormIndex.Playground, this);

            // Create Displayfunction.
            Function displayFunction = new Function()
            {
                index = 0,
                name = "Anzeiger"
            };
            AllFunctions.Add(displayFunction);
        }
        
        void ParseReceivedAnswer(object sender, EventArgs e)
        {
            string answer = AllAnswers[0];

            foreach(fRule rule in AllRules)
            {
                if(rule.KeywordCheck(answer)==FunctionResultIndex.ResultYes)
                {

                }
                AllAnswers.Remove(answer);
            }
        }        

        public void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            #region Locales
            SerialPort port = (SerialPort)sender;
            string
                receivedAnswer;

            int
                bufferSize = 0,
                timeOut = 0;
            #endregion

            bufferSize = port.ReadBufferSize;
            timeOut = port.ReadTimeout;

            receivedAnswer = port.ReadLine();

            AllAnswers.Add(receivedAnswer);
        }

        private void cmd_openPort_Click(object sender, EventArgs e)
        {
            Props.serialPort.PortName = "COM7";
            Props.serialPort.BaudRate = 9600;

            Props.serialPort.Open();

            Props.serialPort.DataReceived += new SerialDataReceivedEventHandler(this.DataReceivedHandler);
        }

        private void cmd_closePort_Click(object sender, EventArgs e)
        {
            Props.serialPort.Close();
        }

        private void cmd_addSimSerialAnswer_Click(object sender, EventArgs e)
        {
            string answer = txt_simSerialInput.Text;

            if(answer!="")
            {
                AllAnswers.Add(answer);
            }
            else
            {
                MessageBox.Show("Eingabe fehlt!");
            }
        }

        private void cmd_createFunction_Click(object sender, EventArgs e)
        {
            string functionName = "";// txt_newFunctionName.Text;

            if(functionName!="")
            {
                if(!DoesFunctionExist(functionName))
                {
                    Function newFunction = new Function()
                    {
                        name = functionName,
                        index = AllFunctions.Count
                    };

                    AllFunctions.Add(newFunction);

                    //txt_newFunctionName.Text = "";
                }
                else
                {
                    MessageBox.Show("Besteht schon!");
                }
            }
            else
            {
                MessageBox.Show("Eingabe fehlt");
            }
        }

        private void cob_chooseFunction_DropDown(object sender, EventArgs e)
        {
            ComboBox senderBox = sender as ComboBox;

            senderBox.Items.Clear();
            foreach(Function f in AllFunctions)
            {
                senderBox.Items.Add(f.name);
            }
        }

        private bool DoesFunctionExist(string functionName)
        {
            foreach(Function f in AllFunctions)
            {
                if(f.name==functionName)
                {
                    return true;
                }
            }

            return false;
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
