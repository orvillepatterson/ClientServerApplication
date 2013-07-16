namespace JDOPClients
{
    partial class First
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
            this.client1labl = new System.Windows.Forms.Label();
            this.Client1Textbox = new System.Windows.Forms.RichTextBox();
            this.CLient1Butn = new System.Windows.Forms.Button();
            this.client1combo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // client1labl
            // 
            this.client1labl.AutoSize = true;
            this.client1labl.Location = new System.Drawing.Point(17, 6);
            this.client1labl.Name = "client1labl";
            this.client1labl.Size = new System.Drawing.Size(29, 13);
            this.client1labl.TabIndex = 0;
            this.client1labl.Text = "label";
            // 
            // Client1Textbox
            // 
            this.Client1Textbox.Location = new System.Drawing.Point(16, 28);
            this.Client1Textbox.Name = "Client1Textbox";
            this.Client1Textbox.Size = new System.Drawing.Size(335, 242);
            this.Client1Textbox.TabIndex = 1;
            this.Client1Textbox.Text = "";
            // 
            // CLient1Butn
            // 
            this.CLient1Butn.Location = new System.Drawing.Point(16, 277);
            this.CLient1Butn.Name = "CLient1Butn";
            this.CLient1Butn.Size = new System.Drawing.Size(75, 23);
            this.CLient1Butn.TabIndex = 2;
            this.CLient1Butn.Text = "Send Data";
            this.CLient1Butn.UseVisualStyleBackColor = true;
            this.CLient1Butn.Click += new System.EventHandler(this.CLient1Butn_Click);
            // 
            // client1combo
            // 
            this.client1combo.FormattingEnabled = true;
            this.client1combo.Items.AddRange(new object[] {
            "ADD",
            "MINUS",
            "DIVIDE"});
            this.client1combo.Location = new System.Drawing.Point(126, 278);
            this.client1combo.Name = "client1combo";
            this.client1combo.Size = new System.Drawing.Size(191, 21);
            this.client1combo.TabIndex = 3;
            this.client1combo.Text = "Select Data to be Sent";
            // 
            // First
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 312);
            this.Controls.Add(this.client1combo);
            this.Controls.Add(this.CLient1Butn);
            this.Controls.Add(this.Client1Textbox);
            this.Controls.Add(this.client1labl);
            this.Name = "First";
            this.Text = "Client ---> #1";
            this.Load += new System.EventHandler(this.First_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label client1labl;
        private System.Windows.Forms.RichTextBox Client1Textbox;
        private System.Windows.Forms.Button CLient1Butn;
        private System.Windows.Forms.ComboBox client1combo;
    }
}