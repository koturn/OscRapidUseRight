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
            System.Windows.Forms.NumericUpDown numericUpDownInterval;
            this._textBoxHost = new System.Windows.Forms.TextBox();
            this._numericUpDownPort = new System.Windows.Forms.NumericUpDown();
            this._buttonStartStop = new System.Windows.Forms.Button();
            tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            labelHost = new System.Windows.Forms.Label();
            labelPort = new System.Windows.Forms.Label();
            labelInterval = new System.Windows.Forms.Label();
            numericUpDownInterval = new System.Windows.Forms.NumericUpDown();
            tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._numericUpDownPort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(numericUpDownInterval)).BeginInit();
            this.SuspendLayout();
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
            tableLayoutPanel.Controls.Add(this._textBoxHost, 1, 0);
            tableLayoutPanel.Controls.Add(this._numericUpDownPort, 1, 1);
            tableLayoutPanel.Controls.Add(this._buttonStartStop, 1, 3);
            tableLayoutPanel.Controls.Add(labelInterval, 0, 3);
            tableLayoutPanel.Controls.Add(numericUpDownInterval, 1, 3);
            tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.RowCount = 3;
            tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            tableLayoutPanel.Size = new System.Drawing.Size(304, 121);
            tableLayoutPanel.TabIndex = 0;
            // 
            // labelHost
            // 
            labelHost.AutoSize = true;
            labelHost.Dock = System.Windows.Forms.DockStyle.Fill;
            labelHost.Location = new System.Drawing.Point(3, 0);
            labelHost.Name = "labelHost";
            labelHost.Size = new System.Drawing.Size(72, 25);
            labelHost.TabIndex = 1;
            labelHost.Text = "Host:";
            labelHost.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelPort
            // 
            labelPort.AutoSize = true;
            labelPort.Dock = System.Windows.Forms.DockStyle.Fill;
            labelPort.Location = new System.Drawing.Point(3, 25);
            labelPort.Name = "labelPort";
            labelPort.Size = new System.Drawing.Size(72, 25);
            labelPort.TabIndex = 3;
            labelPort.Text = "Port:";
            labelPort.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            tableLayoutPanel.SetColumnSpan(this._buttonStartStop, 2);
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
            // labelInterval
            // 
            labelInterval.AutoSize = true;
            labelInterval.Dock = System.Windows.Forms.DockStyle.Fill;
            labelInterval.Location = new System.Drawing.Point(3, 50);
            labelInterval.Name = "labelInterval";
            labelInterval.Size = new System.Drawing.Size(72, 25);
            labelInterval.TabIndex = 5;
            labelInterval.Text = "Interval (ms):";
            labelInterval.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numericUpDownInterval
            // 
            numericUpDownInterval.Dock = System.Windows.Forms.DockStyle.Fill;
            numericUpDownInterval.Location = new System.Drawing.Point(81, 53);
            numericUpDownInterval.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            numericUpDownInterval.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            numericUpDownInterval.Name = "numericUpDownInterval";
            numericUpDownInterval.Size = new System.Drawing.Size(220, 19);
            numericUpDownInterval.TabIndex = 6;
            numericUpDownInterval.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            numericUpDownInterval.ValueChanged += new System.EventHandler(this.NumericUpDownInterval_ValueChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(304, 121);
            this.Controls.Add(tableLayoutPanel);
            this.Name = "MainForm";
            this.Text = "OSC Rapid UseRight";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            tableLayoutPanel.ResumeLayout(false);
            tableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._numericUpDownPort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(numericUpDownInterval)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox _textBoxHost;
        private System.Windows.Forms.NumericUpDown _numericUpDownPort;
        private System.Windows.Forms.Button _buttonStartStop;
    }
}

