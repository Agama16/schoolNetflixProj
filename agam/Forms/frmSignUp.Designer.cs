﻿
namespace agam.Forms
{
    partial class frmSignUp
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
            this.components = new System.ComponentModel.Container();
            this.name = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.Label();
            this.dateOfBirth = new System.Windows.Forms.Label();
            this.phoneNumber = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.accountType = new System.Windows.Forms.Label();
            this.creditCardNum = new System.Windows.Forms.Label();
            this.phoneTxt = new System.Windows.Forms.TextBox();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.idTxt = new System.Windows.Forms.TextBox();
            this.passwordTxt = new System.Windows.Forms.TextBox();
            this.creditTxt = new System.Windows.Forms.TextBox();
            this.signUpbtn = new System.Windows.Forms.Button();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.typePick = new System.Windows.Forms.ComboBox();
            this.login = new System.Windows.Forms.Label();
            this.loginBtn = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.name.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.name.Location = new System.Drawing.Point(21, 33);
            this.name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(35, 13);
            this.name.TabIndex = 1;
            this.name.Text = "Name";
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.id.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.id.Location = new System.Drawing.Point(21, 92);
            this.id.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(16, 13);
            this.id.TabIndex = 2;
            this.id.Text = "Id";
            // 
            // dateOfBirth
            // 
            this.dateOfBirth.AutoSize = true;
            this.dateOfBirth.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dateOfBirth.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dateOfBirth.Location = new System.Drawing.Point(21, 145);
            this.dateOfBirth.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dateOfBirth.Name = "dateOfBirth";
            this.dateOfBirth.Size = new System.Drawing.Size(68, 13);
            this.dateOfBirth.TabIndex = 3;
            this.dateOfBirth.Text = "Date Of Birth";
            // 
            // phoneNumber
            // 
            this.phoneNumber.AutoSize = true;
            this.phoneNumber.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.phoneNumber.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.phoneNumber.Location = new System.Drawing.Point(21, 202);
            this.phoneNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.phoneNumber.Name = "phoneNumber";
            this.phoneNumber.Size = new System.Drawing.Size(78, 13);
            this.phoneNumber.TabIndex = 4;
            this.phoneNumber.Text = "Phone Number";
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.password.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.password.Location = new System.Drawing.Point(294, 33);
            this.password.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(53, 13);
            this.password.TabIndex = 5;
            this.password.Text = "Password";
            // 
            // accountType
            // 
            this.accountType.AutoSize = true;
            this.accountType.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.accountType.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.accountType.Location = new System.Drawing.Point(294, 88);
            this.accountType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.accountType.Name = "accountType";
            this.accountType.Size = new System.Drawing.Size(74, 13);
            this.accountType.TabIndex = 6;
            this.accountType.Text = "Account Type";
            // 
            // creditCardNum
            // 
            this.creditCardNum.AutoSize = true;
            this.creditCardNum.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.creditCardNum.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.creditCardNum.Location = new System.Drawing.Point(294, 202);
            this.creditCardNum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.creditCardNum.Name = "creditCardNum";
            this.creditCardNum.Size = new System.Drawing.Size(59, 13);
            this.creditCardNum.TabIndex = 7;
            this.creditCardNum.Text = "Credit Card";
            // 
            // phoneTxt
            // 
            this.phoneTxt.Location = new System.Drawing.Point(118, 198);
            this.phoneTxt.Margin = new System.Windows.Forms.Padding(2);
            this.phoneTxt.Name = "phoneTxt";
            this.phoneTxt.Size = new System.Drawing.Size(92, 20);
            this.phoneTxt.TabIndex = 8;
            // 
            // nameTxt
            // 
            this.nameTxt.Location = new System.Drawing.Point(118, 30);
            this.nameTxt.Margin = new System.Windows.Forms.Padding(2);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(92, 20);
            this.nameTxt.TabIndex = 9;
            // 
            // idTxt
            // 
            this.idTxt.Location = new System.Drawing.Point(118, 85);
            this.idTxt.Margin = new System.Windows.Forms.Padding(2);
            this.idTxt.Name = "idTxt";
            this.idTxt.Size = new System.Drawing.Size(92, 20);
            this.idTxt.TabIndex = 10;
            // 
            // passwordTxt
            // 
            this.passwordTxt.Location = new System.Drawing.Point(381, 30);
            this.passwordTxt.Margin = new System.Windows.Forms.Padding(2);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.Size = new System.Drawing.Size(92, 20);
            this.passwordTxt.TabIndex = 12;
            // 
            // creditTxt
            // 
            this.creditTxt.Location = new System.Drawing.Point(381, 202);
            this.creditTxt.Margin = new System.Windows.Forms.Padding(2);
            this.creditTxt.Name = "creditTxt";
            this.creditTxt.Size = new System.Drawing.Size(92, 20);
            this.creditTxt.TabIndex = 13;
            // 
            // signUpbtn
            // 
            this.signUpbtn.BackColor = System.Drawing.Color.DarkRed;
            this.signUpbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.signUpbtn.Location = new System.Drawing.Point(216, 250);
            this.signUpbtn.Margin = new System.Windows.Forms.Padding(2);
            this.signUpbtn.Name = "signUpbtn";
            this.signUpbtn.Size = new System.Drawing.Size(88, 29);
            this.signUpbtn.TabIndex = 15;
            this.signUpbtn.Text = "Sign Up";
            this.signUpbtn.UseVisualStyleBackColor = false;
            this.signUpbtn.Click += new System.EventHandler(this.signUpbtn_Click);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(118, 145);
            this.dateTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(146, 20);
            this.dateTimePicker.TabIndex = 16;
            // 
            // typePick
            // 
            this.typePick.FormattingEnabled = true;
            this.typePick.Items.AddRange(new object[] {
            "Basic",
            "Standard",
            "Premium"});
            this.typePick.Location = new System.Drawing.Point(381, 84);
            this.typePick.Margin = new System.Windows.Forms.Padding(2);
            this.typePick.Name = "typePick";
            this.typePick.Size = new System.Drawing.Size(111, 21);
            this.typePick.TabIndex = 17;
            this.typePick.SelectedIndexChanged += new System.EventHandler(this.typePick_SelectedIndexChanged);
            // 
            // login
            // 
            this.login.AutoSize = true;
            this.login.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.login.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.login.Location = new System.Drawing.Point(532, 230);
            this.login.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(131, 13);
            this.login.TabIndex = 18;
            this.login.Text = "already have an account?";
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.Color.Maroon;
            this.loginBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.loginBtn.Location = new System.Drawing.Point(550, 250);
            this.loginBtn.Margin = new System.Windows.Forms.Padding(2);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(99, 29);
            this.loginBtn.TabIndex = 19;
            this.loginBtn.Text = "Log In";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmSignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::agam.Properties.Resources.netflix;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(714, 324);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.login);
            this.Controls.Add(this.typePick);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.signUpbtn);
            this.Controls.Add(this.creditTxt);
            this.Controls.Add(this.passwordTxt);
            this.Controls.Add(this.idTxt);
            this.Controls.Add(this.nameTxt);
            this.Controls.Add(this.phoneTxt);
            this.Controls.Add(this.creditCardNum);
            this.Controls.Add(this.accountType);
            this.Controls.Add(this.password);
            this.Controls.Add(this.phoneNumber);
            this.Controls.Add(this.dateOfBirth);
            this.Controls.Add(this.id);
            this.Controls.Add(this.name);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmSignUp";
            this.Text = "frmSignUp";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label id;
        private System.Windows.Forms.Label dateOfBirth;
        private System.Windows.Forms.Label phoneNumber;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Label accountType;
        private System.Windows.Forms.Label creditCardNum;
        private System.Windows.Forms.TextBox phoneTxt;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.TextBox idTxt;
        private System.Windows.Forms.TextBox passwordTxt;
        private System.Windows.Forms.TextBox creditTxt;
        private System.Windows.Forms.Button signUpbtn;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.ComboBox typePick;
        private System.Windows.Forms.Label login;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}