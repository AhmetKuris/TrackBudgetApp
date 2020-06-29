namespace TrackBudgetApp.WindowsFormsUI
{
    partial class PlannerPage
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
            this.gbxStartTracking = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanelTransaction = new System.Windows.Forms.TableLayoutPanel();
            this.lblEffectiveDate = new System.Windows.Forms.Label();
            this.lblTransactionDescription = new System.Windows.Forms.Label();
            this.lblTransactionAmount = new System.Windows.Forms.Label();
            this.tbxTransactionDescription = new System.Windows.Forms.TextBox();
            this.tbxTransactionAmount = new System.Windows.Forms.TextBox();
            this.lblTransactionName = new System.Windows.Forms.Label();
            this.lblTransactionCategory = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.cbxTrackingAlert = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickereTransactionEffectiveDate = new System.Windows.Forms.DateTimePicker();
            this.btnStartTracking = new System.Windows.Forms.Button();
            this.btnChildFormClose = new System.Windows.Forms.Button();
            this.gbxCurrentlyTracking = new System.Windows.Forms.GroupBox();
            this.dgwCurrentlyTracking = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.gbxStartTracking.SuspendLayout();
            this.tableLayoutPanelTransaction.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.gbxCurrentlyTracking.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwCurrentlyTracking)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxStartTracking
            // 
            this.gbxStartTracking.Controls.Add(this.tableLayoutPanelTransaction);
            this.gbxStartTracking.Controls.Add(this.btnStartTracking);
            this.gbxStartTracking.Controls.Add(this.btnChildFormClose);
            this.gbxStartTracking.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbxStartTracking.Location = new System.Drawing.Point(0, 0);
            this.gbxStartTracking.Name = "gbxStartTracking";
            this.gbxStartTracking.Size = new System.Drawing.Size(684, 265);
            this.gbxStartTracking.TabIndex = 0;
            this.gbxStartTracking.TabStop = false;
            // 
            // tableLayoutPanelTransaction
            // 
            this.tableLayoutPanelTransaction.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelTransaction.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanelTransaction.ColumnCount = 5;
            this.tableLayoutPanelTransaction.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelTransaction.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelTransaction.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelTransaction.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelTransaction.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelTransaction.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelTransaction.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelTransaction.Controls.Add(this.lblEffectiveDate, 4, 0);
            this.tableLayoutPanelTransaction.Controls.Add(this.lblTransactionDescription, 3, 0);
            this.tableLayoutPanelTransaction.Controls.Add(this.lblTransactionAmount, 1, 0);
            this.tableLayoutPanelTransaction.Controls.Add(this.tbxTransactionDescription, 3, 1);
            this.tableLayoutPanelTransaction.Controls.Add(this.tbxTransactionAmount, 1, 1);
            this.tableLayoutPanelTransaction.Controls.Add(this.lblTransactionName, 2, 0);
            this.tableLayoutPanelTransaction.Controls.Add(this.lblTransactionCategory, 0, 0);
            this.tableLayoutPanelTransaction.Controls.Add(this.comboBox1, 0, 1);
            this.tableLayoutPanelTransaction.Controls.Add(this.cbxTrackingAlert, 4, 1);
            this.tableLayoutPanelTransaction.Controls.Add(this.tableLayoutPanel1, 2, 1);
            this.tableLayoutPanelTransaction.Location = new System.Drawing.Point(27, 63);
            this.tableLayoutPanelTransaction.Name = "tableLayoutPanelTransaction";
            this.tableLayoutPanelTransaction.RowCount = 2;
            this.tableLayoutPanelTransaction.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelTransaction.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelTransaction.Size = new System.Drawing.Size(631, 136);
            this.tableLayoutPanelTransaction.TabIndex = 12;
            // 
            // lblEffectiveDate
            // 
            this.lblEffectiveDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEffectiveDate.AutoSize = true;
            this.lblEffectiveDate.Location = new System.Drawing.Point(528, 25);
            this.lblEffectiveDate.Name = "lblEffectiveDate";
            this.lblEffectiveDate.Size = new System.Drawing.Size(78, 17);
            this.lblEffectiveDate.TabIndex = 17;
            this.lblEffectiveDate.Text = "Alert When";
            this.lblEffectiveDate.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblTransactionDescription
            // 
            this.lblTransactionDescription.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTransactionDescription.AutoSize = true;
            this.lblTransactionDescription.Location = new System.Drawing.Point(414, 25);
            this.lblTransactionDescription.Name = "lblTransactionDescription";
            this.lblTransactionDescription.Size = new System.Drawing.Size(54, 17);
            this.lblTransactionDescription.TabIndex = 16;
            this.lblTransactionDescription.Text = "Repeat";
            this.lblTransactionDescription.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblTransactionAmount
            // 
            this.lblTransactionAmount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTransactionAmount.AutoSize = true;
            this.lblTransactionAmount.Location = new System.Drawing.Point(133, 25);
            this.lblTransactionAmount.Name = "lblTransactionAmount";
            this.lblTransactionAmount.Size = new System.Drawing.Size(112, 17);
            this.lblTransactionAmount.TabIndex = 14;
            this.lblTransactionAmount.Text = "Allocated Money";
            this.lblTransactionAmount.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tbxTransactionDescription
            // 
            this.tbxTransactionDescription.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbxTransactionDescription.Location = new System.Drawing.Point(394, 90);
            this.tbxTransactionDescription.Name = "tbxTransactionDescription";
            this.tbxTransactionDescription.Size = new System.Drawing.Size(94, 23);
            this.tbxTransactionDescription.TabIndex = 23;
            // 
            // tbxTransactionAmount
            // 
            this.tbxTransactionAmount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbxTransactionAmount.Location = new System.Drawing.Point(142, 90);
            this.tbxTransactionAmount.Name = "tbxTransactionAmount";
            this.tbxTransactionAmount.Size = new System.Drawing.Size(94, 23);
            this.tbxTransactionAmount.TabIndex = 22;
            // 
            // lblTransactionName
            // 
            this.lblTransactionName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTransactionName.AutoSize = true;
            this.lblTransactionName.Location = new System.Drawing.Point(279, 17);
            this.lblTransactionName.Name = "lblTransactionName";
            this.lblTransactionName.Size = new System.Drawing.Size(72, 34);
            this.lblTransactionName.TabIndex = 13;
            this.lblTransactionName.Text = "Duration (From-To)";
            this.lblTransactionName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblTransactionCategory
            // 
            this.lblTransactionCategory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTransactionCategory.AutoSize = true;
            this.lblTransactionCategory.Location = new System.Drawing.Point(31, 25);
            this.lblTransactionCategory.Name = "lblTransactionCategory";
            this.lblTransactionCategory.Size = new System.Drawing.Size(65, 17);
            this.lblTransactionCategory.TabIndex = 15;
            this.lblTransactionCategory.Text = "Category";
            this.lblTransactionCategory.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(16, 91);
            this.comboBox1.MaxDropDownItems = 2;
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(94, 24);
            this.comboBox1.TabIndex = 26;
            // 
            // cbxTrackingAlert
            // 
            this.cbxTrackingAlert.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbxTrackingAlert.FormattingEnabled = true;
            this.cbxTrackingAlert.Items.AddRange(new object[] {
            "Exceeded",
            "In Range"});
            this.cbxTrackingAlert.Location = new System.Drawing.Point(520, 91);
            this.cbxTrackingAlert.MaxDropDownItems = 2;
            this.cbxTrackingAlert.Name = "cbxTrackingAlert";
            this.cbxTrackingAlert.Size = new System.Drawing.Size(94, 24);
            this.cbxTrackingAlert.TabIndex = 26;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.dateTimePicker1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dateTimePickereTransactionEffectiveDate, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(256, 71);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(119, 57);
            this.tableLayoutPanel1.TabIndex = 27;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(14, 31);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(90, 23);
            this.dateTimePicker1.TabIndex = 15;
            // 
            // dateTimePickereTransactionEffectiveDate
            // 
            this.dateTimePickereTransactionEffectiveDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePickereTransactionEffectiveDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dateTimePickereTransactionEffectiveDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickereTransactionEffectiveDate.Location = new System.Drawing.Point(14, 3);
            this.dateTimePickereTransactionEffectiveDate.Name = "dateTimePickereTransactionEffectiveDate";
            this.dateTimePickereTransactionEffectiveDate.Size = new System.Drawing.Size(90, 23);
            this.dateTimePickereTransactionEffectiveDate.TabIndex = 14;
            // 
            // btnStartTracking
            // 
            this.btnStartTracking.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStartTracking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(153)))), ((int)(((byte)(93)))));
            this.btnStartTracking.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStartTracking.FlatAppearance.BorderSize = 0;
            this.btnStartTracking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartTracking.ForeColor = System.Drawing.Color.White;
            this.btnStartTracking.Location = new System.Drawing.Point(546, 221);
            this.btnStartTracking.Margin = new System.Windows.Forms.Padding(4);
            this.btnStartTracking.Name = "btnStartTracking";
            this.btnStartTracking.Size = new System.Drawing.Size(112, 28);
            this.btnStartTracking.TabIndex = 5;
            this.btnStartTracking.Text = "Start Tracking";
            this.btnStartTracking.UseVisualStyleBackColor = false;
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
            this.btnChildFormClose.TabIndex = 5;
            this.btnChildFormClose.Text = "X";
            this.btnChildFormClose.UseVisualStyleBackColor = false;
            this.btnChildFormClose.Click += new System.EventHandler(this.btnChildFormClose_Click);
            // 
            // gbxCurrentlyTracking
            // 
            this.gbxCurrentlyTracking.Controls.Add(this.dgwCurrentlyTracking);
            this.gbxCurrentlyTracking.Controls.Add(this.button1);
            this.gbxCurrentlyTracking.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbxCurrentlyTracking.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(153)))), ((int)(((byte)(93)))));
            this.gbxCurrentlyTracking.Location = new System.Drawing.Point(0, 356);
            this.gbxCurrentlyTracking.Name = "gbxCurrentlyTracking";
            this.gbxCurrentlyTracking.Size = new System.Drawing.Size(684, 393);
            this.gbxCurrentlyTracking.TabIndex = 13;
            this.gbxCurrentlyTracking.TabStop = false;
            this.gbxCurrentlyTracking.Text = "Currently Tracking";
            // 
            // dgwCurrentlyTracking
            // 
            this.dgwCurrentlyTracking.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgwCurrentlyTracking.BackgroundColor = System.Drawing.Color.White;
            this.dgwCurrentlyTracking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwCurrentlyTracking.Location = new System.Drawing.Point(27, 45);
            this.dgwCurrentlyTracking.Margin = new System.Windows.Forms.Padding(4);
            this.dgwCurrentlyTracking.Name = "dgwCurrentlyTracking";
            this.dgwCurrentlyTracking.Size = new System.Drawing.Size(631, 290);
            this.dgwCurrentlyTracking.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(153)))), ((int)(((byte)(93)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(549, 352);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 28);
            this.button1.TabIndex = 5;
            this.button1.Text = "Stop Tracking";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // PlannerPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(684, 749);
            this.Controls.Add(this.gbxCurrentlyTracking);
            this.Controls.Add(this.gbxStartTracking);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PlannerPage";
            this.Text = "PlannerPage";
            this.gbxStartTracking.ResumeLayout(false);
            this.tableLayoutPanelTransaction.ResumeLayout(false);
            this.tableLayoutPanelTransaction.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.gbxCurrentlyTracking.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwCurrentlyTracking)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxStartTracking;
        private System.Windows.Forms.Button btnChildFormClose;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelTransaction;
        private System.Windows.Forms.Label lblEffectiveDate;
        private System.Windows.Forms.Label lblTransactionDescription;
        private System.Windows.Forms.Label lblTransactionCategory;
        private System.Windows.Forms.Label lblTransactionAmount;
        private System.Windows.Forms.Label lblTransactionName;
        private System.Windows.Forms.TextBox tbxTransactionDescription;
        private System.Windows.Forms.TextBox tbxTransactionAmount;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox cbxTrackingAlert;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePickereTransactionEffectiveDate;
        private System.Windows.Forms.Button btnStartTracking;
        private System.Windows.Forms.GroupBox gbxCurrentlyTracking;
        private System.Windows.Forms.DataGridView dgwCurrentlyTracking;
        private System.Windows.Forms.Button button1;
    }
}