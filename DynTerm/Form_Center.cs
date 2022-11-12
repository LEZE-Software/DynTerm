using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO.Ports;
using System.Windows.Forms;

namespace term
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        public class MyList<T> : List<T>
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

        MyList<string> AllAnswers = new MyList<string>();

        List<SerialFunction> AllFunctions = new List<SerialFunction>();

        /**********************/
        /*** IMPLEMENTATION ***\
        /**********************/

        private void Form_Center_Load(object sender, EventArgs e)
        {
            foreach (string s in SerialPort.GetPortNames())
            {
                cob_choosePort.Items.Add(s);
            }

            Props.stack_rawAnswers = new Props.MyList<string>();

            Props.stack_rawAnswers.OnAdd += new EventHandler(List_AddItemEvent);
        }

        void List_AddItemEvent(object sender, EventArgs e)
        {
            foreach(SerialFunction s in AllFunctions)
            {
                if(AllAnswers[0]==s.keyWord)
                {

                }
            }
        }

        public void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort port = (SerialPort)sender;

            AllAnswers.Add(port.ReadLine());

            this.Invoke(new Action(() =>
            {
                lbl_traffic.Text += "\n" + port.ReadLine();
                // Leo.
            }));
        }

        private void cmd_connect_Click(object sender, EventArgs e)
        {
            if(Props.serialPort.IsOpen)
            {
                Serial_functions.ClosePort(this);
                cmd_connect.Text="open port";
            }
            else
            {
                Props.serialPort.PortName = cob_choosePort.Text;
                Props.serialPort.BaudRate = 9600;

                Serial_functions.OpenPort(this);
                cmd_connect.Text="close port";
            }
        }

        private void cmd_createNewFunction(object sender, EventArgs e)
        {
            SerialFunction newFunction = new SerialFunction
            {
                keyWord = txt_keyword.Text,
                displayText = txt_displayText.Text,
                functionIdx = cob_chooseFunction.Text,
                functionPanel = pan_functionTest
            };

            AllFunctions.Add(newFunction);
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Form_Main
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "Form_Main";
            this.Load += new System.EventHandler(this.Form_Main_Load);
            this.ResumeLayout(false);

        }

        private void Form_Main_Load(object sender, EventArgs e)
        {

        }
    }

    public class SerialFunction
    {
        public string
            keyWord,
            displayText,
            functionIdx;

        public Label targetLabel;

        public Panel functionPanel;
    }
}