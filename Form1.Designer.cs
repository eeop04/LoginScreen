namespace LoginScreen
{
    partial class LoginScreen
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
            lblAppName = new Label();
            txtID = new TextBox();
            txtPW = new TextBox();
            btnLogin = new Button();
            SuspendLayout();
            // 
            // lblAppName
            // 
            lblAppName.AutoSize = true;
            lblAppName.Font = new Font("맑은 고딕", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 129);
            lblAppName.Location = new Point(328, 44);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new Size(134, 60);
            lblAppName.TabIndex = 0;
            lblAppName.Text = "Login";
            // 
            // txtID
            // 
            txtID.Font = new Font("맑은 고딕", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 129);
            txtID.ForeColor = Color.Silver;
            txtID.Location = new Point(122, 135);
            txtID.Name = "txtID";
            txtID.Size = new Size(550, 65);
            txtID.TabIndex = 2;
            txtID.Text = "아이디";
            txtID.Enter += txtID_Enter;
            txtID.Leave += txtID_Leave;
            // 
            // txtPW
            // 
            txtPW.Font = new Font("맑은 고딕", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 129);
            txtPW.ForeColor = Color.Silver;
            txtPW.Location = new Point(122, 230);
            txtPW.Name = "txtPW";
            txtPW.Size = new Size(550, 65);
            txtPW.TabIndex = 3;
            txtPW.Text = "패스워드";
            txtPW.Enter += txtPW_Enter;
            txtPW.Leave += txtPW_Leave;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(255, 255, 128);
            btnLogin.Font = new Font("맑은 고딕", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 129);
            btnLogin.ForeColor = SystemColors.HotTrack;
            btnLogin.Location = new Point(301, 335);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(204, 78);
            btnLogin.TabIndex = 1;
            btnLogin.Text = "로그인";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // LoginScreen
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLogin);
            Controls.Add(txtPW);
            Controls.Add(txtID);
            Controls.Add(lblAppName);
            Name = "LoginScreen";
            Text = "Login Screen";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAppName;
        private TextBox txtID;
        private TextBox txtPW;
        private Button btnLogin;
    }
}
