namespace SDIMDI
{
    partial class FormSDIMDI
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sDIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.form2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showSDI = new System.Windows.Forms.ToolStripMenuItem();
            this.hideSDI = new System.Windows.Forms.ToolStripMenuItem();
            this.maxSDI = new System.Windows.Forms.ToolStripMenuItem();
            this.minSDI = new System.Windows.Forms.ToolStripMenuItem();
            this.changeTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ambilTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mDIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.form3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showMDI = new System.Windows.Forms.ToolStripMenuItem();
            this.hideMDI = new System.Windows.Forms.ToolStripMenuItem();
            this.maxMDI = new System.Windows.Forms.ToolStripMenuItem();
            this.minMDI = new System.Windows.Forms.ToolStripMenuItem();
            this.changeTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ambilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ambilDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.sDIToolStripMenuItem,
            this.mDIToolStripMenuItem,
            this.userToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // sDIToolStripMenuItem
            // 
            this.sDIToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.form2ToolStripMenuItem});
            this.sDIToolStripMenuItem.Name = "sDIToolStripMenuItem";
            this.sDIToolStripMenuItem.Size = new System.Drawing.Size(36, 20);
            this.sDIToolStripMenuItem.Text = "SDI";
            // 
            // form2ToolStripMenuItem
            // 
            this.form2ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showSDI,
            this.hideSDI,
            this.maxSDI,
            this.minSDI,
            this.changeTextToolStripMenuItem,
            this.ambilTextToolStripMenuItem});
            this.form2ToolStripMenuItem.Name = "form2ToolStripMenuItem";
            this.form2ToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.form2ToolStripMenuItem.Text = "Form2";
            // 
            // showSDI
            // 
            this.showSDI.Name = "showSDI";
            this.showSDI.Size = new System.Drawing.Size(139, 22);
            this.showSDI.Text = "Show";
            this.showSDI.Click += new System.EventHandler(this.showSDI_Click);
            // 
            // hideSDI
            // 
            this.hideSDI.Name = "hideSDI";
            this.hideSDI.Size = new System.Drawing.Size(139, 22);
            this.hideSDI.Text = "Hide";
            this.hideSDI.Click += new System.EventHandler(this.hideSDI_Click);
            // 
            // maxSDI
            // 
            this.maxSDI.Name = "maxSDI";
            this.maxSDI.Size = new System.Drawing.Size(139, 22);
            this.maxSDI.Text = "Maximized";
            this.maxSDI.Click += new System.EventHandler(this.maxSDI_Click);
            // 
            // minSDI
            // 
            this.minSDI.Name = "minSDI";
            this.minSDI.Size = new System.Drawing.Size(139, 22);
            this.minSDI.Text = "Minimized";
            this.minSDI.Click += new System.EventHandler(this.minSDI_Click);
            // 
            // changeTextToolStripMenuItem
            // 
            this.changeTextToolStripMenuItem.Name = "changeTextToolStripMenuItem";
            this.changeTextToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.changeTextToolStripMenuItem.Text = "Change Text";
            // 
            // ambilTextToolStripMenuItem
            // 
            this.ambilTextToolStripMenuItem.Name = "ambilTextToolStripMenuItem";
            this.ambilTextToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.ambilTextToolStripMenuItem.Text = "Ambil Text";
            // 
            // mDIToolStripMenuItem
            // 
            this.mDIToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.form3ToolStripMenuItem});
            this.mDIToolStripMenuItem.Name = "mDIToolStripMenuItem";
            this.mDIToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.mDIToolStripMenuItem.Text = "MDI";
            // 
            // form3ToolStripMenuItem
            // 
            this.form3ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showMDI,
            this.hideMDI,
            this.maxMDI,
            this.minMDI,
            this.changeTestToolStripMenuItem,
            this.ambilToolStripMenuItem,
            this.ambilDToolStripMenuItem});
            this.form3ToolStripMenuItem.Name = "form3ToolStripMenuItem";
            this.form3ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.form3ToolStripMenuItem.Text = "Form3";
            // 
            // showMDI
            // 
            this.showMDI.Name = "showMDI";
            this.showMDI.Size = new System.Drawing.Size(180, 22);
            this.showMDI.Text = "Show";
            this.showMDI.Click += new System.EventHandler(this.showMDI_Click);
            // 
            // hideMDI
            // 
            this.hideMDI.Name = "hideMDI";
            this.hideMDI.Size = new System.Drawing.Size(180, 22);
            this.hideMDI.Text = "Hide";
            this.hideMDI.Click += new System.EventHandler(this.hideMDI_Click);
            // 
            // maxMDI
            // 
            this.maxMDI.Name = "maxMDI";
            this.maxMDI.Size = new System.Drawing.Size(180, 22);
            this.maxMDI.Text = "Maximized";
            this.maxMDI.Click += new System.EventHandler(this.maxMDI_Click);
            // 
            // minMDI
            // 
            this.minMDI.Name = "minMDI";
            this.minMDI.Size = new System.Drawing.Size(180, 22);
            this.minMDI.Text = "Minimized";
            this.minMDI.Click += new System.EventHandler(this.minMDI_Click);
            // 
            // changeTestToolStripMenuItem
            // 
            this.changeTestToolStripMenuItem.Name = "changeTestToolStripMenuItem";
            this.changeTestToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.changeTestToolStripMenuItem.Text = "Change Text";
            // 
            // ambilToolStripMenuItem
            // 
            this.ambilToolStripMenuItem.Name = "ambilToolStripMenuItem";
            this.ambilToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ambilToolStripMenuItem.Text = "Ambil Text";
            // 
            // ambilDToolStripMenuItem
            // 
            this.ambilDToolStripMenuItem.Name = "ambilDToolStripMenuItem";
            this.ambilDToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ambilDToolStripMenuItem.Text = "Ambil Dari Form3";
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showToolStripMenuItem2});
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.userToolStripMenuItem.Text = "User";
            // 
            // showToolStripMenuItem2
            // 
            this.showToolStripMenuItem2.Name = "showToolStripMenuItem2";
            this.showToolStripMenuItem2.Size = new System.Drawing.Size(103, 22);
            this.showToolStripMenuItem2.Text = "Show";
            this.showToolStripMenuItem2.Click += new System.EventHandler(this.showToolStripMenuItem2_Click);
            // 
            // FormSDIMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormSDIMDI";
            this.Text = "Form SDI MDI";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sDIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mDIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem form3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showMDI;
        private System.Windows.Forms.ToolStripMenuItem hideMDI;
        private System.Windows.Forms.ToolStripMenuItem maxMDI;
        private System.Windows.Forms.ToolStripMenuItem minMDI;
        private System.Windows.Forms.ToolStripMenuItem changeTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ambilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ambilDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem form2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showSDI;
        private System.Windows.Forms.ToolStripMenuItem hideSDI;
        private System.Windows.Forms.ToolStripMenuItem maxSDI;
        private System.Windows.Forms.ToolStripMenuItem minSDI;
        private System.Windows.Forms.ToolStripMenuItem changeTextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ambilTextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem2;
    }
}

