using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace term
{
    public class ControlObject
    {
        public ButtonAction local_buttonAction;

        public dynamic rootObject;

        public int objectIndex;

        public Function parentFunction;

        public Color
            commonBackColor,
            commonFontColor;
    }
}
