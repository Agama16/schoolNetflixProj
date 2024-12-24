
namespace agam.Forms
{
    partial class frmAccountsM
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
            this.accountsGrid = new System.Windows.Forms.DataGridView();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.accountNumTxt = new System.Windows.Forms.TextBox();
            this.idTxt = new System.Windows.Forms.TextBox();
            this.phoneNumTxt = new System.Windows.Forms.TextBox();
            this.chargeTxt = new System.Windows.Forms.TextBox();
            this.passwordTxt = new System.Windows.Forms.TextBox();
            this.creditCardTxt = new System.Windows.Forms.TextBox();
            this.creditCard = new System.Windows.Forms.Label();
            this.charge = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.phoneNum = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.accountNum = new System.Windows.Forms.Label();
            this.dateOfBirth = new System.Windows.Forms.Label();
            this.accountType = new System.Windows.Forms.Label();
            this.dateOfBirthPick = new System.Windows.Forms.DateTimePicker();
            this.accountTypePick = new System.Windows.Forms.ComboBox();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.addBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.nextBtn = new System.Windows.Forms.Button();
            this.addNewBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.accountsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // accountsGrid
            // 
            this.accountsGrid.BackgroundColor = System.Drawing.Color.White;
            this.accountsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.accountsGrid.Location = new System.Drawing.Point(478, 128);
            this.accountsGrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.accountsGrid.Name = "accountsGrid";
            this.accountsGrid.RowHeadersWidth = 62;
            this.accountsGrid.RowTemplate.Height = 33;
            this.accountsGrid.Size = new System.Drawing.Size(800, 394);
            this.accountsGrid.TabIndex = 0;
            this.accountsGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.accountsGrid_CellContentClick);
            this.accountsGrid.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.accountsGrid_RowHeaderMouseClick);
            // 
            // nameTxt
            // 
            this.nameTxt.Enabled = false;
            this.nameTxt.Location = new System.Drawing.Point(296, 355);
            this.nameTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(134, 26);
            this.nameTxt.TabIndex = 1;
            // 
            // accountNumTxt
            // 
            this.accountNumTxt.Enabled = false;
            this.accountNumTxt.Location = new System.Drawing.Point(296, 88);
            this.accountNumTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.accountNumTxt.Name = "accountNumTxt";
            this.accountNumTxt.Size = new System.Drawing.Size(134, 26);
            this.accountNumTxt.TabIndex = 2;
            // 
            // idTxt
            // 
            this.idTxt.Enabled = false;
            this.idTxt.Location = new System.Drawing.Point(296, 140);
            this.idTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.idTxt.Name = "idTxt";
            this.idTxt.Size = new System.Drawing.Size(134, 26);
            this.idTxt.TabIndex = 3;
            // 
            // phoneNumTxt
            // 
            this.phoneNumTxt.Enabled = false;
            this.phoneNumTxt.Location = new System.Drawing.Point(296, 194);
            this.phoneNumTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.phoneNumTxt.Name = "phoneNumTxt";
            this.phoneNumTxt.Size = new System.Drawing.Size(134, 26);
            this.phoneNumTxt.TabIndex = 4;
            // 
            // chargeTxt
            // 
            this.chargeTxt.Enabled = false;
            this.chargeTxt.Location = new System.Drawing.Point(296, 305);
            this.chargeTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chargeTxt.Name = "chargeTxt";
            this.chargeTxt.Size = new System.Drawing.Size(134, 26);
            this.chargeTxt.TabIndex = 5;
            // 
            // passwordTxt
            // 
            this.passwordTxt.Enabled = false;
            this.passwordTxt.Location = new System.Drawing.Point(296, 408);
            this.passwordTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.Size = new System.Drawing.Size(134, 26);
            this.passwordTxt.TabIndex = 6;
            // 
            // creditCardTxt
            // 
            this.creditCardTxt.Enabled = false;
            this.creditCardTxt.Location = new System.Drawing.Point(296, 457);
            this.creditCardTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.creditCardTxt.Name = "creditCardTxt";
            this.creditCardTxt.Size = new System.Drawing.Size(134, 26);
            this.creditCardTxt.TabIndex = 7;
            // 
            // creditCard
            // 
            this.creditCard.AutoSize = true;
            this.creditCard.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.creditCard.Location = new System.Drawing.Point(44, 462);
            this.creditCard.Name = "creditCard";
            this.creditCard.Size = new System.Drawing.Size(83, 20);
            this.creditCard.TabIndex = 8;
            this.creditCard.Text = "credit card";
            // 
            // charge
            // 
            this.charge.AutoSize = true;
            this.charge.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.charge.Location = new System.Drawing.Point(44, 305);
            this.charge.Name = "charge";
            this.charge.Size = new System.Drawing.Size(58, 20);
            this.charge.TabIndex = 9;
            this.charge.Text = "charge";
            this.charge.Click += new System.EventHandler(this.charge_Click);
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.password.Location = new System.Drawing.Point(44, 408);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(77, 20);
            this.password.TabIndex = 10;
            this.password.Text = "password";
            // 
            // phoneNum
            // 
            this.phoneNum.AutoSize = true;
            this.phoneNum.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.phoneNum.Location = new System.Drawing.Point(44, 198);
            this.phoneNum.Name = "phoneNum";
            this.phoneNum.Size = new System.Drawing.Size(112, 20);
            this.phoneNum.TabIndex = 11;
            this.phoneNum.Text = "phone number";
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.id.Location = new System.Drawing.Point(44, 140);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(21, 20);
            this.id.TabIndex = 12;
            this.id.Text = "id";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.name.Location = new System.Drawing.Point(44, 355);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(49, 20);
            this.name.TabIndex = 13;
            this.name.Text = "name";
            // 
            // accountNum
            // 
            this.accountNum.AutoSize = true;
            this.accountNum.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.accountNum.Location = new System.Drawing.Point(30, 88);
            this.accountNum.Name = "accountNum";
            this.accountNum.Size = new System.Drawing.Size(124, 20);
            this.accountNum.TabIndex = 14;
            this.accountNum.Text = "account number";
            // 
            // dateOfBirth
            // 
            this.dateOfBirth.AutoSize = true;
            this.dateOfBirth.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.dateOfBirth.Location = new System.Drawing.Point(44, 245);
            this.dateOfBirth.Name = "dateOfBirth";
            this.dateOfBirth.Size = new System.Drawing.Size(94, 20);
            this.dateOfBirth.TabIndex = 15;
            this.dateOfBirth.Text = "date of birth";
            // 
            // accountType
            // 
            this.accountType.AutoSize = true;
            this.accountType.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.accountType.Location = new System.Drawing.Point(44, 515);
            this.accountType.Name = "accountType";
            this.accountType.Size = new System.Drawing.Size(100, 20);
            this.accountType.TabIndex = 16;
            this.accountType.Text = "account type";
            // 
            // dateOfBirthPick
            // 
            this.dateOfBirthPick.Enabled = false;
            this.dateOfBirthPick.Location = new System.Drawing.Point(160, 245);
            this.dateOfBirthPick.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateOfBirthPick.Name = "dateOfBirthPick";
            this.dateOfBirthPick.Size = new System.Drawing.Size(270, 26);
            this.dateOfBirthPick.TabIndex = 17;
            // 
            // accountTypePick
            // 
            this.accountTypePick.Enabled = false;
            this.accountTypePick.FormattingEnabled = true;
            this.accountTypePick.Items.AddRange(new object[] {
            "Basic",
            "Standard",
            "Premium"});
            this.accountTypePick.Location = new System.Drawing.Point(296, 511);
            this.accountTypePick.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.accountTypePick.Name = "accountTypePick";
            this.accountTypePick.Size = new System.Drawing.Size(134, 28);
            this.accountTypePick.TabIndex = 18;
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.Black;
            this.addBtn.Enabled = false;
            this.addBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.addBtn.Location = new System.Drawing.Point(920, 528);
            this.addBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(142, 38);
            this.addBtn.TabIndex = 19;
            this.addBtn.Text = "save";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // editBtn
            // 
            this.editBtn.BackColor = System.Drawing.Color.Black;
            this.editBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.editBtn.Location = new System.Drawing.Point(785, 528);
            this.editBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(129, 38);
            this.editBtn.TabIndex = 21;
            this.editBtn.Text = "Edit";
            this.editBtn.UseVisualStyleBackColor = false;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // nextBtn
            // 
            this.nextBtn.BackColor = System.Drawing.Color.Black;
            this.nextBtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.nextBtn.Location = new System.Drawing.Point(1146, 526);
            this.nextBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(120, 40);
            this.nextBtn.TabIndex = 23;
            this.nextBtn.Text = "Next";
            this.nextBtn.UseVisualStyleBackColor = false;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // addNewBtn
            // 
            this.addNewBtn.BackColor = System.Drawing.Color.Black;
            this.addNewBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.addNewBtn.Location = new System.Drawing.Point(651, 526);
            this.addNewBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addNewBtn.Name = "addNewBtn";
            this.addNewBtn.Size = new System.Drawing.Size(128, 40);
            this.addNewBtn.TabIndex = 24;
            this.addNewBtn.Text = "Add New";
            this.addNewBtn.UseVisualStyleBackColor = false;
            this.addNewBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkRed;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(-27, -2);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(1383, 68);
            this.button1.TabIndex = 26;
            this.button1.Text = "Accounts";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.Black;
            this.backBtn.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.ForeColor = System.Drawing.Color.DarkRed;
            this.backBtn.Location = new System.Drawing.Point(752, 573);
            this.backBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(194, 66);
            this.backBtn.TabIndex = 35;
            this.backBtn.Text = "back to main";
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(568, 97);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(563, 26);
            this.searchBox.TabIndex = 38;
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1137, 92);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 36);
            this.button2.TabIndex = 39;
            this.button2.Text = "search";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = global::agam.Properties.Resources.refresh;
            this.pictureBox1.Location = new System.Drawing.Point(508, 87);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(54, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 40;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // frmAccountsM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1323, 662);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.addNewBtn);
            this.Controls.Add(this.nextBtn);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.accountTypePick);
            this.Controls.Add(this.dateOfBirthPick);
            this.Controls.Add(this.accountType);
            this.Controls.Add(this.dateOfBirth);
            this.Controls.Add(this.accountNum);
            this.Controls.Add(this.name);
            this.Controls.Add(this.id);
            this.Controls.Add(this.phoneNum);
            this.Controls.Add(this.password);
            this.Controls.Add(this.charge);
            this.Controls.Add(this.creditCard);
            this.Controls.Add(this.creditCardTxt);
            this.Controls.Add(this.passwordTxt);
            this.Controls.Add(this.chargeTxt);
            this.Controls.Add(this.phoneNumTxt);
            this.Controls.Add(this.idTxt);
            this.Controls.Add(this.accountNumTxt);
            this.Controls.Add(this.nameTxt);
            this.Controls.Add(this.accountsGrid);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmAccountsM";
            this.Text = "frmAccountsM";
            this.Load += new System.EventHandler(this.frmAccountsM_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.accountsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView accountsGrid;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.TextBox accountNumTxt;
        private System.Windows.Forms.TextBox idTxt;
        private System.Windows.Forms.TextBox phoneNumTxt;
        private System.Windows.Forms.TextBox chargeTxt;
        private System.Windows.Forms.TextBox passwordTxt;
        private System.Windows.Forms.TextBox creditCardTxt;
        private System.Windows.Forms.Label creditCard;
        private System.Windows.Forms.Label charge;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Label phoneNum;
        private System.Windows.Forms.Label id;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label accountNum;
        private System.Windows.Forms.Label dateOfBirth;
        private System.Windows.Forms.Label accountType;
        private System.Windows.Forms.DateTimePicker dateOfBirthPick;
        private System.Windows.Forms.ComboBox accountTypePick;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Button addBtn;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button nextBtn;
        private System.Windows.Forms.Button addNewBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}