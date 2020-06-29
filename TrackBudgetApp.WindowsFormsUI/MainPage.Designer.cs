namespace TrackBudgetApp.WindowsFormsUI
{
    partial class MainPage
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
            this.tableLayoutPanelTransaction = new System.Windows.Forms.TableLayoutPanel();
            this.dateTimePickerTransactionEffectiveDate = new System.Windows.Forms.DateTimePicker();
            this.lblTransactionRepeat = new System.Windows.Forms.Label();
            this.lblEffectiveDate = new System.Windows.Forms.Label();
            this.lblTransactionDescription = new System.Windows.Forms.Label();
            this.lblTransactionCategory = new System.Windows.Forms.Label();
            this.lblTransactionAmount = new System.Windows.Forms.Label();
            this.lblTransactionName = new System.Windows.Forms.Label();
            this.tbxTransactionName = new System.Windows.Forms.TextBox();
            this.tbxTransactionRepeat = new System.Windows.Forms.TextBox();
            this.tbxTransactionDescription = new System.Windows.Forms.TextBox();
            this.tbxTransactionAmount = new System.Windows.Forms.TextBox();
            this.lblTransactionOutcomeIncome = new System.Windows.Forms.Label();
            this.cbxTransactionOutcomeIncome = new System.Windows.Forms.ComboBox();
            this.cbxTransactionCategory = new System.Windows.Forms.ComboBox();
            this.lblCurrentBudgetTop = new System.Windows.Forms.Label();
            this.lblCurrentSavings = new System.Windows.Forms.Label();
            this.tableLayoutPanelMainBudget = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCurrentBudgetNow = new System.Windows.Forms.Label();
            this.tableLayoutPanelCurrentSavings = new System.Windows.Forms.TableLayoutPanel();
            this.dateTimePickerCurrentSavingsAfterDate = new System.Windows.Forms.DateTimePicker();
            this.lblCurrentSavingsAfterDate = new System.Windows.Forms.Label();
            this.tableLayoutPanelCurrentBudget = new System.Windows.Forms.TableLayoutPanel();
            this.dateTimePickerCurrentBudgetAfterDate = new System.Windows.Forms.DateTimePicker();
            this.lblCurrentBudgetAfterDate = new System.Windows.Forms.Label();
            this.btnTransactionSubmit = new System.Windows.Forms.Button();
            this.dgwTransactionsOutcome = new System.Windows.Forms.DataGridView();
            this.dgwTransactionsIncome = new System.Windows.Forms.DataGridView();
            this.dgwSavingsIncome = new System.Windows.Forms.DataGridView();
            this.dgwSavingsOutcome = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTransactionsOutcomeGrid = new System.Windows.Forms.Label();
            this.lblTransactionsIncomeGrid = new System.Windows.Forms.Label();
            this.lblSavingsOutcomeGrid = new System.Windows.Forms.Label();
            this.lblSavingsIncomeGrid = new System.Windows.Forms.Label();
            this.gbxLoggedInUser = new System.Windows.Forms.GroupBox();
            this.lblLoggedInUserValue = new System.Windows.Forms.Label();
            this.lblViewingLoggedInUser = new System.Windows.Forms.Label();
            this.tableLayoutPanelTransaction.SuspendLayout();
            this.tableLayoutPanelMainBudget.SuspendLayout();
            this.tableLayoutPanelCurrentSavings.SuspendLayout();
            this.tableLayoutPanelCurrentBudget.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwTransactionsOutcome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwTransactionsIncome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwSavingsIncome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwSavingsOutcome)).BeginInit();
            this.gbxLoggedInUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnChildFormClose
            // 
            this.btnChildFormClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(153)))), ((int)(((byte)(93)))));
            this.btnChildFormClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChildFormClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChildFormClose.ForeColor = System.Drawing.Color.White;
            this.btnChildFormClose.Location = new System.Drawing.Point(16, 15);
            this.btnChildFormClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnChildFormClose.Name = "btnChildFormClose";
            this.btnChildFormClose.Size = new System.Drawing.Size(100, 28);
            this.btnChildFormClose.TabIndex = 2;
            this.btnChildFormClose.Text = "X";
            this.btnChildFormClose.UseVisualStyleBackColor = false;
            this.btnChildFormClose.Click += new System.EventHandler(this.btnChildFormClose_Click);
            // 
            // tableLayoutPanelTransaction
            // 
            this.tableLayoutPanelTransaction.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelTransaction.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanelTransaction.ColumnCount = 7;
            this.tableLayoutPanelTransaction.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28531F));
            this.tableLayoutPanelTransaction.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28531F));
            this.tableLayoutPanelTransaction.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28531F));
            this.tableLayoutPanelTransaction.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28531F));
            this.tableLayoutPanelTransaction.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28531F));
            this.tableLayoutPanelTransaction.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28531F));
            this.tableLayoutPanelTransaction.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28816F));
            this.tableLayoutPanelTransaction.Controls.Add(this.dateTimePickerTransactionEffectiveDate, 4, 1);
            this.tableLayoutPanelTransaction.Controls.Add(this.lblTransactionRepeat, 5, 0);
            this.tableLayoutPanelTransaction.Controls.Add(this.lblEffectiveDate, 4, 0);
            this.tableLayoutPanelTransaction.Controls.Add(this.lblTransactionDescription, 3, 0);
            this.tableLayoutPanelTransaction.Controls.Add(this.lblTransactionCategory, 2, 0);
            this.tableLayoutPanelTransaction.Controls.Add(this.lblTransactionAmount, 1, 0);
            this.tableLayoutPanelTransaction.Controls.Add(this.lblTransactionName, 0, 0);
            this.tableLayoutPanelTransaction.Controls.Add(this.tbxTransactionName, 0, 1);
            this.tableLayoutPanelTransaction.Controls.Add(this.tbxTransactionRepeat, 5, 1);
            this.tableLayoutPanelTransaction.Controls.Add(this.tbxTransactionDescription, 3, 1);
            this.tableLayoutPanelTransaction.Controls.Add(this.tbxTransactionAmount, 1, 1);
            this.tableLayoutPanelTransaction.Controls.Add(this.lblTransactionOutcomeIncome, 6, 0);
            this.tableLayoutPanelTransaction.Controls.Add(this.cbxTransactionOutcomeIncome, 6, 1);
            this.tableLayoutPanelTransaction.Controls.Add(this.cbxTransactionCategory, 2, 1);
            this.tableLayoutPanelTransaction.Location = new System.Drawing.Point(26, 229);
            this.tableLayoutPanelTransaction.Name = "tableLayoutPanelTransaction";
            this.tableLayoutPanelTransaction.RowCount = 2;
            this.tableLayoutPanelTransaction.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelTransaction.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelTransaction.Size = new System.Drawing.Size(631, 78);
            this.tableLayoutPanelTransaction.TabIndex = 11;
            // 
            // dateTimePickerTransactionEffectiveDate
            // 
            this.dateTimePickerTransactionEffectiveDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePickerTransactionEffectiveDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dateTimePickerTransactionEffectiveDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerTransactionEffectiveDate.Location = new System.Drawing.Point(362, 46);
            this.dateTimePickerTransactionEffectiveDate.Name = "dateTimePickerTransactionEffectiveDate";
            this.dateTimePickerTransactionEffectiveDate.Size = new System.Drawing.Size(77, 23);
            this.dateTimePickerTransactionEffectiveDate.TabIndex = 13;
            // 
            // lblTransactionRepeat
            // 
            this.lblTransactionRepeat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTransactionRepeat.AutoSize = true;
            this.lblTransactionRepeat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTransactionRepeat.Location = new System.Drawing.Point(449, 2);
            this.lblTransactionRepeat.Name = "lblTransactionRepeat";
            this.lblTransactionRepeat.Size = new System.Drawing.Size(82, 34);
            this.lblTransactionRepeat.TabIndex = 18;
            this.lblTransactionRepeat.Text = "Repeat Every XDay";
            this.lblTransactionRepeat.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblEffectiveDate
            // 
            this.lblEffectiveDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEffectiveDate.AutoSize = true;
            this.lblEffectiveDate.Location = new System.Drawing.Point(370, 2);
            this.lblEffectiveDate.Name = "lblEffectiveDate";
            this.lblEffectiveDate.Size = new System.Drawing.Size(62, 34);
            this.lblEffectiveDate.TabIndex = 17;
            this.lblEffectiveDate.Text = "Effective Date";
            this.lblEffectiveDate.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblTransactionDescription
            // 
            this.lblTransactionDescription.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTransactionDescription.AutoSize = true;
            this.lblTransactionDescription.Location = new System.Drawing.Point(272, 2);
            this.lblTransactionDescription.Name = "lblTransactionDescription";
            this.lblTransactionDescription.Size = new System.Drawing.Size(79, 34);
            this.lblTransactionDescription.TabIndex = 16;
            this.lblTransactionDescription.Text = "Description (opt)";
            this.lblTransactionDescription.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblTransactionCategory
            // 
            this.lblTransactionCategory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTransactionCategory.AutoSize = true;
            this.lblTransactionCategory.Location = new System.Drawing.Point(190, 11);
            this.lblTransactionCategory.Name = "lblTransactionCategory";
            this.lblTransactionCategory.Size = new System.Drawing.Size(65, 17);
            this.lblTransactionCategory.TabIndex = 15;
            this.lblTransactionCategory.Text = "Category";
            this.lblTransactionCategory.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblTransactionAmount
            // 
            this.lblTransactionAmount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTransactionAmount.AutoSize = true;
            this.lblTransactionAmount.Location = new System.Drawing.Point(106, 11);
            this.lblTransactionAmount.Name = "lblTransactionAmount";
            this.lblTransactionAmount.Size = new System.Drawing.Size(56, 17);
            this.lblTransactionAmount.TabIndex = 14;
            this.lblTransactionAmount.Text = "Amount";
            this.lblTransactionAmount.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblTransactionName
            // 
            this.lblTransactionName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTransactionName.AutoSize = true;
            this.lblTransactionName.Location = new System.Drawing.Point(22, 11);
            this.lblTransactionName.Name = "lblTransactionName";
            this.lblTransactionName.Size = new System.Drawing.Size(45, 17);
            this.lblTransactionName.TabIndex = 13;
            this.lblTransactionName.Text = "Name";
            this.lblTransactionName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tbxTransactionName
            // 
            this.tbxTransactionName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbxTransactionName.Location = new System.Drawing.Point(8, 46);
            this.tbxTransactionName.Name = "tbxTransactionName";
            this.tbxTransactionName.Size = new System.Drawing.Size(74, 23);
            this.tbxTransactionName.TabIndex = 20;
            // 
            // tbxTransactionRepeat
            // 
            this.tbxTransactionRepeat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbxTransactionRepeat.Location = new System.Drawing.Point(453, 46);
            this.tbxTransactionRepeat.Name = "tbxTransactionRepeat";
            this.tbxTransactionRepeat.Size = new System.Drawing.Size(74, 23);
            this.tbxTransactionRepeat.TabIndex = 24;
            // 
            // tbxTransactionDescription
            // 
            this.tbxTransactionDescription.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbxTransactionDescription.Location = new System.Drawing.Point(275, 46);
            this.tbxTransactionDescription.Name = "tbxTransactionDescription";
            this.tbxTransactionDescription.Size = new System.Drawing.Size(74, 23);
            this.tbxTransactionDescription.TabIndex = 23;
            // 
            // tbxTransactionAmount
            // 
            this.tbxTransactionAmount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbxTransactionAmount.Location = new System.Drawing.Point(97, 46);
            this.tbxTransactionAmount.Name = "tbxTransactionAmount";
            this.tbxTransactionAmount.Size = new System.Drawing.Size(74, 23);
            this.tbxTransactionAmount.TabIndex = 22;
            // 
            // lblTransactionOutcomeIncome
            // 
            this.lblTransactionOutcomeIncome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTransactionOutcomeIncome.AutoSize = true;
            this.lblTransactionOutcomeIncome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTransactionOutcomeIncome.Location = new System.Drawing.Point(546, 2);
            this.lblTransactionOutcomeIncome.Name = "lblTransactionOutcomeIncome";
            this.lblTransactionOutcomeIncome.Size = new System.Drawing.Size(73, 34);
            this.lblTransactionOutcomeIncome.TabIndex = 18;
            this.lblTransactionOutcomeIncome.Text = "Outcome / Income";
            this.lblTransactionOutcomeIncome.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cbxTransactionOutcomeIncome
            // 
            this.cbxTransactionOutcomeIncome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbxTransactionOutcomeIncome.FormattingEnabled = true;
            this.cbxTransactionOutcomeIncome.Items.AddRange(new object[] {
            "-",
            "+"});
            this.cbxTransactionOutcomeIncome.Location = new System.Drawing.Point(540, 47);
            this.cbxTransactionOutcomeIncome.MaxDropDownItems = 2;
            this.cbxTransactionOutcomeIncome.Name = "cbxTransactionOutcomeIncome";
            this.cbxTransactionOutcomeIncome.Size = new System.Drawing.Size(84, 24);
            this.cbxTransactionOutcomeIncome.TabIndex = 26;
            // 
            // cbxTransactionCategory
            // 
            this.cbxTransactionCategory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbxTransactionCategory.FormattingEnabled = true;
            this.cbxTransactionCategory.Items.AddRange(new object[] {
            "-",
            "+"});
            this.cbxTransactionCategory.Location = new System.Drawing.Point(182, 46);
            this.cbxTransactionCategory.MaxDropDownItems = 2;
            this.cbxTransactionCategory.Name = "cbxTransactionCategory";
            this.cbxTransactionCategory.Size = new System.Drawing.Size(82, 24);
            this.cbxTransactionCategory.TabIndex = 26;
            // 
            // lblCurrentBudgetTop
            // 
            this.lblCurrentBudgetTop.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCurrentBudgetTop.AutoSize = true;
            this.lblCurrentBudgetTop.Location = new System.Drawing.Point(9, 24);
            this.lblCurrentBudgetTop.Name = "lblCurrentBudgetTop";
            this.lblCurrentBudgetTop.Size = new System.Drawing.Size(104, 17);
            this.lblCurrentBudgetTop.TabIndex = 13;
            this.lblCurrentBudgetTop.Text = "Current Budget";
            this.lblCurrentBudgetTop.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblCurrentSavings
            // 
            this.lblCurrentSavings.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCurrentSavings.AutoSize = true;
            this.lblCurrentSavings.Location = new System.Drawing.Point(251, 24);
            this.lblCurrentSavings.Name = "lblCurrentSavings";
            this.lblCurrentSavings.Size = new System.Drawing.Size(109, 17);
            this.lblCurrentSavings.TabIndex = 15;
            this.lblCurrentSavings.Text = "Current Savings";
            this.lblCurrentSavings.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tableLayoutPanelMainBudget
            // 
            this.tableLayoutPanelMainBudget.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelMainBudget.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanelMainBudget.ColumnCount = 4;
            this.tableLayoutPanelMainBudget.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelMainBudget.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelMainBudget.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelMainBudget.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelMainBudget.Controls.Add(this.label4, 3, 1);
            this.tableLayoutPanelMainBudget.Controls.Add(this.label3, 2, 1);
            this.tableLayoutPanelMainBudget.Controls.Add(this.label2, 1, 1);
            this.tableLayoutPanelMainBudget.Controls.Add(this.lblCurrentBudgetNow, 0, 1);
            this.tableLayoutPanelMainBudget.Controls.Add(this.tableLayoutPanelCurrentSavings, 3, 0);
            this.tableLayoutPanelMainBudget.Controls.Add(this.tableLayoutPanelCurrentBudget, 1, 0);
            this.tableLayoutPanelMainBudget.Controls.Add(this.lblCurrentSavings, 2, 0);
            this.tableLayoutPanelMainBudget.Controls.Add(this.lblCurrentBudgetTop, 0, 0);
            this.tableLayoutPanelMainBudget.Location = new System.Drawing.Point(97, 75);
            this.tableLayoutPanelMainBudget.Name = "tableLayoutPanelMainBudget";
            this.tableLayoutPanelMainBudget.RowCount = 2;
            this.tableLayoutPanelMainBudget.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelMainBudget.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelMainBudget.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelMainBudget.Size = new System.Drawing.Size(491, 129);
            this.tableLayoutPanelMainBudget.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(153)))), ((int)(((byte)(93)))));
            this.label4.Location = new System.Drawing.Point(408, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 24);
            this.label4.TabIndex = 19;
            this.label4.Text = "246";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(153)))), ((int)(((byte)(93)))));
            this.label3.Location = new System.Drawing.Point(285, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 24);
            this.label3.TabIndex = 18;
            this.label3.Text = "121";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(153)))), ((int)(((byte)(93)))));
            this.label2.Location = new System.Drawing.Point(163, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 24);
            this.label2.TabIndex = 17;
            this.label2.Text = "322";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblCurrentBudgetNow
            // 
            this.lblCurrentBudgetNow.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCurrentBudgetNow.AutoSize = true;
            this.lblCurrentBudgetNow.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblCurrentBudgetNow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(153)))), ((int)(((byte)(93)))));
            this.lblCurrentBudgetNow.Location = new System.Drawing.Point(41, 84);
            this.lblCurrentBudgetNow.Name = "lblCurrentBudgetNow";
            this.lblCurrentBudgetNow.Size = new System.Drawing.Size(40, 24);
            this.lblCurrentBudgetNow.TabIndex = 16;
            this.lblCurrentBudgetNow.Text = "787";
            this.lblCurrentBudgetNow.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tableLayoutPanelCurrentSavings
            // 
            this.tableLayoutPanelCurrentSavings.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanelCurrentSavings.ColumnCount = 1;
            this.tableLayoutPanelCurrentSavings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelCurrentSavings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelCurrentSavings.Controls.Add(this.dateTimePickerCurrentSavingsAfterDate, 0, 1);
            this.tableLayoutPanelCurrentSavings.Controls.Add(this.lblCurrentSavingsAfterDate, 0, 0);
            this.tableLayoutPanelCurrentSavings.Location = new System.Drawing.Point(370, 4);
            this.tableLayoutPanelCurrentSavings.Name = "tableLayoutPanelCurrentSavings";
            this.tableLayoutPanelCurrentSavings.RowCount = 2;
            this.tableLayoutPanelCurrentSavings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelCurrentSavings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelCurrentSavings.Size = new System.Drawing.Size(117, 57);
            this.tableLayoutPanelCurrentSavings.TabIndex = 12;
            // 
            // dateTimePickerCurrentSavingsAfterDate
            // 
            this.dateTimePickerCurrentSavingsAfterDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePickerCurrentSavingsAfterDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dateTimePickerCurrentSavingsAfterDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerCurrentSavingsAfterDate.Location = new System.Drawing.Point(15, 31);
            this.dateTimePickerCurrentSavingsAfterDate.Name = "dateTimePickerCurrentSavingsAfterDate";
            this.dateTimePickerCurrentSavingsAfterDate.Size = new System.Drawing.Size(87, 23);
            this.dateTimePickerCurrentSavingsAfterDate.TabIndex = 13;
            // 
            // lblCurrentSavingsAfterDate
            // 
            this.lblCurrentSavingsAfterDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCurrentSavingsAfterDate.AutoSize = true;
            this.lblCurrentSavingsAfterDate.Location = new System.Drawing.Point(22, 5);
            this.lblCurrentSavingsAfterDate.Name = "lblCurrentSavingsAfterDate";
            this.lblCurrentSavingsAfterDate.Size = new System.Drawing.Size(72, 17);
            this.lblCurrentSavingsAfterDate.TabIndex = 26;
            this.lblCurrentSavingsAfterDate.Text = "After Date";
            this.lblCurrentSavingsAfterDate.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tableLayoutPanelCurrentBudget
            // 
            this.tableLayoutPanelCurrentBudget.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanelCurrentBudget.ColumnCount = 1;
            this.tableLayoutPanelCurrentBudget.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelCurrentBudget.Controls.Add(this.dateTimePickerCurrentBudgetAfterDate, 0, 1);
            this.tableLayoutPanelCurrentBudget.Controls.Add(this.lblCurrentBudgetAfterDate, 0, 0);
            this.tableLayoutPanelCurrentBudget.Location = new System.Drawing.Point(126, 4);
            this.tableLayoutPanelCurrentBudget.Name = "tableLayoutPanelCurrentBudget";
            this.tableLayoutPanelCurrentBudget.RowCount = 2;
            this.tableLayoutPanelCurrentBudget.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelCurrentBudget.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelCurrentBudget.Size = new System.Drawing.Size(115, 57);
            this.tableLayoutPanelCurrentBudget.TabIndex = 12;
            // 
            // dateTimePickerCurrentBudgetAfterDate
            // 
            this.dateTimePickerCurrentBudgetAfterDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePickerCurrentBudgetAfterDate.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(153)))), ((int)(((byte)(93)))));
            this.dateTimePickerCurrentBudgetAfterDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dateTimePickerCurrentBudgetAfterDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerCurrentBudgetAfterDate.Location = new System.Drawing.Point(14, 31);
            this.dateTimePickerCurrentBudgetAfterDate.Name = "dateTimePickerCurrentBudgetAfterDate";
            this.dateTimePickerCurrentBudgetAfterDate.Size = new System.Drawing.Size(87, 23);
            this.dateTimePickerCurrentBudgetAfterDate.TabIndex = 13;
            // 
            // lblCurrentBudgetAfterDate
            // 
            this.lblCurrentBudgetAfterDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCurrentBudgetAfterDate.AutoSize = true;
            this.lblCurrentBudgetAfterDate.Location = new System.Drawing.Point(21, 5);
            this.lblCurrentBudgetAfterDate.Name = "lblCurrentBudgetAfterDate";
            this.lblCurrentBudgetAfterDate.Size = new System.Drawing.Size(72, 17);
            this.lblCurrentBudgetAfterDate.TabIndex = 26;
            this.lblCurrentBudgetAfterDate.Text = "After Date";
            this.lblCurrentBudgetAfterDate.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnTransactionSubmit
            // 
            this.btnTransactionSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTransactionSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(153)))), ((int)(((byte)(93)))));
            this.btnTransactionSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTransactionSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransactionSubmit.ForeColor = System.Drawing.Color.White;
            this.btnTransactionSubmit.Location = new System.Drawing.Point(557, 324);
            this.btnTransactionSubmit.Margin = new System.Windows.Forms.Padding(4);
            this.btnTransactionSubmit.Name = "btnTransactionSubmit";
            this.btnTransactionSubmit.Size = new System.Drawing.Size(100, 28);
            this.btnTransactionSubmit.TabIndex = 2;
            this.btnTransactionSubmit.Text = "Submit";
            this.btnTransactionSubmit.UseVisualStyleBackColor = false;
            this.btnTransactionSubmit.Click += new System.EventHandler(this.btnChildFormClose_Click);
            // 
            // dgwTransactionsOutcome
            // 
            this.dgwTransactionsOutcome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dgwTransactionsOutcome.BackgroundColor = System.Drawing.Color.White;
            this.dgwTransactionsOutcome.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwTransactionsOutcome.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(153)))), ((int)(((byte)(93)))));
            this.dgwTransactionsOutcome.Location = new System.Drawing.Point(37, 392);
            this.dgwTransactionsOutcome.Name = "dgwTransactionsOutcome";
            this.dgwTransactionsOutcome.Size = new System.Drawing.Size(284, 150);
            this.dgwTransactionsOutcome.TabIndex = 12;
            // 
            // dgwTransactionsIncome
            // 
            this.dgwTransactionsIncome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dgwTransactionsIncome.BackgroundColor = System.Drawing.Color.White;
            this.dgwTransactionsIncome.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwTransactionsIncome.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(153)))), ((int)(((byte)(93)))));
            this.dgwTransactionsIncome.Location = new System.Drawing.Point(360, 392);
            this.dgwTransactionsIncome.Name = "dgwTransactionsIncome";
            this.dgwTransactionsIncome.Size = new System.Drawing.Size(274, 150);
            this.dgwTransactionsIncome.TabIndex = 13;
            // 
            // dgwSavingsIncome
            // 
            this.dgwSavingsIncome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dgwSavingsIncome.BackgroundColor = System.Drawing.Color.White;
            this.dgwSavingsIncome.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwSavingsIncome.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(153)))), ((int)(((byte)(93)))));
            this.dgwSavingsIncome.Location = new System.Drawing.Point(360, 581);
            this.dgwSavingsIncome.Name = "dgwSavingsIncome";
            this.dgwSavingsIncome.Size = new System.Drawing.Size(274, 150);
            this.dgwSavingsIncome.TabIndex = 15;
            // 
            // dgwSavingsOutcome
            // 
            this.dgwSavingsOutcome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dgwSavingsOutcome.BackgroundColor = System.Drawing.Color.White;
            this.dgwSavingsOutcome.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwSavingsOutcome.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(153)))), ((int)(((byte)(93)))));
            this.dgwSavingsOutcome.Location = new System.Drawing.Point(38, 581);
            this.dgwSavingsOutcome.Name = "dgwSavingsOutcome";
            this.dgwSavingsOutcome.Size = new System.Drawing.Size(283, 150);
            this.dgwSavingsOutcome.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(311, 726);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 17);
            this.label5.TabIndex = 16;
            // 
            // lblTransactionsOutcomeGrid
            // 
            this.lblTransactionsOutcomeGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblTransactionsOutcomeGrid.AutoSize = true;
            this.lblTransactionsOutcomeGrid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(153)))), ((int)(((byte)(93)))));
            this.lblTransactionsOutcomeGrid.Location = new System.Drawing.Point(105, 372);
            this.lblTransactionsOutcomeGrid.Name = "lblTransactionsOutcomeGrid";
            this.lblTransactionsOutcomeGrid.Size = new System.Drawing.Size(151, 17);
            this.lblTransactionsOutcomeGrid.TabIndex = 17;
            this.lblTransactionsOutcomeGrid.Text = "Transactions Outcome";
            // 
            // lblTransactionsIncomeGrid
            // 
            this.lblTransactionsIncomeGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblTransactionsIncomeGrid.AutoSize = true;
            this.lblTransactionsIncomeGrid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(153)))), ((int)(((byte)(93)))));
            this.lblTransactionsIncomeGrid.Location = new System.Drawing.Point(428, 372);
            this.lblTransactionsIncomeGrid.Name = "lblTransactionsIncomeGrid";
            this.lblTransactionsIncomeGrid.Size = new System.Drawing.Size(139, 17);
            this.lblTransactionsIncomeGrid.TabIndex = 18;
            this.lblTransactionsIncomeGrid.Text = "Transactions Income";
            // 
            // lblSavingsOutcomeGrid
            // 
            this.lblSavingsOutcomeGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblSavingsOutcomeGrid.AutoSize = true;
            this.lblSavingsOutcomeGrid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(153)))), ((int)(((byte)(93)))));
            this.lblSavingsOutcomeGrid.Location = new System.Drawing.Point(105, 561);
            this.lblSavingsOutcomeGrid.Name = "lblSavingsOutcomeGrid";
            this.lblSavingsOutcomeGrid.Size = new System.Drawing.Size(119, 17);
            this.lblSavingsOutcomeGrid.TabIndex = 19;
            this.lblSavingsOutcomeGrid.Text = "Savings Outcome";
            // 
            // lblSavingsIncomeGrid
            // 
            this.lblSavingsIncomeGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblSavingsIncomeGrid.AutoSize = true;
            this.lblSavingsIncomeGrid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(153)))), ((int)(((byte)(93)))));
            this.lblSavingsIncomeGrid.Location = new System.Drawing.Point(438, 561);
            this.lblSavingsIncomeGrid.Name = "lblSavingsIncomeGrid";
            this.lblSavingsIncomeGrid.Size = new System.Drawing.Size(107, 17);
            this.lblSavingsIncomeGrid.TabIndex = 20;
            this.lblSavingsIncomeGrid.Text = "Savings Income";
            // 
            // gbxLoggedInUser
            // 
            this.gbxLoggedInUser.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gbxLoggedInUser.Controls.Add(this.lblLoggedInUserValue);
            this.gbxLoggedInUser.Controls.Add(this.lblViewingLoggedInUser);
            this.gbxLoggedInUser.Location = new System.Drawing.Point(275, 15);
            this.gbxLoggedInUser.Name = "gbxLoggedInUser";
            this.gbxLoggedInUser.Size = new System.Drawing.Size(147, 42);
            this.gbxLoggedInUser.TabIndex = 37;
            this.gbxLoggedInUser.TabStop = false;
            // 
            // lblLoggedInUserValue
            // 
            this.lblLoggedInUserValue.AutoSize = true;
            this.lblLoggedInUserValue.Location = new System.Drawing.Point(72, 16);
            this.lblLoggedInUserValue.Name = "lblLoggedInUserValue";
            this.lblLoggedInUserValue.Size = new System.Drawing.Size(69, 17);
            this.lblLoggedInUserValue.TabIndex = 35;
            this.lblLoggedInUserValue.Text = "Alex(Son)";
            this.lblLoggedInUserValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblViewingLoggedInUser
            // 
            this.lblViewingLoggedInUser.AutoSize = true;
            this.lblViewingLoggedInUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(153)))), ((int)(((byte)(93)))));
            this.lblViewingLoggedInUser.Location = new System.Drawing.Point(15, 16);
            this.lblViewingLoggedInUser.Name = "lblViewingLoggedInUser";
            this.lblViewingLoggedInUser.Size = new System.Drawing.Size(60, 17);
            this.lblViewingLoggedInUser.TabIndex = 34;
            this.lblViewingLoggedInUser.Text = "Viewing:";
            this.lblViewingLoggedInUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(684, 749);
            this.Controls.Add(this.gbxLoggedInUser);
            this.Controls.Add(this.lblSavingsIncomeGrid);
            this.Controls.Add(this.lblSavingsOutcomeGrid);
            this.Controls.Add(this.lblTransactionsIncomeGrid);
            this.Controls.Add(this.lblTransactionsOutcomeGrid);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgwSavingsIncome);
            this.Controls.Add(this.dgwSavingsOutcome);
            this.Controls.Add(this.dgwTransactionsIncome);
            this.Controls.Add(this.dgwTransactionsOutcome);
            this.Controls.Add(this.tableLayoutPanelMainBudget);
            this.Controls.Add(this.tableLayoutPanelTransaction);
            this.Controls.Add(this.btnTransactionSubmit);
            this.Controls.Add(this.btnChildFormClose);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainPage";
            this.Text = "Main Page";
            this.Load += new System.EventHandler(this.MainPage_Load);
            this.tableLayoutPanelTransaction.ResumeLayout(false);
            this.tableLayoutPanelTransaction.PerformLayout();
            this.tableLayoutPanelMainBudget.ResumeLayout(false);
            this.tableLayoutPanelMainBudget.PerformLayout();
            this.tableLayoutPanelCurrentSavings.ResumeLayout(false);
            this.tableLayoutPanelCurrentSavings.PerformLayout();
            this.tableLayoutPanelCurrentBudget.ResumeLayout(false);
            this.tableLayoutPanelCurrentBudget.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwTransactionsOutcome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwTransactionsIncome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwSavingsIncome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwSavingsOutcome)).EndInit();
            this.gbxLoggedInUser.ResumeLayout(false);
            this.gbxLoggedInUser.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChildFormClose;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelTransaction;
        private System.Windows.Forms.Label lblTransactionRepeat;
        private System.Windows.Forms.Label lblEffectiveDate;
        private System.Windows.Forms.Label lblTransactionDescription;
        private System.Windows.Forms.Label lblTransactionCategory;
        private System.Windows.Forms.Label lblTransactionAmount;
        private System.Windows.Forms.Label lblTransactionName;
        private System.Windows.Forms.TextBox tbxTransactionName;
        private System.Windows.Forms.TextBox tbxTransactionAmount;
        private System.Windows.Forms.DateTimePicker dateTimePickerTransactionEffectiveDate;
        private System.Windows.Forms.TextBox tbxTransactionRepeat;
        private System.Windows.Forms.TextBox tbxTransactionDescription;
        private System.Windows.Forms.Label lblCurrentBudgetTop;
        private System.Windows.Forms.Label lblCurrentSavings;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMainBudget;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCurrentBudgetNow;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelCurrentSavings;
        private System.Windows.Forms.DateTimePicker dateTimePickerCurrentSavingsAfterDate;
        private System.Windows.Forms.Label lblCurrentSavingsAfterDate;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelCurrentBudget;
        private System.Windows.Forms.DateTimePicker dateTimePickerCurrentBudgetAfterDate;
        private System.Windows.Forms.Label lblCurrentBudgetAfterDate;
        private System.Windows.Forms.Label lblTransactionOutcomeIncome;
        private System.Windows.Forms.ComboBox cbxTransactionOutcomeIncome;
        private System.Windows.Forms.Button btnTransactionSubmit;
        private System.Windows.Forms.DataGridView dgwTransactionsOutcome;
        private System.Windows.Forms.DataGridView dgwTransactionsIncome;
        private System.Windows.Forms.DataGridView dgwSavingsIncome;
        private System.Windows.Forms.DataGridView dgwSavingsOutcome;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTransactionsOutcomeGrid;
        private System.Windows.Forms.Label lblTransactionsIncomeGrid;
        private System.Windows.Forms.Label lblSavingsOutcomeGrid;
        private System.Windows.Forms.Label lblSavingsIncomeGrid;
        private System.Windows.Forms.ComboBox cbxTransactionCategory;
        private System.Windows.Forms.GroupBox gbxLoggedInUser;
        private System.Windows.Forms.Label lblLoggedInUserValue;
        private System.Windows.Forms.Label lblViewingLoggedInUser;
    }
}