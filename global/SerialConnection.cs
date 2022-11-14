using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Ports;

namespace term
{
    public static class Serial_Manager
    {
        private static SerialPort port;
        public static LineEndIndex lineEnd { get; private set; }
        
        public static void SavePortSettings()
        {
            throw new NotImplementedException();
        }

        public static string GetCurrentPortName
        {
            get { return port.PortName; }
        }

        public static bool GetConnectionState
        {
            get { return port.IsOpen; }
        }

        private static void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            #region Locales
            SerialPort port = (SerialPort)sender;
            string
                receivedAnswer;

            int
                bufferSize = 0,
                timeOut = 0;
            #endregion

            bufferSize = port.ReadBufferSize;
            timeOut = port.ReadTimeout;

            receivedAnswer = port.ReadLine();

            AllAnswers.Add(receivedAnswer);
        }

        public static void Initialize()
        {
            AllAnswers.OnAdd += new EventHandler(ParseReceivedAnswer);
        }

        public static void SetPortSettings(string portName, int baudRate, LineEndIndex lineEnd)
        {
            port = new SerialPort(portName, baudRate);
            port.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
        }

        public static void ParseReceivedAnswer(object sender, EventArgs e)
        {
            string answer = AllAnswers[0];

            foreach (fRule rule in RuleManager.GetListOfRules)
            {
                rule.ExecuteRule(answer);

                AllAnswers.Remove(answer);
            }
        }

        public class ExtendedList<T> : List<T>
        {
            public event EventHandler OnAdd;

            public new void Add(T item) // "new" to avoid compiler-warnings, because we're hiding a method from base-class
            {
                base.Add(item);

                if (null != OnAdd)
                {
                    OnAdd(this, null);
                }
            }
        }

        public static ExtendedList<string> AllAnswers = new ExtendedList<string>();
    }

    public enum LineEndIndex
    {
        None,
        CR,
        LF,
        CRLF,
        LAST_INDEX
    }
}
