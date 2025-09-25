namespace WinFormsApp1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblUser = new Label();
            lblPass = new Label();
            txtUser = new TextBox();
            txtPass = new TextBox();
            btnLogin = new Button();
            lblInfo = new Label();
            SuspendLayout();
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.BackColor = Color.LightSkyBlue;
            lblUser.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblUser.ForeColor = Color.Black;
            lblUser.Location = new Point(150, 180);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(91, 23);
            lblUser.TabIndex = 0;
            lblUser.Text = "Istifadəçi:";
            // 
            // lblPass
            // 
            lblPass.AutoSize = true;
            lblPass.BackColor = Color.LightSkyBlue;
            lblPass.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblPass.ForeColor = Color.Black;
            lblPass.Location = new Point(150, 235);
            lblPass.Name = "lblPass";
            lblPass.Size = new Size(69, 23);
            lblPass.TabIndex = 1;
            lblPass.Text = "Şifrə:";
            // 
            // txtUser
            // 
            txtUser.Location = new Point(270, 176);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(160, 27);
            txtUser.TabIndex = 2;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(270, 231);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(160, 27);
            txtPass.TabIndex = 3;
            txtPass.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.DarkGreen;
            btnLogin.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(295, 290);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(110, 32);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Daxil ol";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblInfo
            // 
            lblInfo.AutoSize = true;
            lblInfo.ForeColor = Color.DarkRed;
            lblInfo.Location = new Point(180, 380);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(0, 20);
            lblInfo.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 500);
            Controls.Add(lblInfo);
            Controls.Add(btnLogin);
            Controls.Add(txtPass);
            Controls.Add(txtUser);
            Controls.Add(lblPass);
            Controls.Add(lblUser);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login Paneli";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUser;
        private Label lblPass;
        private TextBox txtUser;
        private TextBox txtPass;
        private Button btnLogin;
        private Label lblInfo;
    }
}
