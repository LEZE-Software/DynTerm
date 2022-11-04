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

        private void Form_Playground_MouseMove(object sender, MouseEventArgs e)
        {
            if(Props.previewMode)
            {
                switch (Props.previewIndex)
                {
                    case PreviewObjectIndex.Button:
                        {
                            Point newPos = this.PointToClient(Cursor.Position);

                            if(newPos.X>=this.Width-150 || newPos.Y>=this.Height-150)
                            {
                                newPos.X = newPos.X + 7;
                                newPos.Y = newPos.Y + 7;
                            }
                            else
                            {
                                newPos.X = newPos.X - cmd_preview.Width - 7;
                                newPos.Y = newPos.Y - cmd_preview.Height - 7;
                            }
                            
                            cmd_preview.Location = newPos;
                            break;
                        }
                }
            }
            else if (Props.resizeMode)
            {
                switch (Props.previewIndex)
                {
                    case PreviewObjectIndex.Button:
                        {
                            Point cursorPos = this.PointToClient(Cursor.Position);

                            Point buttonPos = cmd_preview.Location;

                            int width = cursorPos.X - buttonPos.X-7;
                            int height = cursorPos.Y - buttonPos.Y-7;

                            cmd_preview.Height = height;
                            cmd_preview.Width = width;

                            break;
                        }
                }
            }
        }

        private void Form_Playground_Click(object sender, EventArgs e)
        {
            if(Props.previewMode)
            {
                Props.previewMode = false;
                switch(Props.previewIndex)
                {
                    case PreviewObjectIndex.Button:
                        {
                            Point buttonPos = cmd_preview.Location;

                            cmd_preview.Height =
                                cmd_preview.Width = 0;
                            break;
                        }
                }
                Props.resizeMode = true;

            }
            else if(Props.resizeMode)
            {
                Props.resizeMode = false;
            }
        }

        private void toolStripSplitButton1_ButtonClick(object sender, EventArgs e)
        {

        }

        private void cmd_preview_Click(object sender, EventArgs e)
        {

        }
    }
}
