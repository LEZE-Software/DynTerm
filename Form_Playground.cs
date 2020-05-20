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
    public partial class Form_Playground : Form
    {
        public Form_Playground(Form_Center mainFM)
        {
            this.mainFM = mainFM;
            InitializeComponent();
        }

        Form_Center mainFM;

        private void Form_Playground_Load(object sender, EventArgs e)
        {

        }

        private void Form_Playground_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(!Props.shallClose)
            {
                e.Cancel = true;
            }
        }
    }
}
