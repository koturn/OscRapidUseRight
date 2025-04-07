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
            this._tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this._labelHost = new System.Windows.Forms.Label();
            this._labelPort = new System.Windows.Forms.Label();
            this._textBoxHost = new System.Windows.Forms.TextBox();
            this._numericUpDownPort = new System.Windows.Forms.NumericUpDown();
            this._buttonStartStop = new System.Windows.Forms.Button();
            this._labelInterval = new System.Windows.Forms.Label();
            this._numericUpDownInterval = new System.Windows.Forms.NumericUpDown();
            this._tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._numericUpDownPort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._numericUpDownInterval)).BeginInit();
            this.SuspendLayout();
            // 
            // _tableLayoutPanel
            // 
            this._tableLayoutPanel.AutoSize = true;
            this._tableLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this._tableLayoutPanel.ColumnCount = 2;
            this._tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this._tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._tableLayoutPanel.Controls.Add(this._labelHost, 0, 0);
            this._tableLayoutPanel.Controls.Add(this._labelPort, 0, 1);
            this._tableLayoutPanel.Controls.Add(this._textBoxHost, 1, 0);
            this._tableLayoutPanel.Controls.Add(this._numericUpDownPort, 1, 1);
            this._tableLayoutPanel.Controls.Add(this._buttonStartStop, 1, 3);
            this._tableLayoutPanel.Controls.Add(this._labelInterval, 0, 3);
            this._tableLayoutPanel.Controls.Add(this._numericUpDownInterval, 1, 3);
            this._tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this._tableLayoutPanel.Name = "_tableLayoutPanel";
            this._tableLayoutPanel.RowCount = 3;
            this._tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this._tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this._tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this._tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this._tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this._tableLayoutPanel.Size = new System.Drawing.Size(304, 121);
            this._tableLayoutPanel.TabIndex = 0;
            // 
            // _labelHost
            // 
            this._labelHost.AutoSize = true;
            this._labelHost.Dock = System.Windows.Forms.DockStyle.Fill;
            this._labelHost.Location = new System.Drawing.Point(3, 0);
            this._labelHost.Name = "_labelHost";
            this._labelHost.Size = new System.Drawing.Size(72, 25);
            this._labelHost.TabIndex = 1;
            this._labelHost.Text = "Host:";
            this._labelHost.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _labelPort
            // 
            this._labelPort.AutoSize = true;
            this._labelPort.Dock = System.Windows.Forms.DockStyle.Fill;
            this._labelPort.Location = new System.Drawing.Point(3, 25);
            this._labelPort.Name = "_labelPort";
            this._labelPort.Size = new System.Drawing.Size(72, 25);
            this._labelPort.TabIndex = 3;
            this._labelPort.Text = "Port:";
            this._labelPort.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _textBoxHost
            // 
            this._textBoxHost.Dock = System.Windows.Forms.DockStyle.Fill;
            this._textBoxHost.Location = new System.Drawing.Point(81, 3);
            this._textBoxHost.Name = "_textBoxHost";
            this._textBoxHost.Size = new System.Drawing.Size(220, 19);
            this._textBoxHost.TabIndex = 2;
            this._textBoxHost.Text = "127.0.0.1";
            // 
            // _numericUpDownPort
            // 
            this._numericUpDownPort.Dock = System.Windows.Forms.DockStyle.Fill;
            this._numericUpDownPort.Location = new System.Drawing.Point(81, 28);
            this._numericUpDownPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this._numericUpDownPort.Name = "_numericUpDownPort";
            this._numericUpDownPort.Size = new System.Drawing.Size(220, 19);
            this._numericUpDownPort.TabIndex = 4;
            this._numericUpDownPort.Value = new decimal(new int[] {
            9000,
            0,
            0,
            0});
            // 
            // _buttonStartStop
            // 
            this._tableLayoutPanel.SetColumnSpan(this._buttonStartStop, 2);
            this._buttonStartStop.Dock = System.Windows.Forms.DockStyle.Fill;
            this._buttonStartStop.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this._buttonStartStop.Location = new System.Drawing.Point(3, 78);
            this._buttonStartStop.Name = "_buttonStartStop";
            this._buttonStartStop.Size = new System.Drawing.Size(298, 40);
            this._buttonStartStop.TabIndex = 7;
            this._buttonStartStop.Text = "Start";
            this._buttonStartStop.UseVisualStyleBackColor = true;
            this._buttonStartStop.Click += new System.EventHandler(this.ButtonStartStop_Click);
            // 
            // _labelInterval
            // 
            this._labelInterval.AutoSize = true;
            this._labelInterval.Dock = System.Windows.Forms.DockStyle.Fill;
            this._labelInterval.Location = new System.Drawing.Point(3, 50);
            this._labelInterval.Name = "_labelInterval";
            this._labelInterval.Size = new System.Drawing.Size(72, 25);
            this._labelInterval.TabIndex = 5;
            this._labelInterval.Text = "Interval (ms):";
            this._labelInterval.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _numericUpDownInterval
            // 
            this._numericUpDownInterval.Dock = System.Windows.Forms.DockStyle.Fill;
            this._numericUpDownInterval.Location = new System.Drawing.Point(81, 53);
            this._numericUpDownInterval.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this._numericUpDownInterval.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this._numericUpDownInterval.Name = "_numericUpDownInterval";
            this._numericUpDownInterval.Size = new System.Drawing.Size(220, 19);
            this._numericUpDownInterval.TabIndex = 6;
            this._numericUpDownInterval.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this._numericUpDownInterval.ValueChanged += new System.EventHandler(this.NumericUpDownInterval_ValueChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(304, 121);
            this.Controls.Add(this._tableLayoutPanel);
            this.Name = "MainForm";
            this.Text = "OSC Rapid UseRight";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this._tableLayoutPanel.ResumeLayout(false);
            this._tableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._numericUpDownPort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._numericUpDownInterval)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel _tableLayoutPanel;
        private System.Windows.Forms.Label _labelHost;
        private System.Windows.Forms.Label _labelPort;
        private System.Windows.Forms.TextBox _textBoxHost;
        private System.Windows.Forms.NumericUpDown _numericUpDownPort;
        private System.Windows.Forms.Button _buttonStartStop;
        private System.Windows.Forms.Label _labelInterval;
        private System.Windows.Forms.NumericUpDown _numericUpDownInterval;
    }
}

