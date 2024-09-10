namespace Bai1_BTH1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblUser = new Label();
            lblPass = new Label();
            txtUser = new TextBox();
            txtPass = new TextBox();
            btnLogin = new Button();
            btnReset = new Button();
            btnExit = new Button();
            chkRemember = new CheckBox();
            SuspendLayout();
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Location = new Point(32, 22);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(105, 19);
            lblUser.TabIndex = 0;
            lblUser.Text = "Tên đăng nhập";
            lblUser.Click += lblUser_Click;
            // 
            // lblPass
            // 
            lblPass.AutoSize = true;
            lblPass.Location = new Point(32, 52);
            lblPass.Name = "lblPass";
            lblPass.Size = new Size(71, 19);
            lblPass.TabIndex = 0;
            lblPass.Text = "Mật khẩu";
            lblPass.Click += lblPass_Click;
            // 
            // txtUser
            // 
            txtUser.Location = new Point(159, 19);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(187, 27);
            txtUser.TabIndex = 0;
            txtUser.TextChanged += txtUser_TextChanged;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(159, 49);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(187, 27);
            txtPass.TabIndex = 1;
            txtPass.TextChanged += txtPass_TextChanged;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(32, 116);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(94, 28);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Đăng nhập";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(142, 116);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(94, 28);
            btnReset.TabIndex = 4;
            btnReset.Text = "Xóa";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(252, 116);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 28);
            btnExit.TabIndex = 5;
            btnExit.Text = "Dừng";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // chkRemember
            // 
            chkRemember.AutoSize = true;
            chkRemember.Location = new Point(41, 88);
            chkRemember.Name = "chkRemember";
            chkRemember.Size = new Size(82, 23);
            chkRemember.TabIndex = 2;
            chkRemember.Text = "Ghi nhớ";
            chkRemember.UseVisualStyleBackColor = true;
            chkRemember.CheckedChanged += chkRemember_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(383, 169);
            Controls.Add(chkRemember);
            Controls.Add(btnExit);
            Controls.Add(btnReset);
            Controls.Add(btnLogin);
            Controls.Add(txtPass);
            Controls.Add(txtUser);
            Controls.Add(lblPass);
            Controls.Add(lblUser);
            Font = new Font("Times New Roman", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            MaximizeBox = false;
            MaximumSize = new Size(399, 209);
            MinimizeBox = false;
            MinimumSize = new Size(399, 209);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUser;
        private Label lblPass;
        private TextBox txtUser;
        private TextBox txtPass;
        private Button btnLogin;
        private Button btnReset;
        private Button btnExit;
        private CheckBox chkRemember;
    }
}