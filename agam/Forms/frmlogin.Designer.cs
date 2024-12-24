
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
            this.name = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.joinUs = new System.Windows.Forms.Label();
            this.usernameTxt = new System.Windows.Forms.TextBox();
            this.passwordTxt = new System.Windows.Forms.TextBox();
            this.loginBtn = new System.Windows.Forms.Button();
            this.SignUpbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.BackColor = System.Drawing.Color.Transparent;
            this.name.Font = new System.Drawing.Font("Franklin Gothic Demi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.name.Location = new System.Drawing.Point(124, 310);
            this.name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(47, 20);
            this.name.TabIndex = 1;
            this.name.Text = "Name";
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.password.Font = new System.Drawing.Font("Franklin Gothic Demi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.password.Location = new System.Drawing.Point(124, 346);
            this.password.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(72, 20);
            this.password.TabIndex = 2;
            this.password.Text = "Password";
            // 
            // joinUs
            // 
            this.joinUs.AutoSize = true;
            this.joinUs.BackColor = System.Drawing.Color.Transparent;
            this.joinUs.Font = new System.Drawing.Font("Franklin Gothic Demi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.joinUs.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.joinUs.Location = new System.Drawing.Point(532, 302);
            this.joinUs.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.joinUs.Name = "joinUs";
            this.joinUs.Size = new System.Drawing.Size(158, 20);
            this.joinUs.TabIndex = 3;
            this.joinUs.Text = "dont have an account?";
            // 
            // usernameTxt
            // 
            this.usernameTxt.BackColor = System.Drawing.Color.DarkGray;
            this.usernameTxt.Location = new System.Drawing.Point(207, 311);
            this.usernameTxt.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.usernameTxt.Name = "usernameTxt";
            this.usernameTxt.Size = new System.Drawing.Size(91, 20);
            this.usernameTxt.TabIndex = 4;
            this.usernameTxt.Text = "admin";
            // 
            // passwordTxt
            // 
            this.passwordTxt.BackColor = System.Drawing.Color.DarkGray;
            this.passwordTxt.Location = new System.Drawing.Point(207, 347);
            this.passwordTxt.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.Size = new System.Drawing.Size(91, 20);
            this.passwordTxt.TabIndex = 5;
            this.passwordTxt.Text = "admin123";
            this.passwordTxt.TextChanged += new System.EventHandler(this.passwordTxt_TextChanged);
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.loginBtn.Font = new System.Drawing.Font("Franklin Gothic Demi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.loginBtn.Location = new System.Drawing.Point(317, 322);
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
            this.SignUpbtn.Font = new System.Drawing.Font("Franklin Gothic Demi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUpbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SignUpbtn.Location = new System.Drawing.Point(566, 323);
            this.SignUpbtn.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.SignUpbtn.Name = "SignUpbtn";
            this.SignUpbtn.Size = new System.Drawing.Size(108, 44);
            this.SignUpbtn.TabIndex = 7;
            this.SignUpbtn.Text = "Sign Up";
            this.SignUpbtn.UseVisualStyleBackColor = false;
            this.SignUpbtn.Click += new System.EventHandler(this.SignUpbtn_Click);
            // 
            // frmlogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::agam.Properties.Resources.netflix;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(715, 418);
            this.Controls.Add(this.SignUpbtn);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.passwordTxt);
            this.Controls.Add(this.usernameTxt);
            this.Controls.Add(this.joinUs);
            this.Controls.Add(this.password);
            this.Controls.Add(this.name);
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "frmlogin";
            this.Text = "frmlogin";
            this.Load += new System.EventHandler(this.frmlogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Label joinUs;
        private System.Windows.Forms.TextBox usernameTxt;
        private System.Windows.Forms.TextBox passwordTxt;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Button SignUpbtn;
    }
}