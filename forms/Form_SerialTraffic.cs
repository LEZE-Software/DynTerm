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
    public partial class Form_SerialTraffic : Form
    {
        Form_Center mainForm;

        public Form_SerialTraffic(Form_Center main)
        {
            this.mainForm = main;
            InitializeComponent();
        }

        public void AddTrafficItem(string text)
        {
            list_traffic.Items.Add(text);
        }

        private void Form_SerialTraffic_FormClosing(object sender, FormClosingEventArgs e)
        {
            SubFormManager.ExternCloseSubForm(SubFormManager.SubFormIndex.Traffic);
        }
    }
}
