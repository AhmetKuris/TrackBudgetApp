namespace TrackBudgetApp.WindowsFormsUI
{
    partial class Categories
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
            this.dgwTransactionsByCategory = new System.Windows.Forms.DataGridView();
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.btnChildFormClose = new System.Windows.Forms.Button();
            this.cbxTransactionsByCategory = new System.Windows.Forms.ComboBox();
            this.tbxAddNewCategoryName = new System.Windows.Forms.TextBox();
            this.btnDeleteCategory = new System.Windows.Forms.Button();
            this.cbxCategoryListDelete = new System.Windows.Forms.ComboBox();
            this.dgwCategories = new System.Windows.Forms.DataGridView();
            this.gbxAddNewCategory = new System.Windows.Forms.GroupBox();
            this.gbxDeleteCategory = new System.Windows.Forms.GroupBox();
            this.gbxTransactionsByCategory = new System.Windows.Forms.GroupBox();
            this.gbxCategoryTop = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgwTransactionsByCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwCategories)).BeginInit();
            this.gbxAddNewCategory.SuspendLayout();
            this.gbxDeleteCategory.SuspendLayout();
            this.gbxTransactionsByCategory.SuspendLayout();
            this.gbxCategoryTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwTransactionsByCategory
            // 
            this.dgwTransactionsByCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgwTransactionsByCategory.BackgroundColor = System.Drawing.Color.White;
            this.dgwTransactionsByCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwTransactionsByCategory.Location = new System.Drawing.Point(35, 69);
            this.dgwTransactionsByCategory.Margin = new System.Windows.Forms.Padding(4);
            this.dgwTransactionsByCategory.Name = "dgwTransactionsByCategory";
            this.dgwTransactionsByCategory.Size = new System.Drawing.Size(607, 290);
            this.dgwTransactionsByCategory.TabIndex = 0;
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(153)))), ((int)(((byte)(93)))));
            this.btnAddCategory.FlatAppearance.BorderSize = 0;
            this.btnAddCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCategory.ForeColor = System.Drawing.Color.White;
            this.btnAddCategory.Location = new System.Drawing.Point(29, 114);
            this.btnAddCategory.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(100, 28);
            this.btnAddCategory.TabIndex = 3;
            this.btnAddCategory.Text = "Add";
            this.btnAddCategory.UseVisualStyleBackColor = false;
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
            this.btnChildFormClose.TabIndex = 4;
            this.btnChildFormClose.Text = "X";
            this.btnChildFormClose.UseVisualStyleBackColor = false;
            this.btnChildFormClose.Click += new System.EventHandler(this.btnChildFormClose_Click);
            // 
            // cbxTransactionsByCategory
            // 
            this.cbxTransactionsByCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxTransactionsByCategory.FormattingEnabled = true;
            this.cbxTransactionsByCategory.Location = new System.Drawing.Point(521, 22);
            this.cbxTransactionsByCategory.Name = "cbxTransactionsByCategory";
            this.cbxTransactionsByCategory.Size = new System.Drawing.Size(121, 24);
            this.cbxTransactionsByCategory.TabIndex = 5;
            // 
            // tbxAddNewCategoryName
            // 
            this.tbxAddNewCategoryName.Location = new System.Drawing.Point(18, 41);
            this.tbxAddNewCategoryName.Name = "tbxAddNewCategoryName";
            this.tbxAddNewCategoryName.Size = new System.Drawing.Size(121, 23);
            this.tbxAddNewCategoryName.TabIndex = 6;
            // 
            // btnDeleteCategory
            // 
            this.btnDeleteCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(153)))), ((int)(((byte)(93)))));
            this.btnDeleteCategory.FlatAppearance.BorderSize = 0;
            this.btnDeleteCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteCategory.ForeColor = System.Drawing.Color.White;
            this.btnDeleteCategory.Location = new System.Drawing.Point(25, 115);
            this.btnDeleteCategory.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteCategory.Name = "btnDeleteCategory";
            this.btnDeleteCategory.Size = new System.Drawing.Size(100, 28);
            this.btnDeleteCategory.TabIndex = 7;
            this.btnDeleteCategory.Text = "Delete";
            this.btnDeleteCategory.UseVisualStyleBackColor = false;
            // 
            // cbxCategoryListDelete
            // 
            this.cbxCategoryListDelete.FormattingEnabled = true;
            this.cbxCategoryListDelete.Location = new System.Drawing.Point(14, 37);
            this.cbxCategoryListDelete.Name = "cbxCategoryListDelete";
            this.cbxCategoryListDelete.Size = new System.Drawing.Size(121, 24);
            this.cbxCategoryListDelete.TabIndex = 8;
            // 
            // dgwCategories
            // 
            this.dgwCategories.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dgwCategories.BackgroundColor = System.Drawing.Color.White;
            this.dgwCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwCategories.Location = new System.Drawing.Point(22, 63);
            this.dgwCategories.Margin = new System.Windows.Forms.Padding(4);
            this.dgwCategories.Name = "dgwCategories";
            this.dgwCategories.Size = new System.Drawing.Size(236, 237);
            this.dgwCategories.TabIndex = 9;
            // 
            // gbxAddNewCategory
            // 
            this.gbxAddNewCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.gbxAddNewCategory.Controls.Add(this.tbxAddNewCategoryName);
            this.gbxAddNewCategory.Controls.Add(this.btnAddCategory);
            this.gbxAddNewCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(153)))), ((int)(((byte)(93)))));
            this.gbxAddNewCategory.Location = new System.Drawing.Point(292, 63);
            this.gbxAddNewCategory.Name = "gbxAddNewCategory";
            this.gbxAddNewCategory.Size = new System.Drawing.Size(151, 172);
            this.gbxAddNewCategory.TabIndex = 10;
            this.gbxAddNewCategory.TabStop = false;
            this.gbxAddNewCategory.Text = "Add New Category";
            // 
            // gbxDeleteCategory
            // 
            this.gbxDeleteCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.gbxDeleteCategory.Controls.Add(this.cbxCategoryListDelete);
            this.gbxDeleteCategory.Controls.Add(this.btnDeleteCategory);
            this.gbxDeleteCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(153)))), ((int)(((byte)(93)))));
            this.gbxDeleteCategory.Location = new System.Drawing.Point(491, 63);
            this.gbxDeleteCategory.Name = "gbxDeleteCategory";
            this.gbxDeleteCategory.Size = new System.Drawing.Size(151, 172);
            this.gbxDeleteCategory.TabIndex = 11;
            this.gbxDeleteCategory.TabStop = false;
            this.gbxDeleteCategory.Text = "Delete Category";
            // 
            // gbxTransactionsByCategory
            // 
            this.gbxTransactionsByCategory.Controls.Add(this.cbxTransactionsByCategory);
            this.gbxTransactionsByCategory.Controls.Add(this.dgwTransactionsByCategory);
            this.gbxTransactionsByCategory.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbxTransactionsByCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(153)))), ((int)(((byte)(93)))));
            this.gbxTransactionsByCategory.Location = new System.Drawing.Point(0, 356);
            this.gbxTransactionsByCategory.Name = "gbxTransactionsByCategory";
            this.gbxTransactionsByCategory.Size = new System.Drawing.Size(684, 393);
            this.gbxTransactionsByCategory.TabIndex = 12;
            this.gbxTransactionsByCategory.TabStop = false;
            this.gbxTransactionsByCategory.Text = "Transactions By Category";
            // 
            // gbxCategoryTop
            // 
            this.gbxCategoryTop.Controls.Add(this.gbxAddNewCategory);
            this.gbxCategoryTop.Controls.Add(this.dgwCategories);
            this.gbxCategoryTop.Controls.Add(this.gbxDeleteCategory);
            this.gbxCategoryTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbxCategoryTop.Location = new System.Drawing.Point(0, 0);
            this.gbxCategoryTop.Name = "gbxCategoryTop";
            this.gbxCategoryTop.Size = new System.Drawing.Size(684, 337);
            this.gbxCategoryTop.TabIndex = 13;
            this.gbxCategoryTop.TabStop = false;
            // 
            // Categories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(684, 749);
            this.Controls.Add(this.gbxTransactionsByCategory);
            this.Controls.Add(this.btnChildFormClose);
            this.Controls.Add(this.gbxCategoryTop);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Categories";
            this.Text = "Categories";
            ((System.ComponentModel.ISupportInitialize)(this.dgwTransactionsByCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwCategories)).EndInit();
            this.gbxAddNewCategory.ResumeLayout(false);
            this.gbxAddNewCategory.PerformLayout();
            this.gbxDeleteCategory.ResumeLayout(false);
            this.gbxTransactionsByCategory.ResumeLayout(false);
            this.gbxCategoryTop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwTransactionsByCategory;
        private System.Windows.Forms.Button btnAddCategory;
        private System.Windows.Forms.Button btnChildFormClose;
        private System.Windows.Forms.ComboBox cbxTransactionsByCategory;
        private System.Windows.Forms.TextBox tbxAddNewCategoryName;
        private System.Windows.Forms.Button btnDeleteCategory;
        private System.Windows.Forms.ComboBox cbxCategoryListDelete;
        private System.Windows.Forms.DataGridView dgwCategories;
        private System.Windows.Forms.GroupBox gbxAddNewCategory;
        private System.Windows.Forms.GroupBox gbxDeleteCategory;
        private System.Windows.Forms.GroupBox gbxTransactionsByCategory;
        private System.Windows.Forms.GroupBox gbxCategoryTop;
    }
}