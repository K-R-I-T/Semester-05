namespace BookManagement_NguyenHoangDat
{
    partial class LoginAccountForm
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
            grbLogin = new GroupBox();
            btnCancel = new Button();
            btnLogin = new Button();
            txtPassword = new TextBox();
            txtEmail = new TextBox();
            lblEmail = new Label();
            lblPassword = new Label();
            lblHeader = new Label();
            grbLogin.SuspendLayout();
            SuspendLayout();
            // 
            // grbLogin
            // 
            grbLogin.Controls.Add(btnCancel);
            grbLogin.Controls.Add(btnLogin);
            grbLogin.Controls.Add(txtPassword);
            grbLogin.Controls.Add(txtEmail);
            grbLogin.Controls.Add(lblEmail);
            grbLogin.Controls.Add(lblPassword);
            grbLogin.Location = new Point(12, 93);
            grbLogin.Name = "grbLogin";
            grbLogin.Size = new Size(314, 189);
            grbLogin.TabIndex = 1;
            grbLogin.TabStop = false;
            grbLogin.Text = "Account Info";
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnCancel.Location = new Point(181, 118);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(112, 50);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnLogin.Location = new Point(6, 118);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(114, 50);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(126, 65);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(167, 27);
            txtPassword.TabIndex = 1;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(125, 29);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(168, 27);
            txtEmail.TabIndex = 0;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblEmail.Location = new Point(6, 23);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(73, 31);
            lblEmail.TabIndex = 4;
            lblEmail.Text = "Email";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblPassword.Location = new Point(6, 59);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(114, 31);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Password";
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblHeader.Location = new Point(12, 9);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(357, 81);
            lblHeader.TabIndex = 2;
            lblHeader.Text = "Login Form";
            // 
            // LoginAccountForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(363, 311);
            Controls.Add(grbLogin);
            Controls.Add(lblHeader);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "LoginAccountForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginAccountForm";
            grbLogin.ResumeLayout(false);
            grbLogin.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grbLogin;
        private Button btnLogin;
        private TextBox txtPassword;
        private TextBox txtEmail;
        private Label lblEmail;
        private Label lblPassword;
        private Label lblHeader;
        private Button btnCancel;
    }
}