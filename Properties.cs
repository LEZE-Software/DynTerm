using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;

namespace Game
{
    public static class Props
    {
        public enum KeywordOperation
        {
            Contains,
            ContainsNot,
            IsEqual,
            DisplayContent,
            LAST_INDEX
        }

        public enum ObjectIndex
        {
            Label,
            Button,
            Combo,
            Textbox,
            Invalid,
            LAST_INDEX
        }

        public enum DisplayOperation
        {
            Keyword,
            DisplayText,
            YesNo,
            YesNoIndiv,
            RawData,
            LAST_INDEX
        }

        public enum SendOperation
        {
            YesNo,
            Always,
            LAST_INDEX
        }

        public static SerialPort localPort = new SerialPort();
    }
}
