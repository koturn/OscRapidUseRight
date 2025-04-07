using System;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;


namespace OscRapidUseRight
{
    /// <summary>
    /// User code of <see cref="MainForm"/>.
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Thread alternating 0's and 1's sent to "/input/UseRight".
        /// </summary>
        private Thread _thread;
        /// <summary>
        /// Send interval (milliseconds).
        /// </summary>
        private int _interval;

        /// <summary>
        /// Initialize components.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Start the thread alternating 0's and 1's sent to "/input/UseRight".
        /// </summary>
        /// <param name="udpClient"></param>
        /// <returns>Started thread.</returns>
        private Thread StartThread(UdpClient udpClient)
        {
            var thread = new Thread(param =>
            {
                var client = (UdpClient)param;
                var pressData = Encoding.ASCII.GetBytes("/input/UseRight\x00,i\x00\x00\x00\x00\x00\x01");
                var releaseData = Encoding.ASCII.GetBytes("/input/UseRight\x00,i\x00\x00\x00\x00\x00\x00");
                try
                {
                    while (true)
                    {
                        client.Send(pressData, pressData.Length);
                        Thread.Sleep(_interval);
                        client.Send(releaseData, releaseData.Length);
                        Thread.Sleep(_interval);
                    }
                }
                catch (ThreadInterruptedException)
                {
                    // Do nothing
                }
                finally
                {
                    client.Send(releaseData, releaseData.Length);
                    client.Dispose();
                }
            })
            {
                IsBackground = true
            };
            thread.Start(udpClient);

            return thread;
        }

        /// <summary>
        /// Request to stop thread.
        /// </summary>
        /// <param name="thread">Thread to stop.</param>
        /// <param name="timeout">Wait timeout for stopping the thread.</param>
        private void StopThread(Thread thread, int timeout = 1000)
        {
            thread.Interrupt();
            thread.Join(timeout);
        }

        /// <summary>
        /// <para>Called when main form loaded.</para>
        /// <para>Focus on <see cref="_buttonStartStop"/>.</para>
        /// </summary>
        /// <param name="sender"><see cref="MainForm"/> instance (this).</param>
        /// <param name="e">Empty event data.</param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            ActiveControl = _buttonStartStop;
        }

        /// <summary>
        /// <para>Called when main form closing.</para>
        /// <para>Ensure to stop <see cref="_thread"/>.</para>
        /// </summary>
        /// <param name="sender"><see cref="MainForm"/> instance (this).</param>
        /// <param name="e">Empty event data.</param>
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            var thread = _thread;
            if (thread != null)
            {
                StopThread(thread);
            }
        }

        /// <summary>
        /// <para>Called when the value of <see cref="_numericUpDownInterval"/> changed.</para>
        /// <para>Copy the value to <see cref="_interval"/>.</para>
        /// </summary>
        /// <param name="sender"><see cref="_numericUpDownInterval"/></param>
        /// <param name="e">Empty event data.</param>
        private void NumericUpDownInterval_ValueChanged(object sender, EventArgs e)
        {
            _interval = (int)((NumericUpDown)sender).Value;
        }

        /// <summary>
        /// <para>Called when the value of <see cref="_buttonStartStop"/> clicked.</para>
        /// <para>Toggle start/stop the thread.</para>
        /// </summary>
        /// <param name="sender"><see cref="_buttonStartStop"/></param>
        /// <param name="e">Empty event data.</param>
        private void ButtonStartStop_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;
            var thread = _thread;
            if (thread == null)
            {
                var host = _textBoxHost.Text;
                var port = (int)_numericUpDownPort.Value;
                var client = new UdpClient(AddressFamily.InterNetwork);
                try
                {
                    client.Connect(host, port);
                    _thread = StartThread(client);
                    button.Text = "Stop";
                    _textBoxHost.Enabled = false;
                    _numericUpDownPort.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        this,
                        ex.Message,
                        ex.ToString(),
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            else
            {
                _thread = null;
                StopThread(thread);
                button.Text = "Start";
                _textBoxHost.Enabled = true;
                _numericUpDownPort.Enabled = true;
            }
        }
    }
}
