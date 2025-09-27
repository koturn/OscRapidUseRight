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
            _textBoxHost = new System.Windows.Forms.TextBox();
            _numericUpDownPort = new System.Windows.Forms.NumericUpDown();
            _buttonStartStop = new System.Windows.Forms.Button();
            _numericUpDownInterval = new System.Windows.Forms.NumericUpDown();
            tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            labelHost = new System.Windows.Forms.Label();
            labelPort = new System.Windows.Forms.Label();
            labelInterval = new System.Windows.Forms.Label();
            tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)_numericUpDownPort).BeginInit();
            ((System.ComponentModel.ISupportInitialize)_numericUpDownInterval).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            tableLayoutPanel.AutoSize = true;
            tableLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            tableLayoutPanel.ColumnCount = 2;
            tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel.Controls.Add(labelHost, 0, 0);
            tableLayoutPanel.Controls.Add(labelPort, 0, 1);
            tableLayoutPanel.Controls.Add(_textBoxHost, 1, 0);
            tableLayoutPanel.Controls.Add(_numericUpDownPort, 1, 1);
            tableLayoutPanel.Controls.Add(_buttonStartStop, 1, 3);
            tableLayoutPanel.Controls.Add(labelInterval, 0, 3);
            tableLayoutPanel.Controls.Add(_numericUpDownInterval, 1, 3);
            tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            tableLayoutPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.RowCount = 3;
            tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            tableLayoutPanel.Size = new System.Drawing.Size(355, 151);
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
            _textBoxHost.Dock = System.Windows.Forms.DockStyle.Fill;
            _textBoxHost.Location = new System.Drawing.Point(87, 4);
            _textBoxHost.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            _textBoxHost.Name = "_textBoxHost";
            _textBoxHost.Size = new System.Drawing.Size(264, 23);
            _textBoxHost.TabIndex = 2;
            _textBoxHost.Text = "127.0.0.1";
            // 
            // _numericUpDownPort
            // 
            _numericUpDownPort.Dock = System.Windows.Forms.DockStyle.Fill;
            _numericUpDownPort.Location = new System.Drawing.Point(87, 35);
            _numericUpDownPort.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            _numericUpDownPort.Maximum = new decimal(new int[] { 65535, 0, 0, 0 });
            _numericUpDownPort.Name = "_numericUpDownPort";
            _numericUpDownPort.Size = new System.Drawing.Size(264, 23);
            _numericUpDownPort.TabIndex = 4;
            _numericUpDownPort.Value = new decimal(new int[] { 9000, 0, 0, 0 });
            // 
            // _buttonStartStop
            // 
            tableLayoutPanel.SetColumnSpan(_buttonStartStop, 2);
            _buttonStartStop.Dock = System.Windows.Forms.DockStyle.Fill;
            _buttonStartStop.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 128);
            _buttonStartStop.Location = new System.Drawing.Point(4, 97);
            _buttonStartStop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            _buttonStartStop.Name = "_buttonStartStop";
            _buttonStartStop.Size = new System.Drawing.Size(347, 50);
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
            _numericUpDownInterval.Dock = System.Windows.Forms.DockStyle.Fill;
            _numericUpDownInterval.Location = new System.Drawing.Point(87, 66);
            _numericUpDownInterval.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            _numericUpDownInterval.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            _numericUpDownInterval.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            _numericUpDownInterval.Name = "_numericUpDownInterval";
            _numericUpDownInterval.Size = new System.Drawing.Size(264, 23);
            _numericUpDownInterval.TabIndex = 6;
            _numericUpDownInterval.Value = new decimal(new int[] { 16, 0, 0, 0 });
            _numericUpDownInterval.ValueChanged += NumericUpDownInterval_ValueChanged;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new System.Drawing.Size(355, 151);
            Controls.Add(tableLayoutPanel);
            Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            Name = "MainForm";
            Text = "OSC Rapid UseRight";
            FormClosing += MainForm_FormClosing;
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
    }
}

