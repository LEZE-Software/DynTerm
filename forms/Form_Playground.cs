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
        public Panel PanelToEdit;

        private void Form_Playground_Load(object sender, EventArgs e)
        {

        }

        private void Form_Playground_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if(!Props.shallClose)
            //{
            //    e.Cancel = true;
            //}
        }

        private void cmd_Help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Öffnen Sie das Panelmenü mit einem Rechtsklick, um Panele zu bearbeiten.", "Hinweis", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void context_panel_Opening(object sender, CancelEventArgs e)
        {
            PanelToEdit = context_panel.Parent as Panel;
        }

        private void cmd_CreateNewPanel_Click(object sender, EventArgs e)
        {
            SubFormManager.OpenSubForm(SubFormManager.SubFormIndex.PanelEditor, mainFM, false);
        }

        private void PrePanel_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void PrePanel9_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                Props.PanelToEdit = sender as Panel;
            }
        }
    }
}
