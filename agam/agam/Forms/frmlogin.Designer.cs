
namespace agam.Forms
{
    partial class frmlogin
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
            this.username = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.joinUs = new System.Windows.Forms.Label();
            this.usernameTxt = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.passwordTxt = new System.Windows.Forms.TextBox();
            this.loginBtn = new System.Windows.Forms.Button();
            this.SignUpbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.username.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.username.Location = new System.Drawing.Point(31, 210);
            this.username.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(60, 13);
            this.username.TabIndex = 1;
            this.username.Text = "User Name";
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.password.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.password.Location = new System.Drawing.Point(31, 235);
            this.password.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(53, 13);
            this.password.TabIndex = 2;
            this.password.Text = "Password";
            // 
            // joinUs
            // 
            this.joinUs.AutoSize = true;
            this.joinUs.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.joinUs.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.joinUs.Location = new System.Drawing.Point(365, 189);
            this.joinUs.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.joinUs.Name = "joinUs";
            this.joinUs.Size = new System.Drawing.Size(118, 13);
            this.joinUs.TabIndex = 3;
            this.joinUs.Text = "dont have an account?";
            // 
            // usernameTxt
            // 
            this.usernameTxt.BackColor = System.Drawing.Color.DarkGray;
            this.usernameTxt.Location = new System.Drawing.Point(100, 203);
            this.usernameTxt.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.usernameTxt.Name = "usernameTxt";
            this.usernameTxt.Size = new System.Drawing.Size(91, 20);
            this.usernameTxt.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::agam.Properties.Resources.netflix;
            this.pictureBox1.Location = new System.Drawing.Point(-70, -43);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(672, 330);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // passwordTxt
            // 
            this.passwordTxt.BackColor = System.Drawing.Color.DarkGray;
            this.passwordTxt.Location = new System.Drawing.Point(100, 228);
            this.passwordTxt.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.Size = new System.Drawing.Size(91, 20);
            this.passwordTxt.TabIndex = 5;
            this.passwordTxt.TextChanged += new System.EventHandler(this.passwordTxt_TextChanged);
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.loginBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.loginBtn.Location = new System.Drawing.Point(207, 203);
            this.loginBtn.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(101, 45);
            this.loginBtn.TabIndex = 6;
            this.loginBtn.Text = "Log In";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // SignUpbtn
            // 
            this.SignUpbtn.BackColor = System.Drawing.SystemColors.ControlText;
            this.SignUpbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SignUpbtn.Location = new System.Drawing.Point(368, 203);
            this.SignUpbtn.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.SignUpbtn.Name = "SignUpbtn";
            this.SignUpbtn.Size = new System.Drawing.Size(108, 45);
            this.SignUpbtn.TabIndex = 7;
            this.SignUpbtn.Text = "Sign Up";
            this.SignUpbtn.UseVisualStyleBackColor = false;
            this.SignUpbtn.Click += new System.EventHandler(this.SignUpbtn_Click);
            // 
            // frmlogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 272);
            this.Controls.Add(this.SignUpbtn);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.passwordTxt);
            this.Controls.Add(this.usernameTxt);
            this.Controls.Add(this.joinUs);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "frmlogin";
            this.Text = "frmlogin";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Label joinUs;
        private System.Windows.Forms.TextBox usernameTxt;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox passwordTxt;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Button SignUpbtn;
    }
}