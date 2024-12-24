
namespace agam.Forms
{
    partial class frmUsersM
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
            this.usersGrid = new System.Windows.Forms.DataGridView();
            this.dateOfBirth = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.Label();
            this.accountNum = new System.Windows.Forms.Label();
            this.birthPick = new System.Windows.Forms.DateTimePicker();
            this.accountNumTxt = new System.Windows.Forms.TextBox();
            this.userTxt = new System.Windows.Forms.TextBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.prevBtn = new System.Windows.Forms.Button();
            this.nextBtn = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.usersGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // usersGrid
            // 
            this.usersGrid.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.usersGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usersGrid.Location = new System.Drawing.Point(262, 50);
            this.usersGrid.Margin = new System.Windows.Forms.Padding(2);
            this.usersGrid.Name = "usersGrid";
            this.usersGrid.RowHeadersWidth = 62;
            this.usersGrid.RowTemplate.Height = 28;
            this.usersGrid.Size = new System.Drawing.Size(451, 178);
            this.usersGrid.TabIndex = 0;
            // 
            // dateOfBirth
            // 
            this.dateOfBirth.AutoSize = true;
            this.dateOfBirth.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.dateOfBirth.Location = new System.Drawing.Point(21, 121);
            this.dateOfBirth.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dateOfBirth.Name = "dateOfBirth";
            this.dateOfBirth.Size = new System.Drawing.Size(68, 13);
            this.dateOfBirth.TabIndex = 1;
            this.dateOfBirth.Text = "Date Of Birth";
            this.dateOfBirth.Click += new System.EventHandler(this.label1_Click);
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.username.Location = new System.Drawing.Point(21, 77);
            this.username.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(55, 13);
            this.username.TabIndex = 2;
            this.username.Text = "Username";
            // 
            // accountNum
            // 
            this.accountNum.AutoSize = true;
            this.accountNum.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.accountNum.Location = new System.Drawing.Point(21, 169);
            this.accountNum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.accountNum.Name = "accountNum";
            this.accountNum.Size = new System.Drawing.Size(87, 13);
            this.accountNum.TabIndex = 3;
            this.accountNum.Text = "Account Number";
            // 
            // birthPick
            // 
            this.birthPick.Location = new System.Drawing.Point(117, 121);
            this.birthPick.Margin = new System.Windows.Forms.Padding(2);
            this.birthPick.Name = "birthPick";
            this.birthPick.Size = new System.Drawing.Size(117, 20);
            this.birthPick.TabIndex = 4;
            // 
            // accountNumTxt
            // 
            this.accountNumTxt.Location = new System.Drawing.Point(166, 169);
            this.accountNumTxt.Margin = new System.Windows.Forms.Padding(2);
            this.accountNumTxt.Name = "accountNumTxt";
            this.accountNumTxt.Size = new System.Drawing.Size(68, 20);
            this.accountNumTxt.TabIndex = 5;
            this.accountNumTxt.TextChanged += new System.EventHandler(this.accountNumTxt_TextChanged);
            // 
            // userTxt
            // 
            this.userTxt.Location = new System.Drawing.Point(166, 77);
            this.userTxt.Margin = new System.Windows.Forms.Padding(2);
            this.userTxt.Name = "userTxt";
            this.userTxt.Size = new System.Drawing.Size(68, 20);
            this.userTxt.TabIndex = 6;
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.Black;
            this.addBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.addBtn.Location = new System.Drawing.Point(402, 242);
            this.addBtn.Margin = new System.Windows.Forms.Padding(2);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(91, 28);
            this.addBtn.TabIndex = 17;
            this.addBtn.Text = "Save";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.BackColor = System.Drawing.Color.Black;
            this.clearBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.clearBtn.Location = new System.Drawing.Point(318, 242);
            this.clearBtn.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(80, 28);
            this.clearBtn.TabIndex = 26;
            this.clearBtn.Text = "Add New";
            this.clearBtn.UseVisualStyleBackColor = false;
            // 
            // editBtn
            // 
            this.editBtn.BackColor = System.Drawing.Color.Black;
            this.editBtn.ForeColor = System.Drawing.SystemColors.Window;
            this.editBtn.Location = new System.Drawing.Point(497, 243);
            this.editBtn.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(82, 26);
            this.editBtn.TabIndex = 28;
            this.editBtn.Text = "Edit";
            this.editBtn.UseVisualStyleBackColor = false;
            // 
            // prevBtn
            // 
            this.prevBtn.BackColor = System.Drawing.Color.Black;
            this.prevBtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.prevBtn.Location = new System.Drawing.Point(11, 243);
            this.prevBtn.Margin = new System.Windows.Forms.Padding(2);
            this.prevBtn.Name = "prevBtn";
            this.prevBtn.Size = new System.Drawing.Size(88, 27);
            this.prevBtn.TabIndex = 29;
            this.prevBtn.Text = "prev";
            this.prevBtn.UseVisualStyleBackColor = false;
            this.prevBtn.Click += new System.EventHandler(this.prevBtn_Click);
            // 
            // nextBtn
            // 
            this.nextBtn.BackColor = System.Drawing.Color.Black;
            this.nextBtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.nextBtn.Location = new System.Drawing.Point(638, 243);
            this.nextBtn.Margin = new System.Windows.Forms.Padding(2);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(90, 27);
            this.nextBtn.TabIndex = 31;
            this.nextBtn.Text = "Next";
            this.nextBtn.UseVisualStyleBackColor = false;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::agam.Properties.Resources.Netflix_Symbol1;
            this.pictureBox1.Location = new System.Drawing.Point(-88, 300);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(876, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Maroon;
            this.button1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button1.Location = new System.Drawing.Point(-43, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(787, 31);
            this.button1.TabIndex = 33;
            this.button1.Text = "Users";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // frmUsersM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(739, 392);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.nextBtn);
            this.Controls.Add(this.prevBtn);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.userTxt);
            this.Controls.Add(this.accountNumTxt);
            this.Controls.Add(this.birthPick);
            this.Controls.Add(this.accountNum);
            this.Controls.Add(this.username);
            this.Controls.Add(this.dateOfBirth);
            this.Controls.Add(this.usersGrid);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmUsersM";
            this.Text = "frmUsersM";
            this.Load += new System.EventHandler(this.frmUsersM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usersGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView usersGrid;
        private System.Windows.Forms.Label dateOfBirth;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Label accountNum;
        private System.Windows.Forms.DateTimePicker birthPick;
        private System.Windows.Forms.TextBox accountNumTxt;
        private System.Windows.Forms.TextBox userTxt;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Button prevBtn;
        private System.Windows.Forms.Button nextBtn;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
    }
}