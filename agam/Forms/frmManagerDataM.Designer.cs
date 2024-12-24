
namespace agam.Forms
{
    partial class frmManagerDataM
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
            this.AccountsBtn = new System.Windows.Forms.Button();
            this.UsersBtn = new System.Windows.Forms.Button();
            this.MoviesBtn = new System.Windows.Forms.Button();
            this.tvShowBtn = new System.Windows.Forms.Button();
            this.accountTypeBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AccountsBtn
            // 
            this.AccountsBtn.BackColor = System.Drawing.Color.Black;
            this.AccountsBtn.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountsBtn.ForeColor = System.Drawing.Color.Red;
            this.AccountsBtn.Location = new System.Drawing.Point(242, 374);
            this.AccountsBtn.Name = "AccountsBtn";
            this.AccountsBtn.Size = new System.Drawing.Size(140, 109);
            this.AccountsBtn.TabIndex = 1;
            this.AccountsBtn.Text = "Accounts";
            this.AccountsBtn.UseVisualStyleBackColor = false;
            this.AccountsBtn.Click += new System.EventHandler(this.AccountsBtn_Click);
            // 
            // UsersBtn
            // 
            this.UsersBtn.BackColor = System.Drawing.Color.Black;
            this.UsersBtn.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsersBtn.ForeColor = System.Drawing.Color.Red;
            this.UsersBtn.Location = new System.Drawing.Point(387, 374);
            this.UsersBtn.Name = "UsersBtn";
            this.UsersBtn.Size = new System.Drawing.Size(140, 109);
            this.UsersBtn.TabIndex = 2;
            this.UsersBtn.Text = "Users";
            this.UsersBtn.UseVisualStyleBackColor = false;
            this.UsersBtn.Click += new System.EventHandler(this.UsersBtn_Click);
            // 
            // MoviesBtn
            // 
            this.MoviesBtn.BackColor = System.Drawing.Color.Black;
            this.MoviesBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MoviesBtn.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MoviesBtn.ForeColor = System.Drawing.Color.Red;
            this.MoviesBtn.Location = new System.Drawing.Point(96, 374);
            this.MoviesBtn.Name = "MoviesBtn";
            this.MoviesBtn.Size = new System.Drawing.Size(140, 109);
            this.MoviesBtn.TabIndex = 3;
            this.MoviesBtn.Text = "Movies";
            this.MoviesBtn.UseVisualStyleBackColor = false;
            this.MoviesBtn.Click += new System.EventHandler(this.MoviesBtn_Click);
            // 
            // tvShowBtn
            // 
            this.tvShowBtn.BackColor = System.Drawing.Color.Black;
            this.tvShowBtn.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tvShowBtn.ForeColor = System.Drawing.Color.Red;
            this.tvShowBtn.Location = new System.Drawing.Point(532, 374);
            this.tvShowBtn.Name = "tvShowBtn";
            this.tvShowBtn.Size = new System.Drawing.Size(140, 109);
            this.tvShowBtn.TabIndex = 4;
            this.tvShowBtn.Text = "Tv Shows";
            this.tvShowBtn.UseVisualStyleBackColor = false;
            this.tvShowBtn.Click += new System.EventHandler(this.tvShowBtn_Click);
            // 
            // accountTypeBtn
            // 
            this.accountTypeBtn.BackColor = System.Drawing.Color.Black;
            this.accountTypeBtn.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountTypeBtn.ForeColor = System.Drawing.Color.Red;
            this.accountTypeBtn.Location = new System.Drawing.Point(678, 374);
            this.accountTypeBtn.Name = "accountTypeBtn";
            this.accountTypeBtn.Size = new System.Drawing.Size(140, 109);
            this.accountTypeBtn.TabIndex = 5;
            this.accountTypeBtn.Text = "Account Types";
            this.accountTypeBtn.UseVisualStyleBackColor = false;
            this.accountTypeBtn.Click += new System.EventHandler(this.accountTypeBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(192, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(540, 36);
            this.label1.TabIndex = 6;
            this.label1.Text = "What database would you like to display?";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // frmManagerDataM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::agam.Properties.Resources.netflix;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(956, 589);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.accountTypeBtn);
            this.Controls.Add(this.tvShowBtn);
            this.Controls.Add(this.MoviesBtn);
            this.Controls.Add(this.UsersBtn);
            this.Controls.Add(this.AccountsBtn);
            this.Name = "frmManagerDataM";
            this.Text = "frmManagerDataM";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button AccountsBtn;
        private System.Windows.Forms.Button UsersBtn;
        private System.Windows.Forms.Button MoviesBtn;
        private System.Windows.Forms.Button tvShowBtn;
        private System.Windows.Forms.Button accountTypeBtn;
        private System.Windows.Forms.Label label1;
    }
}