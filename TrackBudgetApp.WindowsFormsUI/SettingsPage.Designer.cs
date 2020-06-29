namespace TrackBudgetApp.WindowsFormsUI
{
    partial class SettingsPage
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
            this.tableLayoutPanelSettings = new System.Windows.Forms.TableLayoutPanel();
            this.cbxSettingsNotificationFrequency = new System.Windows.Forms.ComboBox();
            this.cbxSettingsWindowsNotification = new System.Windows.Forms.ComboBox();
            this.cbxSettingsEmailNotification = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxSettingsDateTime = new System.Windows.Forms.ComboBox();
            this.tbxChangePassword = new System.Windows.Forms.TextBox();
            this.btnChildFormClose = new System.Windows.Forms.Button();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.tableLayoutPanelSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelSettings
            // 
            this.tableLayoutPanelSettings.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tableLayoutPanelSettings.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanelSettings.ColumnCount = 2;
            this.tableLayoutPanelSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelSettings.Controls.Add(this.cbxSettingsNotificationFrequency, 1, 3);
            this.tableLayoutPanelSettings.Controls.Add(this.cbxSettingsWindowsNotification, 1, 2);
            this.tableLayoutPanelSettings.Controls.Add(this.cbxSettingsEmailNotification, 1, 1);
            this.tableLayoutPanelSettings.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanelSettings.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanelSettings.Controls.Add(this.label3, 0, 3);
            this.tableLayoutPanelSettings.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanelSettings.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanelSettings.Controls.Add(this.cbxSettingsDateTime, 1, 0);
            this.tableLayoutPanelSettings.Controls.Add(this.tbxChangePassword, 1, 4);
            this.tableLayoutPanelSettings.Location = new System.Drawing.Point(68, 83);
            this.tableLayoutPanelSettings.Name = "tableLayoutPanelSettings";
            this.tableLayoutPanelSettings.RowCount = 5;
            this.tableLayoutPanelSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.9992F));
            this.tableLayoutPanelSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.9992F));
            this.tableLayoutPanelSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.9992F));
            this.tableLayoutPanelSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.9992F));
            this.tableLayoutPanelSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0032F));
            this.tableLayoutPanelSettings.Size = new System.Drawing.Size(537, 339);
            this.tableLayoutPanelSettings.TabIndex = 1;
            // 
            // cbxSettingsNotificationFrequency
            // 
            this.cbxSettingsNotificationFrequency.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbxSettingsNotificationFrequency.FormattingEnabled = true;
            this.cbxSettingsNotificationFrequency.Location = new System.Drawing.Point(342, 224);
            this.cbxSettingsNotificationFrequency.Name = "cbxSettingsNotificationFrequency";
            this.cbxSettingsNotificationFrequency.Size = new System.Drawing.Size(121, 24);
            this.cbxSettingsNotificationFrequency.TabIndex = 10;
            // 
            // cbxSettingsWindowsNotification
            // 
            this.cbxSettingsWindowsNotification.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbxSettingsWindowsNotification.FormattingEnabled = true;
            this.cbxSettingsWindowsNotification.Location = new System.Drawing.Point(342, 157);
            this.cbxSettingsWindowsNotification.Name = "cbxSettingsWindowsNotification";
            this.cbxSettingsWindowsNotification.Size = new System.Drawing.Size(121, 24);
            this.cbxSettingsWindowsNotification.TabIndex = 9;
            // 
            // cbxSettingsEmailNotification
            // 
            this.cbxSettingsEmailNotification.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbxSettingsEmailNotification.FormattingEnabled = true;
            this.cbxSettingsEmailNotification.Location = new System.Drawing.Point(342, 90);
            this.cbxSettingsEmailNotification.Name = "cbxSettingsEmailNotification";
            this.cbxSettingsEmailNotification.Size = new System.Drawing.Size(121, 24);
            this.cbxSettingsEmailNotification.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Date/Time Region";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Email Notification";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Notification Frequency";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Windows Notification";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(73, 295);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Change Password";
            // 
            // cbxSettingsDateTime
            // 
            this.cbxSettingsDateTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbxSettingsDateTime.FormattingEnabled = true;
            this.cbxSettingsDateTime.Location = new System.Drawing.Point(342, 22);
            this.cbxSettingsDateTime.Name = "cbxSettingsDateTime";
            this.cbxSettingsDateTime.Size = new System.Drawing.Size(121, 24);
            this.cbxSettingsDateTime.TabIndex = 7;
            // 
            // tbxChangePassword
            // 
            this.tbxChangePassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbxChangePassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(153)))), ((int)(((byte)(93)))));
            this.tbxChangePassword.Location = new System.Drawing.Point(342, 292);
            this.tbxChangePassword.Name = "tbxChangePassword";
            this.tbxChangePassword.PasswordChar = '*';
            this.tbxChangePassword.Size = new System.Drawing.Size(121, 23);
            this.tbxChangePassword.TabIndex = 11;
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
            // btnSaveChanges
            // 
            this.btnSaveChanges.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSaveChanges.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(153)))), ((int)(((byte)(93)))));
            this.btnSaveChanges.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveChanges.FlatAppearance.BorderSize = 0;
            this.btnSaveChanges.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveChanges.ForeColor = System.Drawing.Color.White;
            this.btnSaveChanges.Location = new System.Drawing.Point(475, 458);
            this.btnSaveChanges.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(130, 28);
            this.btnSaveChanges.TabIndex = 5;
            this.btnSaveChanges.Text = "Save";
            this.btnSaveChanges.UseVisualStyleBackColor = false;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnChildFormClose_Click);
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnChangePassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(153)))), ((int)(((byte)(93)))));
            this.btnChangePassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChangePassword.FlatAppearance.BorderSize = 0;
            this.btnChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePassword.ForeColor = System.Drawing.Color.White;
            this.btnChangePassword.Location = new System.Drawing.Point(337, 458);
            this.btnChangePassword.Margin = new System.Windows.Forms.Padding(4);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(130, 28);
            this.btnChangePassword.TabIndex = 5;
            this.btnChangePassword.Text = "Change Password";
            this.btnChangePassword.UseVisualStyleBackColor = false;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChildFormClose_Click);
            // 
            // SettingsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(684, 749);
            this.Controls.Add(this.btnChangePassword);
            this.Controls.Add(this.btnSaveChanges);
            this.Controls.Add(this.btnChildFormClose);
            this.Controls.Add(this.tableLayoutPanelSettings);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SettingsPage";
            this.Text = "SettingsPage";
            this.tableLayoutPanelSettings.ResumeLayout(false);
            this.tableLayoutPanelSettings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelSettings;
        private System.Windows.Forms.ComboBox cbxSettingsNotificationFrequency;
        private System.Windows.Forms.ComboBox cbxSettingsWindowsNotification;
        private System.Windows.Forms.ComboBox cbxSettingsEmailNotification;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxSettingsDateTime;
        private System.Windows.Forms.TextBox tbxChangePassword;
        private System.Windows.Forms.Button btnChildFormClose;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.Button btnChangePassword;
    }
}