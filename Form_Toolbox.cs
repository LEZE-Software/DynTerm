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
    public partial class Form_Toolbox : Form
    {
        public Form_Toolbox()
        {
            InitializeComponent();
        }

        private void Form_Toolbox_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listToolbox.SelectedIndex!=-1)
            {
                switch((ObjectIndex)listToolbox.SelectedIndex)
                {
                    case ObjectIndex.Label:
                        {
                            Props.newObjectToCreate.rootObject = new Label();
                            break;
                        }
                    case ObjectIndex.Button:
                        {
                            Props.newObjectToCreate.rootObject = new Button();
                            break;
                        }
                    case ObjectIndex.Combo:
                        {
                            Props.newObjectToCreate.rootObject = new ComboBox();
                            break;
                        }
                    case ObjectIndex.Textbox:
                        {
                            Props.newObjectToCreate.rootObject = new TextBox();
                            break;
                        }
                }
            }        
        }
    }
}
