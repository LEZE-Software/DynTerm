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
    public partial class Form_Settings : Form
    {
        public Form_Settings(Form_Center mainFM)
        {
            this.mainFM = mainFM;
            InitializeComponent();
        }

        Form_Center mainFM;

        private void CheckBox_Changed(object sender, EventArgs e)
        {
            CheckBox senderBox = sender as CheckBox;

            int idx = Convert.ToInt32(senderBox.Checked);
            senderBox.Image = images_activate.Images[idx];
        }

        private void Form_Settings_FormClosing(object sender, FormClosingEventArgs e)
        {
            SubFormManager.ExternCloseSubForm(SubFormManager.SubFormIndex.Settings);
        }
    }
}
