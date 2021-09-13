
namespace Forms
{
    partial class FrmMain
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
            this.residentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guestsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visitsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createResidentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateResidentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteResidentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findResidentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createGuestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteGuestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createVisitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateVisitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.residentsToolStripMenuItem,
            this.guestsToolStripMenuItem,
            this.visitsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(675, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // residentsToolStripMenuItem
            // 
            this.residentsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createResidentToolStripMenuItem,
            this.updateResidentToolStripMenuItem,
            this.deleteResidentToolStripMenuItem,
            this.findResidentToolStripMenuItem});
            this.residentsToolStripMenuItem.Name = "residentsToolStripMenuItem";
            this.residentsToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.residentsToolStripMenuItem.Text = "Residents";
            // 
            // guestsToolStripMenuItem
            // 
            this.guestsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createGuestToolStripMenuItem,
            this.deleteGuestToolStripMenuItem});
            this.guestsToolStripMenuItem.Name = "guestsToolStripMenuItem";
            this.guestsToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.guestsToolStripMenuItem.Text = "Guests";
            // 
            // visitsToolStripMenuItem
            // 
            this.visitsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createVisitToolStripMenuItem,
            this.updateVisitToolStripMenuItem});
            this.visitsToolStripMenuItem.Name = "visitsToolStripMenuItem";
            this.visitsToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.visitsToolStripMenuItem.Text = "Visits";
            // 
            // createResidentToolStripMenuItem
            // 
            this.createResidentToolStripMenuItem.Name = "createResidentToolStripMenuItem";
            this.createResidentToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.createResidentToolStripMenuItem.Text = "Create resident";
            this.createResidentToolStripMenuItem.Click += new System.EventHandler(this.createResidentToolStripMenuItem_Click);
            // 
            // updateResidentToolStripMenuItem
            // 
            this.updateResidentToolStripMenuItem.Name = "updateResidentToolStripMenuItem";
            this.updateResidentToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.updateResidentToolStripMenuItem.Text = "Update resident";
            // 
            // deleteResidentToolStripMenuItem
            // 
            this.deleteResidentToolStripMenuItem.Name = "deleteResidentToolStripMenuItem";
            this.deleteResidentToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deleteResidentToolStripMenuItem.Text = "Delete resident";
            // 
            // findResidentToolStripMenuItem
            // 
            this.findResidentToolStripMenuItem.Name = "findResidentToolStripMenuItem";
            this.findResidentToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.findResidentToolStripMenuItem.Text = "Find resident";
            // 
            // createGuestToolStripMenuItem
            // 
            this.createGuestToolStripMenuItem.Name = "createGuestToolStripMenuItem";
            this.createGuestToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.createGuestToolStripMenuItem.Text = "Create guest";
            // 
            // deleteGuestToolStripMenuItem
            // 
            this.deleteGuestToolStripMenuItem.Name = "deleteGuestToolStripMenuItem";
            this.deleteGuestToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deleteGuestToolStripMenuItem.Text = "Delete guest";
            // 
            // createVisitToolStripMenuItem
            // 
            this.createVisitToolStripMenuItem.Name = "createVisitToolStripMenuItem";
            this.createVisitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.createVisitToolStripMenuItem.Text = "Create visit";
            // 
            // updateVisitToolStripMenuItem
            // 
            this.updateVisitToolStripMenuItem.Name = "updateVisitToolStripMenuItem";
            this.updateVisitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.updateVisitToolStripMenuItem.Text = "Update visit";
            // 
            // pnlMain
            // 
            this.pnlMain.Location = new System.Drawing.Point(0, 27);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(671, 420);
            this.pnlMain.TabIndex = 1;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 451);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.Text = "FrmMain";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem residentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createResidentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateResidentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteResidentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findResidentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guestsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createGuestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteGuestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visitsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createVisitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateVisitToolStripMenuItem;
        private System.Windows.Forms.Panel pnlMain;
    }
}