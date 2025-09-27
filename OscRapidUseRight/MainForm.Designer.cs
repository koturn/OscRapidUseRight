namespace OscRapidUseRight
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
            System.Windows.Forms.Label labelHost;
            System.Windows.Forms.Label labelPort;
            System.Windows.Forms.Label labelInterval;
            System.Windows.Forms.Label labelHotKey;
            _textBoxHost = new System.Windows.Forms.TextBox();
            _numericUpDownPort = new System.Windows.Forms.NumericUpDown();
            _buttonStartStop = new System.Windows.Forms.Button();
            _numericUpDownInterval = new System.Windows.Forms.NumericUpDown();
            _checkBoxShift = new System.Windows.Forms.CheckBox();
            _checkBoxCtrl = new System.Windows.Forms.CheckBox();
            _checkBoxAlt = new System.Windows.Forms.CheckBox();
            _comboBoxHotKey = new System.Windows.Forms.ComboBox();
            _checkBoxTopMost = new System.Windows.Forms.CheckBox();
            tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            labelHost = new System.Windows.Forms.Label();
            labelPort = new System.Windows.Forms.Label();
            labelInterval = new System.Windows.Forms.Label();
            labelHotKey = new System.Windows.Forms.Label();
            tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)_numericUpDownPort).BeginInit();
            ((System.ComponentModel.ISupportInitialize)_numericUpDownInterval).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            tableLayoutPanel.AutoSize = true;
            tableLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            tableLayoutPanel.ColumnCount = 5;
            tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel.Controls.Add(labelHost, 0, 0);
            tableLayoutPanel.Controls.Add(labelPort, 0, 1);
            tableLayoutPanel.Controls.Add(_textBoxHost, 1, 0);
            tableLayoutPanel.Controls.Add(_numericUpDownPort, 1, 1);
            tableLayoutPanel.Controls.Add(_buttonStartStop, 1, 4);
            tableLayoutPanel.Controls.Add(labelInterval, 0, 2);
            tableLayoutPanel.Controls.Add(_numericUpDownInterval, 1, 2);
            tableLayoutPanel.Controls.Add(labelHotKey, 0, 3);
            tableLayoutPanel.Controls.Add(_checkBoxShift, 1, 3);
            tableLayoutPanel.Controls.Add(_checkBoxCtrl, 2, 3);
            tableLayoutPanel.Controls.Add(_checkBoxAlt, 3, 3);
            tableLayoutPanel.Controls.Add(_comboBoxHotKey, 4, 3);
            tableLayoutPanel.Controls.Add(_checkBoxTopMost, 0, 4);
            tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            tableLayoutPanel.Margin = new System.Windows.Forms.Padding(4);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.RowCount = 4;
            tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel.Size = new System.Drawing.Size(290, 197);
            tableLayoutPanel.TabIndex = 0;
            // 
            // labelHost
            // 
            labelHost.AutoSize = true;
            labelHost.Dock = System.Windows.Forms.DockStyle.Fill;
            labelHost.Location = new System.Drawing.Point(4, 0);
            labelHost.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelHost.Name = "labelHost";
            labelHost.Size = new System.Drawing.Size(75, 31);
            labelHost.TabIndex = 1;
            labelHost.Text = "Host:";
            labelHost.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelPort
            // 
            labelPort.AutoSize = true;
            labelPort.Dock = System.Windows.Forms.DockStyle.Fill;
            labelPort.Location = new System.Drawing.Point(4, 31);
            labelPort.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelPort.Name = "labelPort";
            labelPort.Size = new System.Drawing.Size(75, 31);
            labelPort.TabIndex = 3;
            labelPort.Text = "Port:";
            labelPort.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _textBoxHost
            // 
            tableLayoutPanel.SetColumnSpan(_textBoxHost, 4);
            _textBoxHost.Dock = System.Windows.Forms.DockStyle.Fill;
            _textBoxHost.Location = new System.Drawing.Point(87, 4);
            _textBoxHost.Margin = new System.Windows.Forms.Padding(4);
            _textBoxHost.Name = "_textBoxHost";
            _textBoxHost.Size = new System.Drawing.Size(199, 23);
            _textBoxHost.TabIndex = 2;
            _textBoxHost.Text = "127.0.0.1";
            // 
            // _numericUpDownPort
            // 
            tableLayoutPanel.SetColumnSpan(_numericUpDownPort, 4);
            _numericUpDownPort.Dock = System.Windows.Forms.DockStyle.Fill;
            _numericUpDownPort.Location = new System.Drawing.Point(87, 35);
            _numericUpDownPort.Margin = new System.Windows.Forms.Padding(4);
            _numericUpDownPort.Maximum = new decimal(new int[] { 65535, 0, 0, 0 });
            _numericUpDownPort.Name = "_numericUpDownPort";
            _numericUpDownPort.Size = new System.Drawing.Size(199, 23);
            _numericUpDownPort.TabIndex = 4;
            _numericUpDownPort.Value = new decimal(new int[] { 9000, 0, 0, 0 });
            // 
            // _buttonStartStop
            // 
            tableLayoutPanel.SetColumnSpan(_buttonStartStop, 5);
            _buttonStartStop.Dock = System.Windows.Forms.DockStyle.Fill;
            _buttonStartStop.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 128);
            _buttonStartStop.Location = new System.Drawing.Point(4, 154);
            _buttonStartStop.Margin = new System.Windows.Forms.Padding(4);
            _buttonStartStop.Name = "_buttonStartStop";
            _buttonStartStop.Size = new System.Drawing.Size(282, 39);
            _buttonStartStop.TabIndex = 7;
            _buttonStartStop.Text = "Start";
            _buttonStartStop.UseVisualStyleBackColor = true;
            _buttonStartStop.Click += ButtonStartStop_Click;
            // 
            // labelInterval
            // 
            labelInterval.AutoSize = true;
            labelInterval.Dock = System.Windows.Forms.DockStyle.Fill;
            labelInterval.Location = new System.Drawing.Point(4, 62);
            labelInterval.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelInterval.Name = "labelInterval";
            labelInterval.Size = new System.Drawing.Size(75, 31);
            labelInterval.TabIndex = 5;
            labelInterval.Text = "Interval (ms):";
            labelInterval.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _numericUpDownInterval
            // 
            tableLayoutPanel.SetColumnSpan(_numericUpDownInterval, 4);
            _numericUpDownInterval.Dock = System.Windows.Forms.DockStyle.Fill;
            _numericUpDownInterval.Location = new System.Drawing.Point(87, 66);
            _numericUpDownInterval.Margin = new System.Windows.Forms.Padding(4);
            _numericUpDownInterval.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            _numericUpDownInterval.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            _numericUpDownInterval.Name = "_numericUpDownInterval";
            _numericUpDownInterval.Size = new System.Drawing.Size(199, 23);
            _numericUpDownInterval.TabIndex = 6;
            _numericUpDownInterval.Value = new decimal(new int[] { 16, 0, 0, 0 });
            _numericUpDownInterval.ValueChanged += NumericUpDownInterval_ValueChanged;
            // 
            // labelHotKey
            // 
            labelHotKey.AutoSize = true;
            labelHotKey.Dock = System.Windows.Forms.DockStyle.Fill;
            labelHotKey.Location = new System.Drawing.Point(3, 93);
            labelHotKey.Name = "labelHotKey";
            labelHotKey.Size = new System.Drawing.Size(77, 29);
            labelHotKey.TabIndex = 8;
            labelHotKey.Text = "Hot Key:";
            labelHotKey.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _checkBoxShift
            // 
            _checkBoxShift.AutoSize = true;
            _checkBoxShift.Dock = System.Windows.Forms.DockStyle.Fill;
            _checkBoxShift.Location = new System.Drawing.Point(86, 99);
            _checkBoxShift.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            _checkBoxShift.Name = "_checkBoxShift";
            _checkBoxShift.Size = new System.Drawing.Size(50, 20);
            _checkBoxShift.TabIndex = 9;
            _checkBoxShift.Text = "Shift";
            _checkBoxShift.UseVisualStyleBackColor = true;
            _checkBoxShift.CheckedChanged += CheckBoxModifierKey_CheckedChanged;
            // 
            // _checkBoxCtrl
            // 
            _checkBoxCtrl.AutoSize = true;
            _checkBoxCtrl.Dock = System.Windows.Forms.DockStyle.Fill;
            _checkBoxCtrl.Location = new System.Drawing.Point(142, 99);
            _checkBoxCtrl.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            _checkBoxCtrl.Name = "_checkBoxCtrl";
            _checkBoxCtrl.Size = new System.Drawing.Size(44, 20);
            _checkBoxCtrl.TabIndex = 10;
            _checkBoxCtrl.Text = "Ctrl";
            _checkBoxCtrl.UseVisualStyleBackColor = true;
            _checkBoxCtrl.CheckedChanged += CheckBoxModifierKey_CheckedChanged;
            // 
            // _checkBoxAlt
            // 
            _checkBoxAlt.AutoSize = true;
            _checkBoxAlt.Dock = System.Windows.Forms.DockStyle.Fill;
            _checkBoxAlt.Location = new System.Drawing.Point(192, 99);
            _checkBoxAlt.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            _checkBoxAlt.Name = "_checkBoxAlt";
            _checkBoxAlt.Size = new System.Drawing.Size(41, 20);
            _checkBoxAlt.TabIndex = 11;
            _checkBoxAlt.Text = "Alt";
            _checkBoxAlt.UseVisualStyleBackColor = true;
            _checkBoxAlt.CheckedChanged += CheckBoxModifierKey_CheckedChanged;
            // 
            // _comboBoxHotKey
            // 
            _comboBoxHotKey.Dock = System.Windows.Forms.DockStyle.Fill;
            _comboBoxHotKey.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            _comboBoxHotKey.FormattingEnabled = true;
            _comboBoxHotKey.Items.AddRange(new object[] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "F0", "F1", "F2", "F3", "F4", "F5", "F6", "F7", "F8", "F9", "F10", "F11", "F12" });
            _comboBoxHotKey.Location = new System.Drawing.Point(239, 96);
            _comboBoxHotKey.Name = "_comboBoxHotKey";
            _comboBoxHotKey.Size = new System.Drawing.Size(48, 23);
            _comboBoxHotKey.TabIndex = 12;
            _comboBoxHotKey.SelectedIndexChanged += ComboBoxHotKey_SelectedIndexChanged;
            // 
            // _checkBoxTopMost
            // 
            _checkBoxTopMost.AutoSize = true;
            _checkBoxTopMost.Checked = true;
            _checkBoxTopMost.CheckState = System.Windows.Forms.CheckState.Checked;
            tableLayoutPanel.SetColumnSpan(_checkBoxTopMost, 5);
            _checkBoxTopMost.Dock = System.Windows.Forms.DockStyle.Fill;
            _checkBoxTopMost.Location = new System.Drawing.Point(6, 128);
            _checkBoxTopMost.Margin = new System.Windows.Forms.Padding(6, 6, 3, 3);
            _checkBoxTopMost.Name = "_checkBoxTopMost";
            _checkBoxTopMost.Size = new System.Drawing.Size(281, 19);
            _checkBoxTopMost.TabIndex = 13;
            _checkBoxTopMost.Text = "Display on top when toggled";
            _checkBoxTopMost.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new System.Drawing.Size(290, 197);
            Controls.Add(tableLayoutPanel);
            Margin = new System.Windows.Forms.Padding(4);
            Name = "MainForm";
            Text = "OSC Rapid UseRight";
            FormClosing += MainForm_FormClosing;
            FormClosed += MainForm_FormClosed;
            Load += MainForm_Load;
            tableLayoutPanel.ResumeLayout(false);
            tableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)_numericUpDownPort).EndInit();
            ((System.ComponentModel.ISupportInitialize)_numericUpDownInterval).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.TextBox _textBoxHost;
        private System.Windows.Forms.NumericUpDown _numericUpDownPort;
        private System.Windows.Forms.Button _buttonStartStop;
        private System.Windows.Forms.NumericUpDown _numericUpDownInterval;
        private System.Windows.Forms.CheckBox _checkBoxShift;
        private System.Windows.Forms.CheckBox _checkBoxCtrl;
        private System.Windows.Forms.CheckBox _checkBoxAlt;
        private System.Windows.Forms.ComboBox _comboBoxHotKey;
        private System.Windows.Forms.CheckBox _checkBoxTopMost;
    }
}

