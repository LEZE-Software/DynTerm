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
        public static bool shallClose = false;

        /// <summary>
        /// The way the keyword is checked by a rule.
        /// </summary>
        public enum KeywordOperation
        {
            Contains,
            ContainsNot,
            IsEqual,
            DisplayContent,
            LAST_INDEX
        }

        /// <summary>
        /// Kind of controlObject.
        /// </summary>
        public enum ObjectIndex
        {
            Label,
            Button,
            Combo,
            Textbox,
            Invalid,
            LAST_INDEX
        }

        /// <summary>
        /// What shall be displayed in the targetobject?
        /// </summary>
        public enum DisplayOperation
        {
            Keyword,
            DisplayText,
            YesNo,
            YesNoIndiv,
            RawData,
            LAST_INDEX
        }

        /// <summary>
        /// Choice of the pressed mouse button.
        /// </summary>
        public enum ClickIndex
        {
            SingleClick,
            DoubleClick
        }

        /// <summary>
        /// Which action shall be executed by a button?
        /// </summary>
        public enum ButtonActionIndex
        {
            OpenClosePort,
            SendSerial,
            ShowHideObject,
            AddToComboBox
        }

        /// <summary>
        /// When shall a rule send a serial answer?
        /// </summary>
        public enum SendOperationIndex
        {
            YesNo,
            Always,
            LAST_INDEX
        }

        /// <summary>
        /// Choice for the source of serial message to send on a button click.
        /// </summary>
        public enum SendOnClickMessageSourceIndex
        {
            HardSetMessage,
            FromComboBox,
            FromTextBox,
            LAST_INDEX
        }

        public static SerialPort localPort = new SerialPort();
    }
}
