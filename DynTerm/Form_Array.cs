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
    public partial class Form_Array : Form
    {
        public Form_Array(Form_Center mainFM)
        {
            this.mainFM = mainFM;
            InitializeComponent();
        }

        Form_Center mainFM;

        Panel[,] panelArray = new Panel[13, 13];

        private void Form_Array_Load(object sender, EventArgs e)
        {
            Point newLocation = new Point(0, 0);

            for (int i = 0; i <= 12; i++)
            {
                newLocation.X = 0;
                for (int k = 0; k <= 12; k++)
                {
                    Panel newPanel = new Panel()
                    {
                        Width = 18,
                        Height = 18,
                        BackColor = Color.LightBlue,
                    };

                    newPanel.MouseEnter += new EventHandler(pan_field_MouseEnter);
                    newPanel.MouseLeave += new EventHandler(pan_field_MouseLeave);

                    newPanel.Name = "field1_" + i + "x" + k;
                    newPanel.Tag = i + "x" + k;
                    newPanel.Parent = pan_field1;

                    newPanel.Location = newLocation;

                    panelArray[i, k] = newPanel;

                    pan_field1.Controls.Add(newPanel);

                    newLocation.X += 20;
                }
                newLocation.Y += 20;
            }
        }

        private void pan_field_MouseEnter(object sender, EventArgs e)
        {
            Panel senderPanel = sender as Panel;

            string panelTag = senderPanel.Tag.ToString();

            int
                i = Convert.ToInt32(panelTag.Split('x')[0]),
                k = Convert.ToInt32(panelTag.Split('x')[1]);

            if (i > 0 && k > 0)
            {
                panelArray[i - 1, k - 1].BackColor = Color.Blue;
            }

            if (k > 0 && i < 13)
            {
                panelArray[i + 1, k - 1].BackColor = Color.Blue;
            }

            if (k > 0)
            {
                panelArray[i, k - 1].BackColor = Color.Blue;
            }

            if (k < 13)
            {
                panelArray[i, k + 1].BackColor = Color.Blue;
            }

            if (i > 0)
            {
                panelArray[i - 1, k].BackColor = Color.Blue;
            }

            if (i < 13)
            {
                panelArray[i + 1, k].BackColor = Color.Blue;
            }

            if (k < 13 && i > 0)
            {
                panelArray[i - 1, k + 1].BackColor = Color.Blue;

            }

            if (k < 13 && i < 13)
            {
                panelArray[i + 1, k + 1].BackColor = Color.Blue;
            }

            senderPanel.BackColor = Color.Red;
        }

        private void pan_field_MouseLeave(object sender, EventArgs e)
        {
            Panel senderPanel = sender as Panel;

            string panelTag = senderPanel.Tag.ToString();

            int
                i = Convert.ToInt32(panelTag.Split('x')[0]),
                k = Convert.ToInt32(panelTag.Split('x')[1]);

            if (i > 0 && k > 0)
            {
                panelArray[i - 1, k - 1].BackColor = Color.LightBlue;
            }

            if (k > 0 && i < 13)
            {
                panelArray[i + 1, k - 1].BackColor = Color.LightBlue;
            }

            if (k > 0)
            {
                panelArray[i, k - 1].BackColor = Color.LightBlue;
            }

            if (k < 13)
            {
                panelArray[i, k + 1].BackColor = Color.LightBlue;
            }

            if (i > 0)
            {
                panelArray[i - 1, k].BackColor = Color.LightBlue;
            }

            if (i < 13)
            {
                panelArray[i + 1, k].BackColor = Color.LightBlue;
            }

            if (k < 13 && i > 0)
            {
                panelArray[i - 1, k + 1].BackColor = Color.LightBlue;

            }

            if (k < 13 && i < 13)
            {
                panelArray[i + 1, k + 1].BackColor = Color.LightBlue;
            }

            senderPanel.BackColor = Color.LightBlue;
        }
    }
}
