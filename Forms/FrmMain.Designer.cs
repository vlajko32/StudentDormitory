
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
            this.createResidentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateResidentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guestsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createGuestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteGuestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visitsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createVisitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateVisitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.pnlMain.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(761, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // residentsToolStripMenuItem
            // 
            this.residentsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createResidentToolStripMenuItem,
            this.updateResidentToolStripMenuItem});
            this.residentsToolStripMenuItem.Name = "residentsToolStripMenuItem";
            this.residentsToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.residentsToolStripMenuItem.Text = "Residents";
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
            this.updateResidentToolStripMenuItem.Text = "All residents";
            this.updateResidentToolStripMenuItem.Click += new System.EventHandler(this.updateResidentToolStripMenuItem_Click);
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
            // createGuestToolStripMenuItem
            // 
            this.createGuestToolStripMenuItem.Name = "createGuestToolStripMenuItem";
            this.createGuestToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.createGuestToolStripMenuItem.Text = "Create guest";
            this.createGuestToolStripMenuItem.Click += new System.EventHandler(this.createGuestToolStripMenuItem_Click);
            // 
            // deleteGuestToolStripMenuItem
            // 
            this.deleteGuestToolStripMenuItem.Name = "deleteGuestToolStripMenuItem";
            this.deleteGuestToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deleteGuestToolStripMenuItem.Text = "Delete guest";
            this.deleteGuestToolStripMenuItem.Click += new System.EventHandler(this.deleteGuestToolStripMenuItem_Click);
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
            // createVisitToolStripMenuItem
            // 
            this.createVisitToolStripMenuItem.Name = "createVisitToolStripMenuItem";
            this.createVisitToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.createVisitToolStripMenuItem.Text = "Create visit";
            // 
            // updateVisitToolStripMenuItem
            // 
            this.updateVisitToolStripMenuItem.Name = "updateVisitToolStripMenuItem";
            this.updateVisitToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.updateVisitToolStripMenuItem.Text = "Update visit";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.label1);
            this.pnlMain.Location = new System.Drawing.Point(123, 27);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(638, 424);
            this.pnlMain.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mistral", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(425, 352);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 451);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.Text = "Main window";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem residentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createResidentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateResidentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guestsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createGuestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteGuestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visitsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createVisitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateVisitToolStripMenuItem;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Label label1;
    }
}