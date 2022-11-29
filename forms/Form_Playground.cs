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
            SubFormManager.ExternCloseSubForm(SubFormManager.SubFormIndex.Playground);
        }

        private void cmd_Help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Öffnen Sie das Panelmenü mit einem Rechtsklick, um Panele zu bearbeiten.", "Hinweis", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void context_panel_Opening(object sender, CancelEventArgs e)
        {
            bool edit = (Props.PanelToEdit.Tag.ToString() != "new");

            cmd_EditPanel.Enabled =
                cmd_ActivatePanel.Enabled =
                cmd_LockPanel.Enabled =
                cmd_DeletePanel.Enabled = edit;
        }

        private void cmd_CreateNewPanel_Click(object sender, EventArgs e)
        {
            SubFormManager.OpenSubForm(SubFormManager.SubFormIndex.PanelEditor, mainFM, false);
        }

        private void PrePanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                Props.PanelToEdit = sender as Panel;
            }
        }

        private void cmd_EditPanel_Click(object sender, EventArgs e)
        {
            SubFormManager.OpenSubForm(SubFormManager.SubFormIndex.PanelEditor, mainFM, true);
        }
    }
}
