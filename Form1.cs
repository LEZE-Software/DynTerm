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

        SerialPort localPort = new SerialPort();

        List<SerialFunction> AllFunctions = new List<SerialFunction>();

        MyList<string> AllAnswers = new MyList<string>();

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

            AllAnswers = new MyList<string>();

            AllAnswers.OnAdd += new EventHandler(List_AddItemEvent);
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

        void List_AddItemEvent(object sender, EventArgs e)
        {
            MessageBox.Show(AllAnswers[0]);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SerialFunction newFunction = new SerialFunction()
            {
                keyWord = txt_keyword.Text,
                displayText = txt_displayText.Text,
                functionIdx = cob_chooseFunction.SelectedIndex
            };

            AllFunctions.Add(newFunction);
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

        private void button2_Click(object sender, EventArgs e)
        {
            localPort.PortName = "COM7";
            localPort.BaudRate = 9600;

            localPort.Open();

            localPort.DataReceived += new SerialDataReceivedEventHandler(this.DataReceivedHandler);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            localPort.Close();
        }
    }

    public class SerialFunction
    {
        public string
            keyWord,
            displayText;

        public int functionIdx;

        public Label targetLabel;
    }
}
