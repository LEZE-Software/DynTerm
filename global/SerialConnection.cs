using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Ports;

namespace term
{
    public static class SerialConnection
    {
        private static SerialPort port;

        public static string GetCurrentPortName
        {
            get { return port.PortName; }
        }

        public static bool GetConnectionState
        {
            get { return port.IsOpen; }
        }

        public static void SetPortConfiguration(string portName, int baudrate)
        {
            port = new SerialPort(portName, baudrate);
        }
    }
}
