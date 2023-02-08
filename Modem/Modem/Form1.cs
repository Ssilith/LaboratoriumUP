using System;
using System.IO.Ports;
using System.Threading;
using System.Windows.Forms;

namespace Modem
{
    public partial class Form1 : Form
    {
        SerialPort _serialPort;
        Thread reader;

        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            bool result = ConnectPort();
            if (result == true)
                MessageBox.Show("Połączono");
            else MessageBox.Show("Nie udało się połączyć");
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            Send(textBoxSent.Text);
        }

        public bool ConnectPort()
        {
            int bits = Int32.Parse(textBoxBits.Text);
            int speed = Int32.Parse(textBoxSpeed.Text);
            string port = textBoxPort.Text;

            this._serialPort = new SerialPort(port, speed, Parity.None, bits, StopBits.One);

            if (_serialPort != null)
                _serialPort.Open();

            if (_serialPort.IsOpen)
            {
                _serialPort.Handshake = Handshake.RequestToSendXOnXOff;
                _serialPort.DtrEnable = true;


                reader = new Thread(Read);
                reader.Start();
                return true;
            }
            else return false;
        }

        public void Read()
        {
            while (_serialPort.IsOpen)
            {
                try
                {
                    string message = _serialPort.ReadExisting();
                    if (message.Length > 0)
                    {
                        this.Invoke((MethodInvoker)delegate ()
                       {
                           textBoxRecieved.AppendText(message + Environment.NewLine);
                       });
                    }
                }
                catch (TimeoutException) { }
            }
        }

        public void Send(string text)
        {
            if (_serialPort != null)
            {
                if (text == "+++")
                {
                    _serialPort.Write("+");
                    Thread.Sleep(1000);
                    _serialPort.Write("+");
                    Thread.Sleep(1000);
                    _serialPort.Write("+");
                    Thread.Sleep(1000);

                }
                else _serialPort.Write(text + Environment.NewLine);

            }

        }
    }
}
