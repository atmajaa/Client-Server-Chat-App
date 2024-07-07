using SimpleTCP;
using System;
using System.Text;

namespace Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SimpleTcpClient client;

        private void connectBtn_Click(object sender, EventArgs e)
        {
            try
            {
                client.Connect(textBox1.Text, Convert.ToInt32(textBox2.Text));
                textStatus.Text += "Connected to server.\n";
                connectBtn.Enabled = false; // Disable the connect button after connecting
            }
            catch (Exception ex)
            {
                textStatus.Text += $"Failed to connect: {ex.Message}\n";
                connectBtn.Enabled = true; // Enable the connect button if connection fails
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            client = new SimpleTcpClient();
            client.StringEncoder = Encoding.UTF8;
            client.DataReceived += Client_DataReceived;
        }

        private void Client_DataReceived(object sender, SimpleTCP.Message e)
        {
            textStatus.Invoke((MethodInvoker)delegate ()
            {
                textStatus.Text += e.MessageString + "\n";
            });
        }

        private void sendBtn_Click(object sender, EventArgs e)
        {
            if (client.TcpClient != null && client.TcpClient.Connected)
            {
                client.WriteLineAndGetReply(textMsg.Text, TimeSpan.FromSeconds(5));
            }
            else
            {
                textStatus.Text += "Client is not connected to the server.\n";
            }
        }
    }
}
