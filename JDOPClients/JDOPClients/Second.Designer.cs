namespace JDOPClients
{
    partial class Second
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
            this.Client2Labl = new System.Windows.Forms.Label();
            this.Client2Textbox = new System.Windows.Forms.RichTextBox();
            this.Client2button = new System.Windows.Forms.Button();
            this.Client2Combo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Client2Labl
            // 
            this.Client2Labl.AutoSize = true;
            this.Client2Labl.Location = new System.Drawing.Point(9, 9);
            this.Client2Labl.Name = "Client2Labl";
            this.Client2Labl.Size = new System.Drawing.Size(35, 13);
            this.Client2Labl.TabIndex = 0;
            this.Client2Labl.Text = "label1";
            // 
            // Client2Textbox
            // 
            this.Client2Textbox.Location = new System.Drawing.Point(12, 31);
            this.Client2Textbox.Name = "Client2Textbox";
            this.Client2Textbox.Size = new System.Drawing.Size(394, 255);
            this.Client2Textbox.TabIndex = 1;
            this.Client2Textbox.Text = "";
            // 
            // Client2button
            // 
            this.Client2button.Location = new System.Drawing.Point(12, 293);
            this.Client2button.Name = "Client2button";
            this.Client2button.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Client2button.Size = new System.Drawing.Size(75, 23);
            this.Client2button.TabIndex = 2;
            this.Client2button.Text = "Send Data";
            this.Client2button.UseVisualStyleBackColor = true;
            this.Client2button.Click += new System.EventHandler(this.button1_Click);
            // 
            // Client2Combo
            // 
            this.Client2Combo.FormattingEnabled = true;
            this.Client2Combo.Items.AddRange(new object[] {
            "ADD",
            "MINUS",
            "DIVIDE"});
            this.Client2Combo.Location = new System.Drawing.Point(117, 293);
            this.Client2Combo.Name = "Client2Combo";
            this.Client2Combo.Size = new System.Drawing.Size(255, 21);
            this.Client2Combo.TabIndex = 3;
            this.Client2Combo.Text = "Select Data to be Sent";
            // 
            // Second
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 328);
            this.Controls.Add(this.Client2Combo);
            this.Controls.Add(this.Client2button);
            this.Controls.Add(this.Client2Textbox);
            this.Controls.Add(this.Client2Labl);
            this.Name = "Second";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Client --> #2";
            this.Load += new System.EventHandler(this.Second_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Client2Labl;
        private System.Windows.Forms.RichTextBox Client2Textbox;
        private System.Windows.Forms.Button Client2button;
        private System.Windows.Forms.ComboBox Client2Combo;
    }
}