namespace TrackBudgetApp.WindowsFormsUI
{
    partial class FamilyMemberForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FamilyMemberForm));
            this.gbxFamilyMemberCurrentBudget = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanelMainBudget = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanelCurrentSavings = new System.Windows.Forms.TableLayoutPanel();
            this.dateTimePickerCurrentSavingsAfterDate = new System.Windows.Forms.DateTimePicker();
            this.lblCurrentSavingsAfterDate = new System.Windows.Forms.Label();
            this.tableLayoutPanelCurrentBudget = new System.Windows.Forms.TableLayoutPanel();
            this.dateTimePickerCurrentBudgetAfterDate = new System.Windows.Forms.DateTimePicker();
            this.lblCurrentBudgetAfterDate = new System.Windows.Forms.Label();
            this.lblCurrentSavings = new System.Windows.Forms.Label();
            this.lblCurrentBudgetTop = new System.Windows.Forms.Label();
            this.gbxViewFamilyMember = new System.Windows.Forms.GroupBox();
            this.lblFamilyMemberName = new System.Windows.Forms.Label();
            this.lblViewing = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgwSavingsOutcome = new System.Windows.Forms.DataGridView();
            this.gbxFamilyMemberTransactions = new System.Windows.Forms.GroupBox();
            this.dgwSavingsIncome = new System.Windows.Forms.DataGridView();
            this.lblSavingsOutcomeGrid = new System.Windows.Forms.Label();
            this.lblTransactionsIncomeGrid = new System.Windows.Forms.Label();
            this.lblTransactionsOutcomeGrid = new System.Windows.Forms.Label();
            this.dgwTransactionsIncome = new System.Windows.Forms.DataGridView();
            this.dgwTransactionsOutcome = new System.Windows.Forms.DataGridView();
            this.lblSavingsIncomeGrid = new System.Windows.Forms.Label();
            this.gbxFamilyMemberCurrentBudget.SuspendLayout();
            this.tableLayoutPanelMainBudget.SuspendLayout();
            this.tableLayoutPanelCurrentSavings.SuspendLayout();
            this.tableLayoutPanelCurrentBudget.SuspendLayout();
            this.gbxViewFamilyMember.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwSavingsOutcome)).BeginInit();
            this.gbxFamilyMemberTransactions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwSavingsIncome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwTransactionsIncome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwTransactionsOutcome)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxFamilyMemberCurrentBudget
            // 
            this.gbxFamilyMemberCurrentBudget.Controls.Add(this.tableLayoutPanelMainBudget);
            this.gbxFamilyMemberCurrentBudget.Controls.Add(this.gbxViewFamilyMember);
            this.gbxFamilyMemberCurrentBudget.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbxFamilyMemberCurrentBudget.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbxFamilyMemberCurrentBudget.Location = new System.Drawing.Point(0, 0);
            this.gbxFamilyMemberCurrentBudget.Name = "gbxFamilyMemberCurrentBudget";
            this.gbxFamilyMemberCurrentBudget.Size = new System.Drawing.Size(688, 237);
            this.gbxFamilyMemberCurrentBudget.TabIndex = 41;
            this.gbxFamilyMemberCurrentBudget.TabStop = false;
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
            this.tableLayoutPanelMainBudget.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanelMainBudget.Controls.Add(this.tableLayoutPanelCurrentSavings, 3, 0);
            this.tableLayoutPanelMainBudget.Controls.Add(this.tableLayoutPanelCurrentBudget, 1, 0);
            this.tableLayoutPanelMainBudget.Controls.Add(this.lblCurrentSavings, 2, 0);
            this.tableLayoutPanelMainBudget.Controls.Add(this.lblCurrentBudgetTop, 0, 0);
            this.tableLayoutPanelMainBudget.Location = new System.Drawing.Point(60, 67);
            this.tableLayoutPanelMainBudget.Name = "tableLayoutPanelMainBudget";
            this.tableLayoutPanelMainBudget.RowCount = 2;
            this.tableLayoutPanelMainBudget.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelMainBudget.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelMainBudget.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelMainBudget.Size = new System.Drawing.Size(592, 139);
            this.tableLayoutPanelMainBudget.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(153)))), ((int)(((byte)(93)))));
            this.label4.Location = new System.Drawing.Point(496, 92);
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
            this.label3.Location = new System.Drawing.Point(348, 92);
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
            this.label2.Location = new System.Drawing.Point(201, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 24);
            this.label2.TabIndex = 17;
            this.label2.Text = "322";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(153)))), ((int)(((byte)(93)))));
            this.label1.Location = new System.Drawing.Point(54, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 24);
            this.label1.TabIndex = 16;
            this.label1.Text = "787";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tableLayoutPanelCurrentSavings
            // 
            this.tableLayoutPanelCurrentSavings.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanelCurrentSavings.ColumnCount = 1;
            this.tableLayoutPanelCurrentSavings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelCurrentSavings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelCurrentSavings.Controls.Add(this.dateTimePickerCurrentSavingsAfterDate, 0, 1);
            this.tableLayoutPanelCurrentSavings.Controls.Add(this.lblCurrentSavingsAfterDate, 0, 0);
            this.tableLayoutPanelCurrentSavings.Location = new System.Drawing.Point(460, 5);
            this.tableLayoutPanelCurrentSavings.Name = "tableLayoutPanelCurrentSavings";
            this.tableLayoutPanelCurrentSavings.RowCount = 2;
            this.tableLayoutPanelCurrentSavings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelCurrentSavings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelCurrentSavings.Size = new System.Drawing.Size(112, 59);
            this.tableLayoutPanelCurrentSavings.TabIndex = 12;
            // 
            // dateTimePickerCurrentSavingsAfterDate
            // 
            this.dateTimePickerCurrentSavingsAfterDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePickerCurrentSavingsAfterDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dateTimePickerCurrentSavingsAfterDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerCurrentSavingsAfterDate.Location = new System.Drawing.Point(12, 32);
            this.dateTimePickerCurrentSavingsAfterDate.Name = "dateTimePickerCurrentSavingsAfterDate";
            this.dateTimePickerCurrentSavingsAfterDate.Size = new System.Drawing.Size(87, 23);
            this.dateTimePickerCurrentSavingsAfterDate.TabIndex = 13;
            // 
            // lblCurrentSavingsAfterDate
            // 
            this.lblCurrentSavingsAfterDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCurrentSavingsAfterDate.AutoSize = true;
            this.lblCurrentSavingsAfterDate.Location = new System.Drawing.Point(28, 8);
            this.lblCurrentSavingsAfterDate.Name = "lblCurrentSavingsAfterDate";
            this.lblCurrentSavingsAfterDate.Size = new System.Drawing.Size(55, 13);
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
            this.tableLayoutPanelCurrentBudget.Location = new System.Drawing.Point(165, 4);
            this.tableLayoutPanelCurrentBudget.Name = "tableLayoutPanelCurrentBudget";
            this.tableLayoutPanelCurrentBudget.RowCount = 2;
            this.tableLayoutPanelCurrentBudget.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelCurrentBudget.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelCurrentBudget.Size = new System.Drawing.Size(111, 61);
            this.tableLayoutPanelCurrentBudget.TabIndex = 12;
            // 
            // dateTimePickerCurrentBudgetAfterDate
            // 
            this.dateTimePickerCurrentBudgetAfterDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePickerCurrentBudgetAfterDate.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(153)))), ((int)(((byte)(93)))));
            this.dateTimePickerCurrentBudgetAfterDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dateTimePickerCurrentBudgetAfterDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerCurrentBudgetAfterDate.Location = new System.Drawing.Point(12, 34);
            this.dateTimePickerCurrentBudgetAfterDate.Name = "dateTimePickerCurrentBudgetAfterDate";
            this.dateTimePickerCurrentBudgetAfterDate.Size = new System.Drawing.Size(87, 23);
            this.dateTimePickerCurrentBudgetAfterDate.TabIndex = 13;
            // 
            // lblCurrentBudgetAfterDate
            // 
            this.lblCurrentBudgetAfterDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCurrentBudgetAfterDate.AutoSize = true;
            this.lblCurrentBudgetAfterDate.Location = new System.Drawing.Point(28, 8);
            this.lblCurrentBudgetAfterDate.Name = "lblCurrentBudgetAfterDate";
            this.lblCurrentBudgetAfterDate.Size = new System.Drawing.Size(55, 13);
            this.lblCurrentBudgetAfterDate.TabIndex = 26;
            this.lblCurrentBudgetAfterDate.Text = "After Date";
            this.lblCurrentBudgetAfterDate.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblCurrentSavings
            // 
            this.lblCurrentSavings.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCurrentSavings.AutoSize = true;
            this.lblCurrentSavings.Location = new System.Drawing.Point(327, 28);
            this.lblCurrentSavings.Name = "lblCurrentSavings";
            this.lblCurrentSavings.Size = new System.Drawing.Size(82, 13);
            this.lblCurrentSavings.TabIndex = 15;
            this.lblCurrentSavings.Text = "Current Savings";
            this.lblCurrentSavings.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblCurrentBudgetTop
            // 
            this.lblCurrentBudgetTop.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCurrentBudgetTop.AutoSize = true;
            this.lblCurrentBudgetTop.Location = new System.Drawing.Point(35, 28);
            this.lblCurrentBudgetTop.Name = "lblCurrentBudgetTop";
            this.lblCurrentBudgetTop.Size = new System.Drawing.Size(78, 13);
            this.lblCurrentBudgetTop.TabIndex = 13;
            this.lblCurrentBudgetTop.Text = "Current Budget";
            this.lblCurrentBudgetTop.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // gbxViewFamilyMember
            // 
            this.gbxViewFamilyMember.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gbxViewFamilyMember.Controls.Add(this.lblFamilyMemberName);
            this.gbxViewFamilyMember.Controls.Add(this.lblViewing);
            this.gbxViewFamilyMember.Location = new System.Drawing.Point(286, 19);
            this.gbxViewFamilyMember.Name = "gbxViewFamilyMember";
            this.gbxViewFamilyMember.Size = new System.Drawing.Size(131, 42);
            this.gbxViewFamilyMember.TabIndex = 36;
            this.gbxViewFamilyMember.TabStop = false;
            // 
            // lblFamilyMemberName
            // 
            this.lblFamilyMemberName.AutoSize = true;
            this.lblFamilyMemberName.Location = new System.Drawing.Point(68, 16);
            this.lblFamilyMemberName.Name = "lblFamilyMemberName";
            this.lblFamilyMemberName.Size = new System.Drawing.Size(52, 13);
            this.lblFamilyMemberName.TabIndex = 35;
            this.lblFamilyMemberName.Text = "Alex(Son)";
            this.lblFamilyMemberName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblViewing
            // 
            this.lblViewing.AutoSize = true;
            this.lblViewing.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(153)))), ((int)(((byte)(93)))));
            this.lblViewing.Location = new System.Drawing.Point(15, 16);
            this.lblViewing.Name = "lblViewing";
            this.lblViewing.Size = new System.Drawing.Size(47, 13);
            this.lblViewing.TabIndex = 34;
            this.lblViewing.Text = "Viewing:";
            this.lblViewing.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(342, 575);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 39;
            // 
            // dgwSavingsOutcome
            // 
            this.dgwSavingsOutcome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dgwSavingsOutcome.BackgroundColor = System.Drawing.Color.White;
            this.dgwSavingsOutcome.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwSavingsOutcome.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(153)))), ((int)(((byte)(93)))));
            this.dgwSavingsOutcome.Location = new System.Drawing.Point(41, 237);
            this.dgwSavingsOutcome.Name = "dgwSavingsOutcome";
            this.dgwSavingsOutcome.Size = new System.Drawing.Size(283, 165);
            this.dgwSavingsOutcome.TabIndex = 27;
            // 
            // gbxFamilyMemberTransactions
            // 
            this.gbxFamilyMemberTransactions.Controls.Add(this.dgwSavingsOutcome);
            this.gbxFamilyMemberTransactions.Controls.Add(this.dgwSavingsIncome);
            this.gbxFamilyMemberTransactions.Controls.Add(this.lblSavingsOutcomeGrid);
            this.gbxFamilyMemberTransactions.Controls.Add(this.lblTransactionsIncomeGrid);
            this.gbxFamilyMemberTransactions.Controls.Add(this.lblTransactionsOutcomeGrid);
            this.gbxFamilyMemberTransactions.Controls.Add(this.dgwTransactionsIncome);
            this.gbxFamilyMemberTransactions.Controls.Add(this.dgwTransactionsOutcome);
            this.gbxFamilyMemberTransactions.Controls.Add(this.lblSavingsIncomeGrid);
            this.gbxFamilyMemberTransactions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbxFamilyMemberTransactions.Location = new System.Drawing.Point(0, 238);
            this.gbxFamilyMemberTransactions.Name = "gbxFamilyMemberTransactions";
            this.gbxFamilyMemberTransactions.Size = new System.Drawing.Size(688, 433);
            this.gbxFamilyMemberTransactions.TabIndex = 40;
            this.gbxFamilyMemberTransactions.TabStop = false;
            // 
            // dgwSavingsIncome
            // 
            this.dgwSavingsIncome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dgwSavingsIncome.BackgroundColor = System.Drawing.Color.White;
            this.dgwSavingsIncome.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwSavingsIncome.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(153)))), ((int)(((byte)(93)))));
            this.dgwSavingsIncome.Location = new System.Drawing.Point(367, 237);
            this.dgwSavingsIncome.Name = "dgwSavingsIncome";
            this.dgwSavingsIncome.Size = new System.Drawing.Size(274, 165);
            this.dgwSavingsIncome.TabIndex = 28;
            // 
            // lblSavingsOutcomeGrid
            // 
            this.lblSavingsOutcomeGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblSavingsOutcomeGrid.AutoSize = true;
            this.lblSavingsOutcomeGrid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(153)))), ((int)(((byte)(93)))));
            this.lblSavingsOutcomeGrid.Location = new System.Drawing.Point(119, 221);
            this.lblSavingsOutcomeGrid.Name = "lblSavingsOutcomeGrid";
            this.lblSavingsOutcomeGrid.Size = new System.Drawing.Size(91, 13);
            this.lblSavingsOutcomeGrid.TabIndex = 32;
            this.lblSavingsOutcomeGrid.Text = "Savings Outcome";
            // 
            // lblTransactionsIncomeGrid
            // 
            this.lblTransactionsIncomeGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblTransactionsIncomeGrid.AutoSize = true;
            this.lblTransactionsIncomeGrid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(153)))), ((int)(((byte)(93)))));
            this.lblTransactionsIncomeGrid.Location = new System.Drawing.Point(460, 32);
            this.lblTransactionsIncomeGrid.Name = "lblTransactionsIncomeGrid";
            this.lblTransactionsIncomeGrid.Size = new System.Drawing.Size(106, 13);
            this.lblTransactionsIncomeGrid.TabIndex = 31;
            this.lblTransactionsIncomeGrid.Text = "Transactions Income";
            // 
            // lblTransactionsOutcomeGrid
            // 
            this.lblTransactionsOutcomeGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblTransactionsOutcomeGrid.AutoSize = true;
            this.lblTransactionsOutcomeGrid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(153)))), ((int)(((byte)(93)))));
            this.lblTransactionsOutcomeGrid.Location = new System.Drawing.Point(106, 32);
            this.lblTransactionsOutcomeGrid.Name = "lblTransactionsOutcomeGrid";
            this.lblTransactionsOutcomeGrid.Size = new System.Drawing.Size(114, 13);
            this.lblTransactionsOutcomeGrid.TabIndex = 30;
            this.lblTransactionsOutcomeGrid.Text = "Transactions Outcome";
            // 
            // dgwTransactionsIncome
            // 
            this.dgwTransactionsIncome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dgwTransactionsIncome.BackgroundColor = System.Drawing.Color.White;
            this.dgwTransactionsIncome.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwTransactionsIncome.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(153)))), ((int)(((byte)(93)))));
            this.dgwTransactionsIncome.Location = new System.Drawing.Point(367, 48);
            this.dgwTransactionsIncome.Name = "dgwTransactionsIncome";
            this.dgwTransactionsIncome.Size = new System.Drawing.Size(274, 147);
            this.dgwTransactionsIncome.TabIndex = 26;
            // 
            // dgwTransactionsOutcome
            // 
            this.dgwTransactionsOutcome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dgwTransactionsOutcome.BackgroundColor = System.Drawing.Color.White;
            this.dgwTransactionsOutcome.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwTransactionsOutcome.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(153)))), ((int)(((byte)(93)))));
            this.dgwTransactionsOutcome.Location = new System.Drawing.Point(40, 48);
            this.dgwTransactionsOutcome.Name = "dgwTransactionsOutcome";
            this.dgwTransactionsOutcome.Size = new System.Drawing.Size(284, 147);
            this.dgwTransactionsOutcome.TabIndex = 25;
            // 
            // lblSavingsIncomeGrid
            // 
            this.lblSavingsIncomeGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblSavingsIncomeGrid.AutoSize = true;
            this.lblSavingsIncomeGrid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(153)))), ((int)(((byte)(93)))));
            this.lblSavingsIncomeGrid.Location = new System.Drawing.Point(460, 221);
            this.lblSavingsIncomeGrid.Name = "lblSavingsIncomeGrid";
            this.lblSavingsIncomeGrid.Size = new System.Drawing.Size(83, 13);
            this.lblSavingsIncomeGrid.TabIndex = 33;
            this.lblSavingsIncomeGrid.Text = "Savings Income";
            // 
            // FamilyMemberForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(688, 671);
            this.Controls.Add(this.gbxFamilyMemberCurrentBudget);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.gbxFamilyMemberTransactions);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FamilyMemberForm";
            this.Text = "Family Member";
            this.gbxFamilyMemberCurrentBudget.ResumeLayout(false);
            this.tableLayoutPanelMainBudget.ResumeLayout(false);
            this.tableLayoutPanelMainBudget.PerformLayout();
            this.tableLayoutPanelCurrentSavings.ResumeLayout(false);
            this.tableLayoutPanelCurrentSavings.PerformLayout();
            this.tableLayoutPanelCurrentBudget.ResumeLayout(false);
            this.tableLayoutPanelCurrentBudget.PerformLayout();
            this.gbxViewFamilyMember.ResumeLayout(false);
            this.gbxViewFamilyMember.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwSavingsOutcome)).EndInit();
            this.gbxFamilyMemberTransactions.ResumeLayout(false);
            this.gbxFamilyMemberTransactions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwSavingsIncome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwTransactionsIncome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwTransactionsOutcome)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxFamilyMemberCurrentBudget;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMainBudget;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelCurrentSavings;
        private System.Windows.Forms.DateTimePicker dateTimePickerCurrentSavingsAfterDate;
        private System.Windows.Forms.Label lblCurrentSavingsAfterDate;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelCurrentBudget;
        private System.Windows.Forms.DateTimePicker dateTimePickerCurrentBudgetAfterDate;
        private System.Windows.Forms.Label lblCurrentBudgetAfterDate;
        private System.Windows.Forms.Label lblCurrentSavings;
        private System.Windows.Forms.Label lblCurrentBudgetTop;
        private System.Windows.Forms.GroupBox gbxViewFamilyMember;
        private System.Windows.Forms.Label lblFamilyMemberName;
        private System.Windows.Forms.Label lblViewing;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgwSavingsOutcome;
        private System.Windows.Forms.GroupBox gbxFamilyMemberTransactions;
        private System.Windows.Forms.DataGridView dgwSavingsIncome;
        private System.Windows.Forms.Label lblSavingsOutcomeGrid;
        private System.Windows.Forms.Label lblTransactionsIncomeGrid;
        private System.Windows.Forms.Label lblTransactionsOutcomeGrid;
        private System.Windows.Forms.DataGridView dgwTransactionsIncome;
        private System.Windows.Forms.DataGridView dgwTransactionsOutcome;
        private System.Windows.Forms.Label lblSavingsIncomeGrid;
    }
}