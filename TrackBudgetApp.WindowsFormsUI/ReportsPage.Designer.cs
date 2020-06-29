namespace TrackBudgetApp.WindowsFormsUI
{
    partial class ReportsPage
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.gbxReportsTop = new System.Windows.Forms.GroupBox();
            this.btnChildFormClose = new System.Windows.Forms.Button();
            this.dateTimePickerReportsTo = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerReportsFrom = new System.Windows.Forms.DateTimePicker();
            this.lblTo = new System.Windows.Forms.Label();
            this.lblFrom = new System.Windows.Forms.Label();
            this.cbxReportsCategory = new System.Windows.Forms.ComboBox();
            this.dgwTransactionsByCategory = new System.Windows.Forms.DataGridView();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gbxReportsTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwTransactionsByCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxReportsTop
            // 
            this.gbxReportsTop.Controls.Add(this.btnChildFormClose);
            this.gbxReportsTop.Controls.Add(this.dateTimePickerReportsTo);
            this.gbxReportsTop.Controls.Add(this.dateTimePickerReportsFrom);
            this.gbxReportsTop.Controls.Add(this.lblTo);
            this.gbxReportsTop.Controls.Add(this.lblFrom);
            this.gbxReportsTop.Controls.Add(this.cbxReportsCategory);
            this.gbxReportsTop.Controls.Add(this.dgwTransactionsByCategory);
            this.gbxReportsTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbxReportsTop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.gbxReportsTop.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gbxReportsTop.Location = new System.Drawing.Point(0, 0);
            this.gbxReportsTop.Margin = new System.Windows.Forms.Padding(4);
            this.gbxReportsTop.Name = "gbxReportsTop";
            this.gbxReportsTop.Padding = new System.Windows.Forms.Padding(4);
            this.gbxReportsTop.Size = new System.Drawing.Size(667, 492);
            this.gbxReportsTop.TabIndex = 13;
            this.gbxReportsTop.TabStop = false;
            // 
            // btnChildFormClose
            // 
            this.btnChildFormClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(153)))), ((int)(((byte)(93)))));
            this.btnChildFormClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChildFormClose.FlatAppearance.BorderSize = 0;
            this.btnChildFormClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChildFormClose.ForeColor = System.Drawing.Color.White;
            this.btnChildFormClose.Location = new System.Drawing.Point(9, 15);
            this.btnChildFormClose.Margin = new System.Windows.Forms.Padding(5);
            this.btnChildFormClose.Name = "btnChildFormClose";
            this.btnChildFormClose.Size = new System.Drawing.Size(133, 34);
            this.btnChildFormClose.TabIndex = 9;
            this.btnChildFormClose.Text = "X";
            this.btnChildFormClose.UseVisualStyleBackColor = false;
            this.btnChildFormClose.Click += new System.EventHandler(this.btnChildFormClose_Click);
            // 
            // dateTimePickerReportsTo
            // 
            this.dateTimePickerReportsTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerReportsTo.Location = new System.Drawing.Point(278, 95);
            this.dateTimePickerReportsTo.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerReportsTo.Name = "dateTimePickerReportsTo";
            this.dateTimePickerReportsTo.Size = new System.Drawing.Size(125, 23);
            this.dateTimePickerReportsTo.TabIndex = 8;
            // 
            // dateTimePickerReportsFrom
            // 
            this.dateTimePickerReportsFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerReportsFrom.Location = new System.Drawing.Point(97, 95);
            this.dateTimePickerReportsFrom.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerReportsFrom.Name = "dateTimePickerReportsFrom";
            this.dateTimePickerReportsFrom.Size = new System.Drawing.Size(125, 23);
            this.dateTimePickerReportsFrom.TabIndex = 7;
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(239, 97);
            this.lblTo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(29, 17);
            this.lblTo.TabIndex = 6;
            this.lblTo.Text = "To:";
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblFrom.Location = new System.Drawing.Point(45, 97);
            this.lblFrom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(44, 17);
            this.lblFrom.TabIndex = 6;
            this.lblFrom.Text = "From:";
            // 
            // cbxReportsCategory
            // 
            this.cbxReportsCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxReportsCategory.FormattingEnabled = true;
            this.cbxReportsCategory.Location = new System.Drawing.Point(431, 94);
            this.cbxReportsCategory.Margin = new System.Windows.Forms.Padding(4);
            this.cbxReportsCategory.Name = "cbxReportsCategory";
            this.cbxReportsCategory.Size = new System.Drawing.Size(181, 24);
            this.cbxReportsCategory.TabIndex = 5;
            this.cbxReportsCategory.Text = "Select a Category";
            // 
            // dgwTransactionsByCategory
            // 
            this.dgwTransactionsByCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgwTransactionsByCategory.BackgroundColor = System.Drawing.Color.White;
            this.dgwTransactionsByCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwTransactionsByCategory.Location = new System.Drawing.Point(49, 140);
            this.dgwTransactionsByCategory.Margin = new System.Windows.Forms.Padding(5);
            this.dgwTransactionsByCategory.Name = "dgwTransactionsByCategory";
            this.dgwTransactionsByCategory.Size = new System.Drawing.Size(564, 310);
            this.dgwTransactionsByCategory.TabIndex = 0;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(50, 500);
            this.chart1.Margin = new System.Windows.Forms.Padding(4);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(563, 297);
            this.chart1.TabIndex = 14;
            this.chart1.Text = "chart1";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(278, 815);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(125, 23);
            this.dateTimePicker1.TabIndex = 18;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(97, 815);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(125, 23);
            this.dateTimePicker2.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(239, 817);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "To:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 817);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "From:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(312, 855);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 17);
            this.label3.TabIndex = 19;
            // 
            // ReportsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(684, 749);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.gbxReportsTop);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ReportsPage";
            this.Text = "ReportsPage";
            this.gbxReportsTop.ResumeLayout(false);
            this.gbxReportsTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwTransactionsByCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxReportsTop;
        private System.Windows.Forms.ComboBox cbxReportsCategory;
        private System.Windows.Forms.DataGridView dgwTransactionsByCategory;
        private System.Windows.Forms.DateTimePicker dateTimePickerReportsTo;
        private System.Windows.Forms.DateTimePicker dateTimePickerReportsFrom;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnChildFormClose;
        private System.Windows.Forms.Label label3;
    }
}