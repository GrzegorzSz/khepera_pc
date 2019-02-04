namespace KheperaIV
{
    partial class PathDriveForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PathDriveForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.triactDrvTextBox = new System.Windows.Forms.TextBox();
            this.squareDrvTextBox = new System.Windows.Forms.TextBox();
            this.roundDrvTextBox = new System.Windows.Forms.TextBox();
            this.triactDrvRadioBtn = new System.Windows.Forms.RadioButton();
            this.squareDrvRadioBtn = new System.Windows.Forms.RadioButton();
            this.roundDrvRadioBtn = new System.Windows.Forms.RadioButton();
            this.goButton = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.triactDrvTextBox);
            this.panel1.Controls.Add(this.squareDrvTextBox);
            this.panel1.Controls.Add(this.roundDrvTextBox);
            this.panel1.Controls.Add(this.triactDrvRadioBtn);
            this.panel1.Controls.Add(this.squareDrvRadioBtn);
            this.panel1.Controls.Add(this.roundDrvRadioBtn);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(629, 242);
            this.panel1.TabIndex = 0;
            // 
            // triactDrvTextBox
            // 
            this.triactDrvTextBox.Location = new System.Drawing.Point(478, 176);
            this.triactDrvTextBox.Name = "triactDrvTextBox";
            this.triactDrvTextBox.Size = new System.Drawing.Size(100, 20);
            this.triactDrvTextBox.TabIndex = 5;
            // 
            // squareDrvTextBox
            // 
            this.squareDrvTextBox.Location = new System.Drawing.Point(257, 176);
            this.squareDrvTextBox.Name = "squareDrvTextBox";
            this.squareDrvTextBox.Size = new System.Drawing.Size(100, 20);
            this.squareDrvTextBox.TabIndex = 4;
            // 
            // roundDrvTextBox
            // 
            this.roundDrvTextBox.Location = new System.Drawing.Point(44, 176);
            this.roundDrvTextBox.Name = "roundDrvTextBox";
            this.roundDrvTextBox.Size = new System.Drawing.Size(100, 20);
            this.roundDrvTextBox.TabIndex = 3;
            // 
            // triactDrvRadioBtn
            // 
            this.triactDrvRadioBtn.AutoSize = true;
            this.triactDrvRadioBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.triactDrvRadioBtn.Location = new System.Drawing.Point(462, 205);
            this.triactDrvRadioBtn.Name = "triactDrvRadioBtn";
            this.triactDrvRadioBtn.Size = new System.Drawing.Size(136, 20);
            this.triactDrvRadioBtn.TabIndex = 2;
            this.triactDrvRadioBtn.TabStop = true;
            this.triactDrvRadioBtn.Text = "Jazda po trójkącie";
            this.triactDrvRadioBtn.UseVisualStyleBackColor = true;
            // 
            // squareDrvRadioBtn
            // 
            this.squareDrvRadioBtn.AutoSize = true;
            this.squareDrvRadioBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.squareDrvRadioBtn.Location = new System.Drawing.Point(243, 205);
            this.squareDrvRadioBtn.Name = "squareDrvRadioBtn";
            this.squareDrvRadioBtn.Size = new System.Drawing.Size(147, 20);
            this.squareDrvRadioBtn.TabIndex = 1;
            this.squareDrvRadioBtn.TabStop = true;
            this.squareDrvRadioBtn.Text = "Jazda po kwadracie";
            this.squareDrvRadioBtn.UseVisualStyleBackColor = true;
            // 
            // roundDrvRadioBtn
            // 
            this.roundDrvRadioBtn.AutoSize = true;
            this.roundDrvRadioBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.roundDrvRadioBtn.Location = new System.Drawing.Point(24, 205);
            this.roundDrvRadioBtn.Name = "roundDrvRadioBtn";
            this.roundDrvRadioBtn.Size = new System.Drawing.Size(127, 20);
            this.roundDrvRadioBtn.TabIndex = 0;
            this.roundDrvRadioBtn.TabStop = true;
            this.roundDrvRadioBtn.Text = "Jazda po okręgu";
            this.roundDrvRadioBtn.UseVisualStyleBackColor = true;
            // 
            // goButton
            // 
            this.goButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.goButton.Location = new System.Drawing.Point(566, 278);
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(75, 23);
            this.goButton.TabIndex = 1;
            this.goButton.Text = "Jedź!";
            this.goButton.UseVisualStyleBackColor = true;
            this.goButton.Click += new System.EventHandler(this.goButton_Click);
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = global::KheperaIV.Properties.Resources.circle;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel4.Location = new System.Drawing.Point(24, 35);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(153, 135);
            this.panel4.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::KheperaIV.Properties.Resources.square;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel3.Location = new System.Drawing.Point(237, 35);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(153, 135);
            this.panel3.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::KheperaIV.Properties.Resources.triact;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Location = new System.Drawing.Point(445, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(153, 135);
            this.panel2.TabIndex = 6;
            // 
            // PathDriveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 313);
            this.Controls.Add(this.goButton);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PathDriveForm";
            this.Text = "Podróż po ścieżce";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton triactDrvRadioBtn;
        private System.Windows.Forms.RadioButton squareDrvRadioBtn;
        private System.Windows.Forms.RadioButton roundDrvRadioBtn;
        private System.Windows.Forms.Button goButton;
        private System.Windows.Forms.TextBox triactDrvTextBox;
        private System.Windows.Forms.TextBox squareDrvTextBox;
        private System.Windows.Forms.TextBox roundDrvTextBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
    }
}