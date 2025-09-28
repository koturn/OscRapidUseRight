using System;
using System.Drawing;
using System.Net.Sockets;
using System.Reflection;

#if !NET6_0_OR_GREATER
using System.Text;
#endif  // !NET6_0_OR_GREATER
using System.Threading;
using System.Windows.Forms;
using OscRapidUseRight.Properties;
using OscRapidUseRight.Win32.GlobalHotKeys;
using Keys = OscRapidUseRight.Win32.GlobalHotKeys.Keys;


namespace OscRapidUseRight
{
    /// <summary>
    /// User code of <see cref="MainForm"/>.
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Global Hot Key manager.
        /// </summary>
        private readonly GlobalHotKeyManager _globalHotKeyManager;
        /// <summary>
        /// Thread alternating 0's and 1's sent to "/input/UseRight".
        /// </summary>
        private Thread? _thread;
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
            _globalHotKeyManager = new GlobalHotKeyManager(Handle);
            _interval = (int)_numericUpDownInterval.Value;
        }

        /// <summary>
        /// Windows message reciever for hot keys.
        /// </summary>
        /// <param name="m">Windows message.</param>
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == GlobalHotKeyManager.MessageId)
            {
                var hotKeyId = (int)m.WParam;
                foreach (var id in _globalHotKeyManager.RegisteredIds)
                {
                    if (hotKeyId == id)
                    {
                        ToggleStartStop(_buttonStartStop);
                        break;
                    }
                }
            }
            base.WndProc(ref m);
        }

        /// <summary>
        /// Update hot key.
        /// </summary>
        private void UpdateHotKey()
        {
            var text = _comboBoxHotKey.SelectedItem as string;
            if (text == null || text.Length == 0)
            {
                return;
            }

            var key = default(Keys);
            if (text.Length == 1 && char.IsDigit(text[0]))
            {
                // Digit key.
#if NETCOREAPP3_0_OR_GREATER
                key = Enum.Parse<Keys>("D" + text[0]);
#else
                key = (Keys)Enum.Parse(typeof(Keys), "D" + text[0]);
#endif  // NETCOREAPP3_0_OR_GREATER
            }
            else
            {
                // Alphabet key or Function key.
#if NETCOREAPP3_0_OR_GREATER
                key = Enum.Parse<Keys>(text);
#else
                key = (Keys)Enum.Parse(typeof(Keys), text);
#endif  // NETCOREAPP3_0_OR_GREATER
            }
            var modKey = GetModifilerKeys();

            try
            {
                _globalHotKeyManager.UnregisterAll();
                _globalHotKeyManager.Register(modKey, key);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, ex.GetType().Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Get modifier key value from <see cref="_checkBoxShift"/>, <see cref="_checkBoxCtrl"/> and <see cref="_checkBoxAlt"/>.
        /// </summary>
        /// <returns>Modifier key value.</returns>
        private ModifierKeys GetModifilerKeys()
        {
            var modKey = Win32.GlobalHotKeys.ModifierKeys.None;
            if (_checkBoxShift.Checked)
            {
                modKey |= Win32.GlobalHotKeys.ModifierKeys.Shift;
            }
            if (_checkBoxCtrl.Checked)
            {
                modKey |= Win32.GlobalHotKeys.ModifierKeys.Control;
            }
            if (_checkBoxAlt.Checked)
            {
                modKey |= Win32.GlobalHotKeys.ModifierKeys.Alt;
            }
            return modKey;
        }

        /// <summary>
        /// Toggle start/stop the thread.
        /// </summary>
        /// <param name="startStopButton"><see cref="_buttonStartStop"/></param>
        private void ToggleStartStop(Button startStopButton)
        {
            if (_checkBoxTopMost.Checked)
            {
                TopMost = true;
                TopMost = false;
            }

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
                    startStopButton.Text = "Stop";
                    _textBoxHost.Enabled = false;
                    _numericUpDownPort.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, ex.Message, ex.GetType().Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                _thread = null;
                StopThread(thread);
                startStopButton.Text = "Start";
                _textBoxHost.Enabled = true;
                _numericUpDownPort.Enabled = true;
            }
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
                var client = (UdpClient)param!;
#if NET6_0_OR_GREATER
                var pressData = "/input/UseRight\x00,i\x00\x00\x00\x00\x00\x01"u8;
                var releaseData = "/input/UseRight\x00,i\x00\x00\x00\x00\x00\x00"u8;
#else
                var pressData = Encoding.ASCII.GetBytes("/input/UseRight\x00,i\x00\x00\x00\x00\x00\x01");
                var releaseData = Encoding.ASCII.GetBytes("/input/UseRight\x00,i\x00\x00\x00\x00\x00\x00");
#endif  // NET6_0_OR_GREATER
                try
                {
                    while (true)
                    {
#if NET6_0_OR_GREATER
                        client.Send(pressData);
                        Thread.Sleep(_interval);
                        client.Send(releaseData);
                        Thread.Sleep(_interval);
#else
                        client.Send(pressData, pressData.Length);
                        Thread.Sleep(_interval);
                        client.Send(releaseData, releaseData.Length);
                        Thread.Sleep(_interval);
#endif  // NET6_0_OR_GREATER
                    }
                }
                catch (ThreadInterruptedException)
                {
                    // Do nothing
                }
                finally
                {
#if NET6_0_OR_GREATER
                    client.Send(releaseData);
#else
                    client.Send(releaseData, releaseData.Length);
#endif  // NET6_0_OR_GREATER
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
        private static void StopThread(Thread thread, int timeout = 1000)
        {
            thread.Interrupt();
            thread.Join(timeout);
        }

        /// <summary>
        /// <para>Called when main form loaded.</para>
        /// <para>Focus on <see cref="_buttonStartStop"/> and load configuration file.</para>
        /// </summary>
        /// <param name="sender"><see cref="MainForm"/> instance (this).</param>
        /// <param name="e">Empty event data.</param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            var mrs = Assembly.GetExecutingAssembly().GetManifestResourceStream("OscRapidUseRight.icon.ico");
            if (mrs != null)
            {
                Icon = new Icon(mrs);
            }
            ActiveControl = _buttonStartStop;
            var prop = Settings.Default;
            _textBoxHost.Text = prop.Host;
            _numericUpDownPort.Value = prop.Port;
            _numericUpDownInterval.Value = prop.Interval;
            var index = _comboBoxHotKey.Items.IndexOf(prop.Key);
            if (index != -1)
            {
                _comboBoxHotKey.SelectedIndex = index;
            }
            _checkBoxShift.Checked = prop.IsShiftChecked;
            _checkBoxCtrl.Checked = prop.IsCtrlChecked;
            _checkBoxAlt.Checked = prop.IsAltChecked;
            _checkBoxTopMost.Checked = prop.TopMostWhenToggled;
        }

        /// <summary>
        /// <para>Called when main form closing.</para>
        /// <para>Ensure to stop <see cref="_thread"/>.</para>
        /// </summary>
        /// <param name="sender"><see cref="MainForm"/> instance (this).</param>
        /// <param name="e">Empty event data.</param>
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _globalHotKeyManager.Dispose();
            var thread = _thread;
            if (thread != null)
            {
                StopThread(thread);
            }
        }

        /// <summary>
        /// <para>Called when main form closed.</para>
        /// <para>Save configuration file.</para>
        /// </summary>
        /// <param name="sender"><see cref="MainForm"/> instance (this).</param>
        /// <param name="e">Empty event data.</param>
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            var prop = Settings.Default;
            prop.Host = _textBoxHost.Text;
            prop.Port = (ushort)_numericUpDownPort.Value;
            prop.Interval = (int)_numericUpDownInterval.Value;
            prop.Key = _comboBoxHotKey.SelectedItem as string;
            prop.IsShiftChecked = _checkBoxShift.Checked;
            prop.IsCtrlChecked = _checkBoxCtrl.Checked;
            prop.IsAltChecked = _checkBoxAlt.Checked;
            prop.TopMostWhenToggled = _checkBoxTopMost.Checked;
            prop.Save();
        }

        /// <summary>
        /// <para>Called when the value of <see cref="NumericUpDown"/> of interval is changed.</para>
        /// <para>Copy the value to <see cref="_interval"/>.</para>
        /// </summary>
        /// <param name="sender"><see cref="NumericUpDown"/> of interval.</param>
        /// <param name="e">Empty event data.</param>
        private void NumericUpDownInterval_ValueChanged(object sender, EventArgs e)
        {
            _interval = (int)((NumericUpDown)sender).Value;
        }

        /// <summary>
        /// <para>Called when the check state of <see cref="_checkBoxShift"/>, <see cref="_checkBoxCtrl"/>
        /// or <see cref="_checkBoxAlt"/> is changed.</para>
        /// <para>Re-register hot key.</para>
        /// </summary>
        /// <param name="sender"><see cref="_checkBoxShift"/>, <see cref="_checkBoxCtrl"/> or <see cref="_checkBoxAlt"/>.</param>
        /// <param name="e">Empty event data.</param>
        private void CheckBoxModifierKey_CheckedChanged(object sender, EventArgs e)
        {
            UpdateHotKey();
        }

        /// <summary>
        /// <para>Called when the selected index of <see cref="ComboBox"/> of hot keys is changed.</para>
        /// <para>Re-register hot key.</para>
        /// </summary>
        /// <param name="sender"><see cref="ComboBox"/> of hot keys.</param>
        /// <param name="e">Empty event data.</param>
        private void ComboBoxHotKey_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateHotKey();
        }

        /// <summary>
        /// <para>Called when the value of <see cref="_buttonStartStop"/> clicked.</para>
        /// <para>Toggle start/stop the thread.</para>
        /// </summary>
        /// <param name="sender"><see cref="_buttonStartStop"/></param>
        /// <param name="e">Empty event data.</param>
        private void ButtonStartStop_Click(object sender, EventArgs e)
        {
            ToggleStartStop((Button)sender);
        }
    }
}
