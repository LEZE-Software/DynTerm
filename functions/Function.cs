using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace term
{
    public class Function
    {
        public int index;
        public string name;
        public string comment;
        public bool active;
        public List<Panel> targetObjects = new List<Panel>();

        public void AddPanel(Panel p)
        {
            targetObjects.Add(p);
        }
    }
}
