namespace JDOPClients
{
    partial class Third
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
            this.Client3btn = new System.Windows.Forms.Button();
            this.client3combo = new System.Windows.Forms.ComboBox();
            this.client3Textbox = new System.Windows.Forms.RichTextBox();
            this.Client3Labl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Client3btn
            // 
            this.Client3btn.Location = new System.Drawing.Point(12, 248);
            this.Client3btn.Name = "Client3btn";
            this.Client3btn.Size = new System.Drawing.Size(108, 23);
            this.Client3btn.TabIndex = 0;
            this.Client3btn.Text = "Send Data";
            this.Client3btn.UseVisualStyleBackColor = true;
            this.Client3btn.Click += new System.EventHandler(this.Client3btn_Click);
            // 
            // client3combo
            // 
            this.client3combo.FormattingEnabled = true;
            this.client3combo.Items.AddRange(new object[] {
            "ADD",
            "MINUS",
            "DIVIDE"});
            this.client3combo.Location = new System.Drawing.Point(135, 248);
            this.client3combo.Name = "client3combo";
            this.client3combo.Size = new System.Drawing.Size(184, 21);
            this.client3combo.TabIndex = 1;
            // 
            // client3Textbox
            // 
            this.client3Textbox.Location = new System.Drawing.Point(12, 27);
            this.client3Textbox.Name = "client3Textbox";
            this.client3Textbox.Size = new System.Drawing.Size(307, 199);
            this.client3Textbox.TabIndex = 2;
            this.client3Textbox.Text = "";
            // 
            // Client3Labl
            // 
            this.Client3Labl.AutoSize = true;
            this.Client3Labl.Location = new System.Drawing.Point(12, 9);
            this.Client3Labl.Name = "Client3Labl";
            this.Client3Labl.Size = new System.Drawing.Size(35, 13);
            this.Client3Labl.TabIndex = 3;
            this.Client3Labl.Text = "label1";
            // 
            // Third
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 281);
            this.Controls.Add(this.Client3Labl);
            this.Controls.Add(this.client3Textbox);
            this.Controls.Add(this.client3combo);
            this.Controls.Add(this.Client3btn);
            this.Name = "Third";
            this.Text = "Client---->#3";
            this.Load += new System.EventHandler(this.Third_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Client3btn;
        private System.Windows.Forms.ComboBox client3combo;
        private System.Windows.Forms.RichTextBox client3Textbox;
        private System.Windows.Forms.Label Client3Labl;
    }
}