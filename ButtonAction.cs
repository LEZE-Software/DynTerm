using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public class ButtonAction
    {
        public ControlObject
            targetObject,
            sourceObject;

        public int
            /// <summary>
            /// Which mouse key has been pressed?
            /// </summary>
            mouseKeyIndex,
            /// <summary>
            /// Which action shall be executed by a button?
            /// </summary>
            actionIndex,
            /// <summary>
            /// Where does the serial message come from?
            /// </summary>
            messageSourceIndex;

        public string
            serialMessageToSend;
    }
}
