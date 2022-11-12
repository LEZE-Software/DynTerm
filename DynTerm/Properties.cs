using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;

namespace term
{
    public static class Props
    {
        public static bool
            previewMode = false,
            resizeMode = false;

        public static PreviewObjectIndex previewIndex;
        public static bool shallClose = false;
        public static SerialPort serialPort = new SerialPort();
    }

    /// <summary>
    /// The way the keyword is checked by a rule.
    /// </summary>
    public enum KeywordCheckOperation
    {
        Contains,
        ContainsNot,
        IsEqual,
        DisplayKeywordWithoutCheck,
        LAST_INDEX
    }

    /// <summary>
    /// Kind of ControlObject.
    /// </summary>
    public enum PreviewObjectIndex
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
        RawData,
        LAST_INDEX
    }

    /// <summary>
    /// Choice of the pressed mouse button.
    /// </summary>
    public enum MouseClickIndex
    {
        SingleClick,
        DoubleClick,
        LAST_INDEX
    }

    /// <summary>
    /// Which action shall be executed by a button?
    /// </summary>
    public enum ButtonActionIndex
    {
        OpenClosePort,
        SendSerial,
        ShowHideObject,
        AddToComboBox,
        LAST_INDEX
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

    public enum FunctionResultIndex
    {
        ResultYes,
        ResultNo,
        LAST_INDEX
    }

    /// <summary>
    /// What kind of output shall a function create?
    /// </summary>
    public enum KindOfOutputIndex
    {
        Serial,
        Visual,
        Both,
        None,
        LAST_INDEX
    }

    /// <summary>
    /// Where shall the message to send come from when the button is pressed?
    /// </summary>
    public enum SendOnClickMessageSourceIndex
    {
        HardSetMessage,
        FromComboBox,
        FromTextBox,
        LAST_INDEX
    }
}
