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
    public partial class Form_SerialConnection : Form
    {
        public Form_SerialConnection()
        {
            InitializeComponent();
        }

        private void Form_SerialConnection_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();

            foreach (string s in ports)
            {
                cob_serialPort.Items.Add(s);
            }

            // TODO: Load the current port name in the combobox.
            // TODO: Load the current baud rate in the combobox.
        }

        private void cob_selectPort_DropDown(object sender, EventArgs e)
        {
            // TODO: Load all current available port names.
        }

        private void cmd_refresh_Click(object sender, EventArgs e)
        {
            cob_serialPort.Items.Clear();

            string[] ports = SerialPort.GetPortNames();

            foreach (string s in ports)
            {
                cob_serialPort.Items.Add(s);
            }
        }

        private void cmd_saveSettings_Click(object sender, EventArgs e)
        {
            string name = cob_serialPort.Text;
            int baudrate = Convert.ToInt32(cob_baudrate.Text);

            Props.serialPort = new SerialPort(cob_serialPort.Text, baudrate);
            Props.lineEnd = (LineEndIndex)cob_lineEnd.SelectedIndex;

            // TODO: Set the selected connection settings.
            // TODO: Save the serial connection in the external serial.xml.
        }
    }
}
