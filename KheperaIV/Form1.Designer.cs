namespace KheperaIV
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.IPAddressBox = new System.Windows.Forms.MaskedTextBox();
            this.IPAddressLabel = new System.Windows.Forms.Label();
            this.connectButton = new System.Windows.Forms.Button();
            this.controlsPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.axVLCPlugin21 = new AxAXVLC.AxVLCPlugin2();
            this.speedValueTextBox = new System.Windows.Forms.TextBox();
            this.speedBar = new System.Windows.Forms.TrackBar();
            this.controlButtonRight = new System.Windows.Forms.Button();
            this.controlButtonLeft = new System.Windows.Forms.Button();
            this.controlButtonDown = new System.Windows.Forms.Button();
            this.controlButtonUp = new System.Windows.Forms.Button();
            this.portBox = new System.Windows.Forms.MaskedTextBox();
            this.portLabel = new System.Windows.Forms.Label();
            this.messageLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pathDrvBtn = new System.Windows.Forms.Button();
            this.transparentPanel1 = new KheperaIV.TransparentPanel();
            this.controlsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axVLCPlugin21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.speedBar)).BeginInit();
            this.SuspendLayout();
            // 
            // IPAddressBox
            // 
            this.IPAddressBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.IPAddressBox.Location = new System.Drawing.Point(12, 32);
            this.IPAddressBox.Mask = "000.990.990.990";
            this.IPAddressBox.Name = "IPAddressBox";
            this.IPAddressBox.Size = new System.Drawing.Size(100, 22);
            this.IPAddressBox.TabIndex = 1;
            this.IPAddressBox.Text = "192168001022";
            this.IPAddressBox.Click += new System.EventHandler(this.IPAddressBox_Click);
            this.IPAddressBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.IPAddressBox_KeyDown);
            // 
            // IPAddressLabel
            // 
            this.IPAddressLabel.AutoSize = true;
            this.IPAddressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.IPAddressLabel.Location = new System.Drawing.Point(13, 13);
            this.IPAddressLabel.Name = "IPAddressLabel";
            this.IPAddressLabel.Size = new System.Drawing.Size(96, 16);
            this.IPAddressLabel.TabIndex = 2;
            this.IPAddressLabel.Text = "KIV IP address";
            // 
            // connectButton
            // 
            this.connectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.connectButton.Location = new System.Drawing.Point(170, 32);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(93, 23);
            this.connectButton.TabIndex = 3;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // controlsPanel
            // 
            this.controlsPanel.Controls.Add(this.transparentPanel1);
            this.controlsPanel.Controls.Add(this.label1);
            this.controlsPanel.Controls.Add(this.axVLCPlugin21);
            this.controlsPanel.Controls.Add(this.speedValueTextBox);
            this.controlsPanel.Controls.Add(this.speedBar);
            this.controlsPanel.Controls.Add(this.controlButtonRight);
            this.controlsPanel.Controls.Add(this.controlButtonLeft);
            this.controlsPanel.Controls.Add(this.controlButtonDown);
            this.controlsPanel.Controls.Add(this.controlButtonUp);
            this.controlsPanel.Location = new System.Drawing.Point(12, 74);
            this.controlsPanel.Name = "controlsPanel";
            this.controlsPanel.Size = new System.Drawing.Size(608, 286);
            this.controlsPanel.TabIndex = 4;
            this.controlsPanel.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(27, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Speed: ";
            // 
            // axVLCPlugin21
            // 
            this.axVLCPlugin21.Enabled = true;
            this.axVLCPlugin21.Location = new System.Drawing.Point(283, 14);
            this.axVLCPlugin21.Name = "axVLCPlugin21";
            this.axVLCPlugin21.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axVLCPlugin21.OcxState")));
            this.axVLCPlugin21.Size = new System.Drawing.Size(320, 240);
            this.axVLCPlugin21.TabIndex = 9;
            // 
            // speedValueTextBox
            // 
            this.speedValueTextBox.Location = new System.Drawing.Point(88, 212);
            this.speedValueTextBox.Name = "speedValueTextBox";
            this.speedValueTextBox.ReadOnly = true;
            this.speedValueTextBox.Size = new System.Drawing.Size(100, 20);
            this.speedValueTextBox.TabIndex = 7;
            this.speedValueTextBox.TabStop = false;
            // 
            // speedBar
            // 
            this.speedBar.LargeChange = 50;
            this.speedBar.Location = new System.Drawing.Point(32, 238);
            this.speedBar.Maximum = 1500;
            this.speedBar.Minimum = 15;
            this.speedBar.Name = "speedBar";
            this.speedBar.Size = new System.Drawing.Size(156, 45);
            this.speedBar.SmallChange = 10;
            this.speedBar.TabIndex = 6;
            this.speedBar.TickFrequency = 50;
            this.speedBar.Value = 200;
            this.speedBar.ValueChanged += new System.EventHandler(this.speedBar_ValueChanged);
            // 
            // controlButtonRight
            // 
            this.controlButtonRight.Font = new System.Drawing.Font("Source Code Pro", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.controlButtonRight.Location = new System.Drawing.Point(138, 70);
            this.controlButtonRight.Name = "controlButtonRight";
            this.controlButtonRight.Size = new System.Drawing.Size(50, 50);
            this.controlButtonRight.TabIndex = 3;
            this.controlButtonRight.TabStop = false;
            this.controlButtonRight.Text = "►";
            this.controlButtonRight.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.controlButtonRight.UseVisualStyleBackColor = true;
            this.controlButtonRight.Click += new System.EventHandler(this.controlButtonRight_Click);
            // 
            // controlButtonLeft
            // 
            this.controlButtonLeft.Font = new System.Drawing.Font("Source Code Pro", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.controlButtonLeft.Location = new System.Drawing.Point(32, 70);
            this.controlButtonLeft.Name = "controlButtonLeft";
            this.controlButtonLeft.Size = new System.Drawing.Size(50, 50);
            this.controlButtonLeft.TabIndex = 2;
            this.controlButtonLeft.TabStop = false;
            this.controlButtonLeft.Text = "◄";
            this.controlButtonLeft.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.controlButtonLeft.UseVisualStyleBackColor = true;
            this.controlButtonLeft.Click += new System.EventHandler(this.controlButtonLeft_Click);
            // 
            // controlButtonDown
            // 
            this.controlButtonDown.Font = new System.Drawing.Font("Source Code Pro", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.controlButtonDown.Location = new System.Drawing.Point(85, 126);
            this.controlButtonDown.Name = "controlButtonDown";
            this.controlButtonDown.Size = new System.Drawing.Size(50, 50);
            this.controlButtonDown.TabIndex = 1;
            this.controlButtonDown.TabStop = false;
            this.controlButtonDown.Text = "▼";
            this.controlButtonDown.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.controlButtonDown.UseVisualStyleBackColor = true;
            this.controlButtonDown.Click += new System.EventHandler(this.controlButtonDown_Click);
            // 
            // controlButtonUp
            // 
            this.controlButtonUp.Font = new System.Drawing.Font("Source Code Pro", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.controlButtonUp.Location = new System.Drawing.Point(85, 14);
            this.controlButtonUp.Name = "controlButtonUp";
            this.controlButtonUp.Size = new System.Drawing.Size(50, 50);
            this.controlButtonUp.TabIndex = 0;
            this.controlButtonUp.TabStop = false;
            this.controlButtonUp.Text = "▲";
            this.controlButtonUp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.controlButtonUp.UseVisualStyleBackColor = true;
            this.controlButtonUp.Click += new System.EventHandler(this.controlButtonUp_Click);
            this.controlButtonUp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.controlButtonUp_MouseDown);
            // 
            // portBox
            // 
            this.portBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.portBox.Location = new System.Drawing.Point(118, 32);
            this.portBox.Mask = "99990";
            this.portBox.Name = "portBox";
            this.portBox.Size = new System.Drawing.Size(46, 22);
            this.portBox.TabIndex = 5;
            this.portBox.Text = "8888";
            this.portBox.Click += new System.EventHandler(this.portBox_Click);
            this.portBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.portBox_KeyDown);
            // 
            // portLabel
            // 
            this.portLabel.AutoSize = true;
            this.portLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.portLabel.Location = new System.Drawing.Point(115, 13);
            this.portLabel.Name = "portLabel";
            this.portLabel.Size = new System.Drawing.Size(32, 16);
            this.portLabel.TabIndex = 6;
            this.portLabel.Text = "Port";
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.Location = new System.Drawing.Point(292, 32);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(0, 13);
            this.messageLabel.TabIndex = 7;
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pathDrvBtn
            // 
            this.pathDrvBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pathDrvBtn.Location = new System.Drawing.Point(527, 32);
            this.pathDrvBtn.Name = "pathDrvBtn";
            this.pathDrvBtn.Size = new System.Drawing.Size(93, 23);
            this.pathDrvBtn.TabIndex = 8;
            this.pathDrvBtn.Text = "Path drive";
            this.pathDrvBtn.UseVisualStyleBackColor = true;
            this.pathDrvBtn.Click += new System.EventHandler(this.pathDrvBtn_Click);
            // 
            // transparentPanel1
            // 
            this.transparentPanel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transparentPanel1.Location = new System.Drawing.Point(242, 76);
            this.transparentPanel1.Name = "transparentPanel1";
            this.transparentPanel1.Size = new System.Drawing.Size(200, 100);
            this.transparentPanel1.TabIndex = 8;
            this.transparentPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.transparentPanel1_Paint);
            this.transparentPanel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.transparentPanel1_MouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 372);
            this.Controls.Add(this.pathDrvBtn);
            this.Controls.Add(this.messageLabel);
            this.Controls.Add(this.portLabel);
            this.Controls.Add(this.portBox);
            this.Controls.Add(this.controlsPanel);
            this.Controls.Add(this.connectButton);
            this.Controls.Add(this.IPAddressLabel);
            this.Controls.Add(this.IPAddressBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Khepera IV";
            this.controlsPanel.ResumeLayout(false);
            this.controlsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axVLCPlugin21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.speedBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        

        #endregion

        private System.Windows.Forms.MaskedTextBox IPAddressBox;
        private System.Windows.Forms.Label IPAddressLabel;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.Panel controlsPanel;
        private System.Windows.Forms.Button controlButtonUp;
        private System.Windows.Forms.Button controlButtonRight;
        private System.Windows.Forms.Button controlButtonLeft;
        private System.Windows.Forms.Button controlButtonDown;
        private System.Windows.Forms.MaskedTextBox portBox;
        private System.Windows.Forms.Label portLabel;
        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TrackBar speedBar;
        private System.Windows.Forms.TextBox speedValueTextBox;
        private AxAXVLC.AxVLCPlugin2 axVLCPlugin21;
        private System.Windows.Forms.Label label1;
        private TransparentPanel transparentPanel1;
        private System.Windows.Forms.Button pathDrvBtn;
    }
}

