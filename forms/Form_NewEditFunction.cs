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
    public partial class Form_NewEditFunction : Form
    {
        public Form_NewEditFunction(bool edit)
        {
            InitializeComponent();

            if(edit && FunctionManager.GetListOfFunctions.Count > 0)
            {
                SwitchMode(Mode.View);
            }
            else
            {
                SwitchMode(Mode.New);
            }
        }

        Function selectedFunction = new Function();
        Mode currentMode = Mode.View;

        private void Form_NewEditFunction_Load(object sender, EventArgs e)
        {
            foreach ( Function f in FunctionManager.GetListOfFunctions)
            {
                list_show.Items.Add(f.name);
            }

            chb_activate.Checked = false;
            chb_activate.Image = images_activate.Images[0];
        }

        private void SwitchMode(Mode m)
        {
            switch(m)
            {
                case Mode.Edit:
                    {
                        title_workbench.Text = "Funktionen bearbeiten";
                        txt_name.Enabled = true;
                        cmd_delete.Enabled = true;
                        chb_activate.Enabled = true;
                        txt_comment.Enabled = true;
                        break;
                    }
                case Mode.New:
                    {
                        title_workbench.Text = "Funktion hinzufügen";
                        txt_name.Enabled = true;
                        cmd_delete.Enabled = false;
                        chb_activate.Enabled = true;
                        txt_comment.Enabled = true;
                        txt_comment.Text = "< leer >";
                        break;
                    }
                case Mode.View:
                    {
                        txt_name.Enabled = false;
                        cmd_delete.Enabled = false;
                        chb_activate.Enabled = false;
                        txt_comment.Enabled = false;
                        txt_comment.Text = "< leer >";
                        break;
                    }
            }

            currentMode = m;
        }

        private enum Mode
        {
            View,
            New,
            Edit,
            LAST_INDEX
        }

        private void list_show_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(list_show.SelectedIndex != -1)
            {
                SwitchMode(Mode.Edit);

                selectedFunction = FunctionManager.GetFunctionFromName(list_show.SelectedItem.ToString());

                txt_name.Text = selectedFunction.name;
                txt_comment.Text = selectedFunction.comment;
                chb_activate.Checked = selectedFunction.active;
            }
            else
            {
                if(list_show.Items.Count > 0)
                {
                    SwitchMode(Mode.View);
                }
                else
                {
                    SwitchMode(Mode.New);
                }
            }          
        }

        private void cmd_save_Click(object sender, EventArgs e)
        {
            selectedFunction.name = txt_name.Text;
            selectedFunction.comment = txt_comment.Text;
            selectedFunction.active = chb_activate.Checked;

            switch(currentMode)
            {
                case Mode.Edit:
                    {
                        FunctionManager.UpdateFunction(selectedFunction);
                        break;
                    }
                case Mode.New:
                    {
                        FunctionManager.AddFunction(selectedFunction);
                        break;
                    }
                case Mode.View:
                    {
                        MessageBox.Show("Es gibt nichts zu speichern.");
                        break;
                    }
            }

            list_show.Items.Clear();
            
            foreach(Function f in FunctionManager.GetListOfFunctions)
            {
                list_show.Items.Add(f.name);
            }

            txt_name.Text = "";
            txt_comment.Text = "< leer >";
            chb_activate.Checked = false;
        }

        private void chb_activate_CheckedChanged(object sender, EventArgs e)
        {
            int index = Convert.ToInt32(chb_activate.Checked);

            chb_activate.Image = images_activate.Images[index];
        }

        private void cmd_delete_Click(object sender, EventArgs e)
        {
            txt_name.Text = "";
            txt_comment.Text = "< leer >";
            chb_activate.Checked = false;

            int idx = list_show.SelectedIndex;
            FunctionManager.RemoveFunction(idx, list_show.SelectedItem.ToString());
            list_show.Items.RemoveAt(idx);


        }
    }
}
