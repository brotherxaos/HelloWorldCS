namespace HelloWorld
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
            this.HWLabel = new System.Windows.Forms.Label();
            this.HWButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HWLabel
            // 
            this.HWLabel.AutoSize = true;
            this.HWLabel.Font = new System.Drawing.Font("Viner Hand ITC", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HWLabel.ForeColor = System.Drawing.Color.Silver;
            this.HWLabel.Location = new System.Drawing.Point(1, 100);
            this.HWLabel.Name = "HWLabel";
            this.HWLabel.Size = new System.Drawing.Size(296, 69);
            this.HWLabel.TabIndex = 0;
            this.HWLabel.Text = "Hello World!";
            this.HWLabel.Visible = false;
            this.HWLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // HWButton
            // 
            this.HWButton.BackColor = System.Drawing.Color.Indigo;
            this.HWButton.FlatAppearance.BorderSize = 0;
            this.HWButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.HWButton.Font = new System.Drawing.Font("Mistral", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HWButton.ForeColor = System.Drawing.Color.White;
            this.HWButton.Location = new System.Drawing.Point(83, 15);
            this.HWButton.Name = "HWButton";
            this.HWButton.Size = new System.Drawing.Size(133, 82);
            this.HWButton.TabIndex = 1;
            this.HWButton.Text = "Click Me!";
            this.HWButton.UseVisualStyleBackColor = false;
            this.HWButton.Click += new System.EventHandler(this.HWButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.Green;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ExitButton.Font = new System.Drawing.Font("Magneto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.ForeColor = System.Drawing.Color.White;
            this.ExitButton.Location = new System.Drawing.Point(83, 15);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(133, 82);
            this.ExitButton.TabIndex = 2;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(298, 166);
            this.ControlBox = false;
            this.Controls.Add(this.HWLabel);
            this.Controls.Add(this.HWButton);
            this.Controls.Add(this.ExitButton);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Hello World";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HWLabel;
        private System.Windows.Forms.Button HWButton;
        private System.Windows.Forms.Button ExitButton;
    }
}

