
namespace Forms.UserControls
{
    partial class UCResidents
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvResidents = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFindCardNmb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFindName = new System.Windows.Forms.TextBox();
            this.txtFindSurname = new System.Windows.Forms.TextBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResidents)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvResidents
            // 
            this.dgvResidents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResidents.Location = new System.Drawing.Point(103, 191);
            this.dgvResidents.MultiSelect = false;
            this.dgvResidents.Name = "dgvResidents";
            this.dgvResidents.Size = new System.Drawing.Size(430, 221);
            this.dgvResidents.TabIndex = 0;
            this.dgvResidents.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvResidents_RowHeaderMouseDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(279, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Residents";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtFindCardNmb
            // 
            this.txtFindCardNmb.Location = new System.Drawing.Point(227, 79);
            this.txtFindCardNmb.Name = "txtFindCardNmb";
            this.txtFindCardNmb.Size = new System.Drawing.Size(100, 20);
            this.txtFindCardNmb.TabIndex = 2;
            this.txtFindCardNmb.TextChanged += new System.EventHandler(this.txtFindCardNmb_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Find by card number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(100, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Find by name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(100, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Find by surname";
            // 
            // txtFindName
            // 
            this.txtFindName.Location = new System.Drawing.Point(227, 119);
            this.txtFindName.Name = "txtFindName";
            this.txtFindName.Size = new System.Drawing.Size(100, 20);
            this.txtFindName.TabIndex = 6;
            this.txtFindName.TextChanged += new System.EventHandler(this.txtFindName_TextChanged);
            // 
            // txtFindSurname
            // 
            this.txtFindSurname.Location = new System.Drawing.Point(227, 153);
            this.txtFindSurname.Name = "txtFindSurname";
            this.txtFindSurname.Size = new System.Drawing.Size(100, 20);
            this.txtFindSurname.TabIndex = 7;
            this.txtFindSurname.TextChanged += new System.EventHandler(this.txtFindSurname_TextChanged);
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(401, 82);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 23);
            this.btnFind.TabIndex = 8;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(401, 146);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(401, 112);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(62, 23);
            this.btnReset.TabIndex = 10;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // UCResidents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.txtFindSurname);
            this.Controls.Add(this.txtFindName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFindCardNmb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvResidents);
            this.Name = "UCResidents";
            this.Size = new System.Drawing.Size(638, 424);
            this.Load += new System.EventHandler(this.UCResidents_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResidents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvResidents;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFindCardNmb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFindName;
        private System.Windows.Forms.TextBox txtFindSurname;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnReset;
    }
}
