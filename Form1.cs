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

        List<FunctionRule> AllRules = new List<FunctionRule>();
        ExtendedList<string> AllAnswers = new ExtendedList<string>();
        List<Function> AllFunctions = new List<Function>();

        Panel[,] panelArray = new Panel[13, 13];

        /**********************/
        /*** IMPLEMENTATION ***\
        /**********************/

        private void Form1_Load(object sender, EventArgs e)
        {
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

                    newPanel.MouseEnter += new EventHandler(pan_field_MouseEnter);
                    newPanel.MouseLeave += new EventHandler(pan_field_MouseLeave);

                    newPanel.Name = "field1_" + i + "x" + k;
                    newPanel.Tag = i + "x" + k;
                    newPanel.Parent = pan_field1;

                    newPanel.Location = newLocation;

                    panelArray[i, k] = newPanel;

                    pan_field1.Controls.Add(newPanel);

                    newLocation.X += 20;
                }
                newLocation.Y += 20;
            }

            AllAnswers = new ExtendedList<string>();

            AllAnswers.OnAdd += new EventHandler(ParseReceivedAnswer);
        }

        private void pan_field_MouseEnter(object sender, EventArgs e)
        {
            Panel senderPanel = sender as Panel;

            string panelTag = senderPanel.Tag.ToString();

            int
                i = Convert.ToInt32(panelTag.Split('x')[0]),
                k = Convert.ToInt32(panelTag.Split('x')[1]);

            if(i>0 && k>0)
            {
                panelArray[i - 1, k - 1].BackColor = Color.Blue;
            }
            
            if(k>0 && i<13)
            {
                panelArray[i + 1, k - 1].BackColor = Color.Blue;
            }

            if(k>0)
            {
                panelArray[i, k - 1].BackColor = Color.Blue;
            }

            if (k < 13)
            {
                panelArray[i, k + 1].BackColor = Color.Blue;
            }

            if (i > 0)
            {
                panelArray[i - 1, k].BackColor = Color.Blue;
            }

            if (i < 13)
            {
                panelArray[i + 1, k].BackColor = Color.Blue;
            }

            if (k<13 && i>0)
            {
                panelArray[i - 1, k + 1].BackColor = Color.Blue;

            }

            if(k<13 && i<13)
            {
                panelArray[i + 1, k + 1].BackColor = Color.Blue;
            }

            senderPanel.BackColor = Color.Red;
        }

        private void pan_field_MouseLeave(object sender, EventArgs e)
        {
            Panel senderPanel = sender as Panel;

            string panelTag = senderPanel.Tag.ToString();

            int
                i = Convert.ToInt32(panelTag.Split('x')[0]),
                k = Convert.ToInt32(panelTag.Split('x')[1]);

            if (i > 0 && k > 0)
            {
                panelArray[i - 1, k - 1].BackColor = Color.LightBlue;
            }

            if (k > 0 && i < 13)
            {
                panelArray[i + 1, k - 1].BackColor = Color.LightBlue;
            }

            if (k > 0)
            {
                panelArray[i, k - 1].BackColor = Color.LightBlue;
            }

            if (k < 13)
            {
                panelArray[i, k + 1].BackColor = Color.LightBlue;
            }

            if (i > 0)
            {
                panelArray[i - 1, k].BackColor = Color.LightBlue;
            }

            if (i < 13)
            {
                panelArray[i + 1, k].BackColor = Color.LightBlue;
            }

            if (k < 13 && i > 0)
            {
                panelArray[i - 1, k + 1].BackColor = Color.LightBlue;

            }

            if (k < 13 && i < 13)
            {
                panelArray[i + 1, k + 1].BackColor = Color.LightBlue;
            }

            senderPanel.BackColor = Color.LightBlue;
        }

        void ParseReceivedAnswer(object sender, EventArgs e)
        {
            string answer = AllAnswers[0];

            foreach(FunctionRule rule in AllRules)
            {
                switch(rule.displayOperationIndex)
                {
                    case (Int32)Props.DisplayOperation.YesNo:
                    case (Int32)Props.DisplayOperation.YesNoIndiv:
                    case (Int32)Props.DisplayOperation.RawData:
                    case (Int32)Props.DisplayOperation.Keyword:
                        {
                            rule.ExecuteReaction(answer);

                            break;
                        }
                    default:
                        {
                            if (rule.ExecuteOperation(answer))
                            {
                                rule.ExecuteReaction(answer);
                            }

                            break;
                        }
                }

                AllAnswers.Remove(answer);
            }
        }

        private void cmd_addNewRule_Click(object sender, EventArgs e)
        {
            int
                parentIndex = cob_newRuleChooseFunction.SelectedIndex,
                targetObjectIndex = cob_newRuleChooseObject.SelectedIndex,
                operationIndex = cob_newRule_chooseOperation.SelectedIndex,
                displayIndex = cob_newRuleChooseDisplayItem.SelectedIndex,
                answerIndex = cob_newRule_chooseSendOption.SelectedIndex,
                serialSourceIndexPos = cob_newRule_sendFromObject_pos.SelectedIndex,
                serialSourceIndexNeg = cob_newRule_sendFromObject_neg.SelectedIndex;

            bool
                enableSerialAnswer = chb_newRule_sendAnswer.Checked,
                enableDisplayAction = chb_newRule_allowDisplay.Checked;

            if(enableDisplayAction || enableSerialAnswer)
            {
                FunctionRule newFunction = new FunctionRule()
                {
                    keyWord = txt_newRuleKeyword.Text,
                    displayTextPos = txt_newRuleDisplayText_pos.Text,
                    displayTextNeg = txt_newRuleDisplayText_neg.Text,
                    displayText = txt_newRuleDisplayText_pos.Text,

                    sendSerialMessage = enableSerialAnswer,
                    displaySomeContent = enableDisplayAction,
                    serialAnswerPos = txt_newRule_posSendText.Text,
                    serialAnswerNeg = txt_newRule_negSendText.Text,

                    displayOperationIndex = displayIndex,
                    keywordOperationIndex = operationIndex,
                    answerOperationIndex = answerIndex,

                    ParentFunction = AllFunctions[parentIndex],

                    targetLabel = AllFunctions[parentIndex].targetObjects[targetObjectIndex],
                    sourceObjectAnswerPos = AllFunctions[parentIndex].targetObjects[serialSourceIndexPos],
                    sourceObjectAnswerNeg = AllFunctions[parentIndex].targetObjects[serialSourceIndexNeg]
                };

                AllRules.Add(newFunction);
            }
            else
            {
                MessageBox.Show("Diese Funktion führt nichts aus!");
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

                    txt_newFunctionName.Text = "";
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

            string
                objectName = "lbl_" + txt_newObjectName.Text,
                objectContent = txt_newObjectContent.Text;

            bool connectToFunction = chb_newObjectDisplayObject.Checked;

            int
                objectCobIndex = cob_newObjectType.SelectedIndex,
                functionIndex = cob_newObjectFunction.SelectedIndex,
                x_pos = Convert.ToInt32(txt_newObject_xPos.Text),
                y_pos = Convert.ToInt32(txt_newObject_yPos.Text),
                width = Convert.ToInt32(txt_newObject_width.Text);

            // Check if the content shall be set or not.
            if(objectContent=="" && connectToFunction)
            {
                if(objectCobIndex==(Int32)Props.ObjectIndex.Label)
                {
                    objectContent = "leer";
                }
            }
            else if(objectContent=="" && !connectToFunction)
            {
                MessageBox.Show("Displayobjekte dürfen nicht leer sein!");
                objectCobIndex = (Int32)Props.ObjectIndex.Invalid;
            }

            Point newLocation = new Point(x_pos, y_pos);

            switch (objectCobIndex)
            {
                case (Int32)Props.ObjectIndex.Label:
                    {
                        Label newLabel = new Label()
                        {
                            Name = objectName,
                            Parent = pan_workspace,
                            Text = objectContent,
                            Location = newLocation,
                            Width = width
                        };

                        newTargetObject = newLabel;
                        break;
                    }
                case (Int32)Props.ObjectIndex.Textbox:
                    {
                        TextBox newLabel = new TextBox()
                        {
                            Name = objectName,
                            Parent = pan_workspace,
                            Text = objectContent,
                            Location = newLocation,
                            Width = width
                        };

                        newTargetObject = newLabel;

                        break;
                    }

                case (Int32)Props.ObjectIndex.Invalid:
                    {
                        // Object is invalid and will not be created.
                        break;
                    }
            }

            if(newTargetObject!=null && connectToFunction)
            {
                AllFunctions[functionIndex].targetObjects.Add(newTargetObject);
            }
            else if(newTargetObject==null && !connectToFunction)
            {
                if(objectCobIndex != (Int32)Props.ObjectIndex.Invalid)
                {
                    MessageBox.Show("newTargetObject=null");
                }
            }

            lbl_preview.Visible = 
                txt_preview.Visible = false;

            txt_newObjectContent.Text =
                txt_newObjectName.Text = "";
            cob_newObjectFunction.SelectedIndex =
                cob_newObjectType.SelectedIndex = -1;

            chb_newObjectDisplayObject.Checked = false;
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

        private void txt_newObject_Pos_TextChanged(object sender, EventArgs e)
        {          
            try
            {
                if (txt_newObject_xPos.Text != "" && txt_newObject_width.Text != "" && txt_newObject_xPos.Text != "")
                {
                    int
                        x = Convert.ToInt32(txt_newObject_xPos.Text),
                        y = Convert.ToInt32(txt_newObject_yPos.Text),
                        width = Convert.ToInt32(txt_newObject_width.Text);                  

                    Point newLocation = new Point(x, y);

                    switch (cob_newObjectType.SelectedIndex)
                    {
                        case (Int32)Props.ObjectIndex.Label:
                            {
                                lbl_preview.Width = width;
                                lbl_preview.Visible = true;
                                lbl_preview.Location = newLocation;
                                break;
                            }
                        case (Int32)Props.ObjectIndex.Textbox:
                            {
                                txt_preview.Width = width;
                                txt_preview.Visible = true;
                                txt_preview.Location = newLocation;
                                break;
                            }
                    }
                }
            }
            catch
            {
                // Nothing.
            }

        }

        private void chb_newObjectDisplayObject_CheckedChanged(object sender, EventArgs e)
        {
            cob_newObjectFunction.Enabled = chb_newObjectDisplayObject.Checked;
        }

        private void cob_newRuleChooseDisplayItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cob_newRuleChooseDisplayItem.SelectedIndex;

            switch (index)
            {
                case (Int32)Props.DisplayOperation.DisplayText:
                    {
                        txt_newRuleGeneralText.Enabled = true;
                        txt_newRuleDisplayText_pos.Enabled =
                            txt_newRuleDisplayText_neg.Enabled = false;

                        break;
                    }
                case (Int32)Props.DisplayOperation.YesNoIndiv:
                    {
                        txt_newRuleGeneralText.Enabled = false;

                        txt_newRuleDisplayText_pos.Enabled =
                            txt_newRuleDisplayText_neg.Enabled = true;

                        break;
                    }
                default:
                    {
                        txt_newRuleGeneralText.Enabled =
                            txt_newRuleDisplayText_pos.Enabled =
                            txt_newRuleDisplayText_neg.Enabled = false;

                        break;
                    }
            }
        }

        private void cob_newRule_chooseOperation_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cob_newRule_chooseOperation.SelectedIndex;

            switch (index)
            {
                case (Int32)Props.KeywordOperation.DisplayContent:
                    {
                        txt_newRuleKeyword.Enabled = false;
                        cob_newRuleChooseDisplayItem.SelectedIndex = (Int32)Props.DisplayOperation.RawData;
                        break;
                    }
                default:
                    {
                        txt_newRuleKeyword.Enabled = true;
                        break;
                    }
            }

        }

        private void chb_newRule_sendAnswer_CheckedChanged(object sender, EventArgs e)
        {
            txt_newRule_posSendText.Enabled =
                txt_newRule_negSendText.Enabled =
                cob_newRule_chooseSendOption.Enabled =
                cob_newRule_sendFromObject_neg.Enabled =
                cob_newRule_sendFromObject_pos.Enabled =
                chb_newRule_sendAnswer.Checked;
        }

        private void cob_newRule_sendFromObject_DropDown(object sender, EventArgs e)
        {
            ComboBox senderBox = sender as ComboBox;

            senderBox.Items.Clear();

            int index = cob_newRuleChooseFunction.SelectedIndex;

            foreach (Function f in AllFunctions)
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
    }    
}
