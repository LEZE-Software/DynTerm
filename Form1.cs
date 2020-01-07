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

namespace Game
{
    public partial class Form1 : Form
    {
        public Form1()
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

        SerialPort localPort = new SerialPort();

        enum ObjectIndex
        {
            Label,
            Button,
            Combo,
            LAST_INDEX
        }

        List<FunctionRule> AllRules = new List<FunctionRule>();
        ExtendedList<string> AllAnswers = new ExtendedList<string>();
        List<Function> AllFunctions = new List<Function>();

        /**********************/
        /*** IMPLEMENTATION ***\
        /**********************/

        private void Form1_Load(object sender, EventArgs e)
        {
            int leo = (Int32)ObjectIndex.Label;

            Point newLocation = new Point(0, 0);

            for(int i=0;i<=12;i++)
            {
                newLocation.X = 0;
                for(int k=0;k<=12;k++)
                {
                    Panel newPanel = new Panel()
                    {
                        Width = 18,
                        Height = 18,
                        BackColor = Color.LightBlue,
                    };

                    newPanel.MouseHover += new EventHandler(pan_field_MouseOver);
                    newPanel.MouseLeave += new EventHandler(pan_field_MouseLeave);

                    newPanel.Name = "field1_" + i + k;
                    newPanel.Parent = pan_field1;

                    newPanel.Location = newLocation;

                    pan_field1.Controls.Add(newPanel);

                    newLocation.X += 20;
                }
                newLocation.Y += 20;
            }

            AllAnswers = new ExtendedList<string>();

            AllAnswers.OnAdd += new EventHandler(ParseReceivedAnswer);
        }

        private void pan_field_MouseOver(object sender, EventArgs e)
        {
            Panel senderPanel = sender as Panel;

            senderPanel.BackColor = Color.Red;
        }

        private void pan_field_MouseLeave(object sender, EventArgs e)
        {
            Panel senderPanel = sender as Panel;

            senderPanel.BackColor = Color.LightBlue;
        }

        void ParseReceivedAnswer(object sender, EventArgs e)
        {
            string answer = AllAnswers[0];

            foreach(FunctionRule rule in AllRules)
            {
                if(rule.keyWord==answer)
                {
                    rule.targetLabel.Text = rule.displayText;

                    AllAnswers.RemoveAt(0);
                }
            }
        }

        private void cmd_addNewRule_Click(object sender, EventArgs e)
        {
            int
                parentIndex = cob_newRuleChooseFunction.SelectedIndex,
                obejctIndex = cob_newRuleChooseObject.SelectedIndex;

            FunctionRule newFunction = new FunctionRule()
            {
                keyWord = txt_keyword.Text,
                displayText = txt_displayText.Text,
                ParentFunction = AllFunctions[parentIndex],
                targetLabel = AllFunctions[parentIndex].targetObjects[obejctIndex]
            };

            AllRules.Add(newFunction);
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
            localPort.PortName = "COM7";
            localPort.BaudRate = 9600;

            localPort.Open();

            localPort.DataReceived += new SerialDataReceivedEventHandler(this.DataReceivedHandler);
        }

        private void cmd_closePort_Click(object sender, EventArgs e)
        {
            localPort.Close();
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
            string functionName = txt_newFunctionName.Text;

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

        private void cmd_createNewObject_Click(object sender, EventArgs e)
        {
            dynamic newTargetObject=null;
            int objectCobIndex = cob_newObjectType.SelectedIndex;
            string objectName = txt_newObjectName.Text;
            int functionIndex = cob_newObjectFunction.SelectedIndex;

            int x_pos = Convert.ToInt32(txt_newObject_xPos.Text);
            int y_pos = Convert.ToInt32(txt_newObject_yPos.Text);

            switch(objectCobIndex)
            {
                case (Int32)ObjectIndex.Label:
                    {
                        Point newLocation = new Point(x_pos, y_pos);
                        Label newLabel = new Label()
                        {
                            Name = objectName,
                            Parent = pan_workspace,
                            Text = "leer",
                            Location = newLocation
                        };

                        newTargetObject = newLabel;
                        break;
                    }
            }

            if(newTargetObject!=null)
            {
                AllFunctions[functionIndex].targetObjects.Add(newTargetObject);
            }
            else
            {
                MessageBox.Show("newTargetObject=null");
            }

            lbl_preview.Visible = false;
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

        private void cob_newRuleChooseFunction_SelectedIndexChanged(object sender, EventArgs e)
        {
            cob_newRuleChooseObject.Items.Clear();

            int index = cob_newRuleChooseFunction.SelectedIndex;

            foreach (Function f in AllFunctions)
            {
                if(f.index==index)
                {
                    foreach(dynamic targetObject in f.targetObjects)
                    {
                        cob_newRuleChooseObject.Items.Add(targetObject.Name);
                    }                
                }
            }
        }

        private void txt_newObject_yPos_TextChanged(object sender, EventArgs e)
        {
            lbl_preview.Visible = true;

            try
            {
                if (txt_newObject_xPos.Text != "" && txt_newObject_xPos.Text != "")
                {
                    int x = Convert.ToInt32(txt_newObject_xPos.Text);
                    int y = Convert.ToInt32(txt_newObject_yPos.Text);

                    Point newLocation = new Point(x, y);

                    lbl_preview.Location = newLocation;
                }
            }
            catch(Exception ex)
            {
                // Nothing.
            }
            
        }
    }

    public class FunctionRule
    {
        public string
            keyWord,
            displayText;

        public int functionIdx;
        public Function ParentFunction;

        public dynamic targetLabel;
    }

    public class Function
    {
        public int index;
        public string name;
        public List<dynamic> targetObjects = new List<dynamic>();
    }
}