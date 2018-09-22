namespace SDIMDI
{
    partial class Form2
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
            this.sendToParent = new System.Windows.Forms.Button();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.getFromParent = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // sendToParent
            // 
            this.sendToParent.Location = new System.Drawing.Point(231, 68);
            this.sendToParent.Name = "sendToParent";
            this.sendToParent.Size = new System.Drawing.Size(94, 26);
            this.sendToParent.TabIndex = 1;
            this.sendToParent.Text = "Kirim Ke Induk";
            this.sendToParent.UseVisualStyleBackColor = true;
            this.sendToParent.Click += new System.EventHandler(this.sendToParent_Click);
            // 
            // richTextBox
            // 
            this.richTextBox.Location = new System.Drawing.Point(33, 113);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(167, 143);
            this.richTextBox.TabIndex = 2;
            this.richTextBox.Text = "";
            // 
            // getFromParent
            // 
            this.getFromParent.Location = new System.Drawing.Point(231, 132);
            this.getFromParent.Name = "getFromParent";
            this.getFromParent.Size = new System.Drawing.Size(94, 26);
            this.getFromParent.TabIndex = 3;
            this.getFromParent.Text = "Ambil Dari Induk";
            this.getFromParent.UseVisualStyleBackColor = true;
            this.getFromParent.Click += new System.EventHandler(this.getFromParent_Click);
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(33, 68);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(167, 20);
            this.textBox.TabIndex = 4;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 350);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.getFromParent);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.sendToParent);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button sendToParent;
        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.Button getFromParent;
        private System.Windows.Forms.TextBox textBox;
    }
}