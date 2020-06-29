namespace TrackBudgetApp.WindowsFormsUI
{
    partial class LoginPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPage));
            this.lblEmailLoginPage = new System.Windows.Forms.Label();
            this.tbxEmailLoginPage = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.tbxPasswordLoginPage = new System.Windows.Forms.TextBox();
            this.lblPasswordLoginPage = new System.Windows.Forms.Label();
            this.btnSignUpLoginPage = new System.Windows.Forms.Button();
            this.pictureBoxLoginPageLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoginPageLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEmailLoginPage
            // 
            this.lblEmailLoginPage.AutoSize = true;
            this.lblEmailLoginPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailLoginPage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(153)))), ((int)(((byte)(93)))));
            this.lblEmailLoginPage.Location = new System.Drawing.Point(44, 200);
            this.lblEmailLoginPage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmailLoginPage.Name = "lblEmailLoginPage";
            this.lblEmailLoginPage.Size = new System.Drawing.Size(47, 17);
            this.lblEmailLoginPage.TabIndex = 0;
            this.lblEmailLoginPage.Text = "Email";
            // 
            // tbxEmailLoginPage
            // 
            this.tbxEmailLoginPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbxEmailLoginPage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(153)))), ((int)(((byte)(93)))));
            this.tbxEmailLoginPage.Location = new System.Drawing.Point(141, 194);
            this.tbxEmailLoginPage.Margin = new System.Windows.Forms.Padding(4);
            this.tbxEmailLoginPage.Name = "tbxEmailLoginPage";
            this.tbxEmailLoginPage.Size = new System.Drawing.Size(190, 26);
            this.tbxEmailLoginPage.TabIndex = 1;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(153)))), ((int)(((byte)(93)))));
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(210, 350);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(100, 41);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // tbxPasswordLoginPage
            // 
            this.tbxPasswordLoginPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbxPasswordLoginPage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(153)))), ((int)(((byte)(93)))));
            this.tbxPasswordLoginPage.Location = new System.Drawing.Point(141, 256);
            this.tbxPasswordLoginPage.Margin = new System.Windows.Forms.Padding(4);
            this.tbxPasswordLoginPage.Name = "tbxPasswordLoginPage";
            this.tbxPasswordLoginPage.PasswordChar = '*';
            this.tbxPasswordLoginPage.Size = new System.Drawing.Size(190, 26);
            this.tbxPasswordLoginPage.TabIndex = 3;
            // 
            // lblPasswordLoginPage
            // 
            this.lblPasswordLoginPage.AutoSize = true;
            this.lblPasswordLoginPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswordLoginPage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(153)))), ((int)(((byte)(93)))));
            this.lblPasswordLoginPage.Location = new System.Drawing.Point(44, 262);
            this.lblPasswordLoginPage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPasswordLoginPage.Name = "lblPasswordLoginPage";
            this.lblPasswordLoginPage.Size = new System.Drawing.Size(77, 17);
            this.lblPasswordLoginPage.TabIndex = 4;
            this.lblPasswordLoginPage.Text = "Password";
            // 
            // btnSignUpLoginPage
            // 
            this.btnSignUpLoginPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(153)))), ((int)(((byte)(93)))));
            this.btnSignUpLoginPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSignUpLoginPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignUpLoginPage.ForeColor = System.Drawing.Color.White;
            this.btnSignUpLoginPage.Location = new System.Drawing.Point(66, 350);
            this.btnSignUpLoginPage.Margin = new System.Windows.Forms.Padding(4);
            this.btnSignUpLoginPage.Name = "btnSignUpLoginPage";
            this.btnSignUpLoginPage.Size = new System.Drawing.Size(100, 41);
            this.btnSignUpLoginPage.TabIndex = 5;
            this.btnSignUpLoginPage.Text = "Sign Up";
            this.btnSignUpLoginPage.UseVisualStyleBackColor = false;
            this.btnSignUpLoginPage.Click += new System.EventHandler(this.btnSignUpLoginPage_Click);
            // 
            // pictureBoxLoginPageLogo
            // 
            this.pictureBoxLoginPageLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLoginPageLogo.Image")));
            this.pictureBoxLoginPageLogo.Location = new System.Drawing.Point(130, 25);
            this.pictureBoxLoginPageLogo.Name = "pictureBoxLoginPageLogo";
            this.pictureBoxLoginPageLogo.Size = new System.Drawing.Size(120, 120);
            this.pictureBoxLoginPageLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLoginPageLogo.TabIndex = 6;
            this.pictureBoxLoginPageLogo.TabStop = false;
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Controls.Add(this.pictureBoxLoginPageLogo);
            this.Controls.Add(this.btnSignUpLoginPage);
            this.Controls.Add(this.lblPasswordLoginPage);
            this.Controls.Add(this.tbxPasswordLoginPage);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.tbxEmailLoginPage);
            this.Controls.Add(this.lblEmailLoginPage);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(400, 500);
            this.MinimumSize = new System.Drawing.Size(400, 500);
            this.Name = "LoginPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Track Budget";
            this.Load += new System.EventHandler(this.LoginPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoginPageLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmailLoginPage;
        private System.Windows.Forms.TextBox tbxEmailLoginPage;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox tbxPasswordLoginPage;
        private System.Windows.Forms.Label lblPasswordLoginPage;
        private System.Windows.Forms.Button btnSignUpLoginPage;
        private System.Windows.Forms.PictureBox pictureBoxLoginPageLogo;
    }
}