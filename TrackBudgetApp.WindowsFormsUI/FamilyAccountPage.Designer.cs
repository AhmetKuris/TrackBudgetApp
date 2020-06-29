namespace TrackBudgetApp.WindowsFormsUI
{
    partial class FamilyAccountPage
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
            this.btnChildFormClose = new System.Windows.Forms.Button();
            this.dgwFamilyMembers = new System.Windows.Forms.DataGridView();
            this.btnAddFamilyMember = new System.Windows.Forms.Button();
            this.btnDeleteFamilyMember = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDetailsFamilyMember = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwFamilyMembers)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnChildFormClose
            // 
            this.btnChildFormClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(153)))), ((int)(((byte)(93)))));
            this.btnChildFormClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChildFormClose.FlatAppearance.BorderSize = 0;
            this.btnChildFormClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChildFormClose.ForeColor = System.Drawing.Color.White;
            this.btnChildFormClose.Location = new System.Drawing.Point(13, 13);
            this.btnChildFormClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnChildFormClose.Name = "btnChildFormClose";
            this.btnChildFormClose.Size = new System.Drawing.Size(100, 28);
            this.btnChildFormClose.TabIndex = 6;
            this.btnChildFormClose.Text = "X";
            this.btnChildFormClose.UseVisualStyleBackColor = false;
            this.btnChildFormClose.Click += new System.EventHandler(this.btnChildFormClose_Click);
            // 
            // dgwFamilyMembers
            // 
            this.dgwFamilyMembers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgwFamilyMembers.BackgroundColor = System.Drawing.Color.White;
            this.dgwFamilyMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwFamilyMembers.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(153)))), ((int)(((byte)(93)))));
            this.dgwFamilyMembers.Location = new System.Drawing.Point(31, 96);
            this.dgwFamilyMembers.Margin = new System.Windows.Forms.Padding(4);
            this.dgwFamilyMembers.Name = "dgwFamilyMembers";
            this.dgwFamilyMembers.Size = new System.Drawing.Size(625, 149);
            this.dgwFamilyMembers.TabIndex = 7;
            // 
            // btnAddFamilyMember
            // 
            this.btnAddFamilyMember.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddFamilyMember.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(153)))), ((int)(((byte)(93)))));
            this.btnAddFamilyMember.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddFamilyMember.FlatAppearance.BorderSize = 0;
            this.btnAddFamilyMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddFamilyMember.ForeColor = System.Drawing.Color.White;
            this.btnAddFamilyMember.Location = new System.Drawing.Point(498, 273);
            this.btnAddFamilyMember.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddFamilyMember.Name = "btnAddFamilyMember";
            this.btnAddFamilyMember.Size = new System.Drawing.Size(158, 28);
            this.btnAddFamilyMember.TabIndex = 6;
            this.btnAddFamilyMember.Text = "Add Family Member";
            this.btnAddFamilyMember.UseVisualStyleBackColor = false;
            // 
            // btnDeleteFamilyMember
            // 
            this.btnDeleteFamilyMember.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteFamilyMember.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(153)))), ((int)(((byte)(93)))));
            this.btnDeleteFamilyMember.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteFamilyMember.FlatAppearance.BorderSize = 0;
            this.btnDeleteFamilyMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteFamilyMember.ForeColor = System.Drawing.Color.White;
            this.btnDeleteFamilyMember.Location = new System.Drawing.Point(332, 273);
            this.btnDeleteFamilyMember.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteFamilyMember.Name = "btnDeleteFamilyMember";
            this.btnDeleteFamilyMember.Size = new System.Drawing.Size(158, 28);
            this.btnDeleteFamilyMember.TabIndex = 8;
            this.btnDeleteFamilyMember.Text = "Delete Family Member";
            this.btnDeleteFamilyMember.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnChildFormClose);
            this.groupBox1.Controls.Add(this.btnDetailsFamilyMember);
            this.groupBox1.Controls.Add(this.btnDeleteFamilyMember);
            this.groupBox1.Controls.Add(this.dgwFamilyMembers);
            this.groupBox1.Controls.Add(this.btnAddFamilyMember);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(684, 343);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(153)))), ((int)(((byte)(93)))));
            this.label1.Location = new System.Drawing.Point(250, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Current Family Members";
            // 
            // btnDetailsFamilyMember
            // 
            this.btnDetailsFamilyMember.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDetailsFamilyMember.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(153)))), ((int)(((byte)(93)))));
            this.btnDetailsFamilyMember.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDetailsFamilyMember.FlatAppearance.BorderSize = 0;
            this.btnDetailsFamilyMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetailsFamilyMember.ForeColor = System.Drawing.Color.White;
            this.btnDetailsFamilyMember.Location = new System.Drawing.Point(166, 273);
            this.btnDetailsFamilyMember.Margin = new System.Windows.Forms.Padding(4);
            this.btnDetailsFamilyMember.Name = "btnDetailsFamilyMember";
            this.btnDetailsFamilyMember.Size = new System.Drawing.Size(158, 28);
            this.btnDetailsFamilyMember.TabIndex = 8;
            this.btnDetailsFamilyMember.Text = "Details";
            this.btnDetailsFamilyMember.UseVisualStyleBackColor = false;
            this.btnDetailsFamilyMember.Click += new System.EventHandler(this.btnDetailsFamilyMember_Click);
            // 
            // FamilyAccountPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(684, 749);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FamilyAccountPage";
            this.Text = "FamilyAccount";
            ((System.ComponentModel.ISupportInitialize)(this.dgwFamilyMembers)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnChildFormClose;
        private System.Windows.Forms.DataGridView dgwFamilyMembers;
        private System.Windows.Forms.Button btnAddFamilyMember;
        private System.Windows.Forms.Button btnDeleteFamilyMember;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDetailsFamilyMember;
    }
}