using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
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
            foreach(Function f in mainFM.AllFunctions)
            {
                foreach (dynamic d in f.targetObjects)
                {
                    TextBox newBox = new TextBox()
                    {
                        Name = d.Name,
                        Location = d.Location,
                        Width = d.Width,
                        Height = d.Height
                    };

                    this.Controls.Add(newBox);
                }
            }
        }
    }
}
