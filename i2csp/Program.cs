using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;

namespace i2csp
{
    class Program
    {
        static void Main(string[] args)
        {
            SerialPort MyCOMPort = new SerialPort(); // Create a new SerialPort Object

            //COM port settings to 8N1 mode 
            MyCOMPort.PortName = "COM4";            // Name of the COM port 
            MyCOMPort.BaudRate = 9600;               // Baudrate = 9600bps
            MyCOMPort.Parity = Parity.None;        // Parity bits = none  
            MyCOMPort.DataBits = 8;                  // No of Data bits = 8
            MyCOMPort.StopBits = StopBits.One;       // No of Stop bits = 1

            MyCOMPort.Open();                        // Open the port
            MyCOMPort.Write("A");                    // Write an ascii "A"
            MyCOMPort.Close();                       // Close port
        }
    }
}
