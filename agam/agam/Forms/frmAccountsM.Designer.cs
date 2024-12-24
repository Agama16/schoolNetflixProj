
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAccountsM));
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.accountsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // accountsGrid
            // 
            this.accountsGrid.BackgroundColor = System.Drawing.Color.White;
            this.accountsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.accountsGrid.Location = new System.Drawing.Point(311, 57);
            this.accountsGrid.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.accountsGrid.Name = "accountsGrid";
            this.accountsGrid.RowHeadersWidth = 62;
            this.accountsGrid.RowTemplate.Height = 33;
            this.accountsGrid.Size = new System.Drawing.Size(533, 256);
            this.accountsGrid.TabIndex = 0;
            this.accountsGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.accountsGrid_CellContentClick);
            // 
            // nameTxt
            // 
            this.nameTxt.Enabled = false;
            this.nameTxt.Location = new System.Drawing.Point(197, 231);
            this.nameTxt.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(91, 20);
            this.nameTxt.TabIndex = 1;
            // 
            // accountNumTxt
            // 
            this.accountNumTxt.Enabled = false;
            this.accountNumTxt.Location = new System.Drawing.Point(197, 57);
            this.accountNumTxt.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.accountNumTxt.Name = "accountNumTxt";
            this.accountNumTxt.Size = new System.Drawing.Size(91, 20);
            this.accountNumTxt.TabIndex = 2;
            // 
            // idTxt
            // 
            this.idTxt.Enabled = false;
            this.idTxt.Location = new System.Drawing.Point(197, 91);
            this.idTxt.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.idTxt.Name = "idTxt";
            this.idTxt.Size = new System.Drawing.Size(91, 20);
            this.idTxt.TabIndex = 3;
            // 
            // phoneNumTxt
            // 
            this.phoneNumTxt.Enabled = false;
            this.phoneNumTxt.Location = new System.Drawing.Point(197, 126);
            this.phoneNumTxt.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.phoneNumTxt.Name = "phoneNumTxt";
            this.phoneNumTxt.Size = new System.Drawing.Size(91, 20);
            this.phoneNumTxt.TabIndex = 4;
            // 
            // chargeTxt
            // 
            this.chargeTxt.Enabled = false;
            this.chargeTxt.Location = new System.Drawing.Point(197, 198);
            this.chargeTxt.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.chargeTxt.Name = "chargeTxt";
            this.chargeTxt.Size = new System.Drawing.Size(91, 20);
            this.chargeTxt.TabIndex = 5;
            // 
            // passwordTxt
            // 
            this.passwordTxt.Enabled = false;
            this.passwordTxt.Location = new System.Drawing.Point(197, 265);
            this.passwordTxt.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.Size = new System.Drawing.Size(91, 20);
            this.passwordTxt.TabIndex = 6;
            // 
            // creditCardTxt
            // 
            this.creditCardTxt.Enabled = false;
            this.creditCardTxt.Location = new System.Drawing.Point(197, 297);
            this.creditCardTxt.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.creditCardTxt.Name = "creditCardTxt";
            this.creditCardTxt.Size = new System.Drawing.Size(91, 20);
            this.creditCardTxt.TabIndex = 7;
            // 
            // creditCard
            // 
            this.creditCard.AutoSize = true;
            this.creditCard.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.creditCard.Location = new System.Drawing.Point(29, 300);
            this.creditCard.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.creditCard.Name = "creditCard";
            this.creditCard.Size = new System.Drawing.Size(57, 13);
            this.creditCard.TabIndex = 8;
            this.creditCard.Text = "credit card";
            // 
            // charge
            // 
            this.charge.AutoSize = true;
            this.charge.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.charge.Location = new System.Drawing.Point(29, 198);
            this.charge.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.charge.Name = "charge";
            this.charge.Size = new System.Drawing.Size(40, 13);
            this.charge.TabIndex = 9;
            this.charge.Text = "charge";
            this.charge.Click += new System.EventHandler(this.charge_Click);
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.password.Location = new System.Drawing.Point(29, 265);
            this.password.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(52, 13);
            this.password.TabIndex = 10;
            this.password.Text = "password";
            // 
            // phoneNum
            // 
            this.phoneNum.AutoSize = true;
            this.phoneNum.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.phoneNum.Location = new System.Drawing.Point(29, 129);
            this.phoneNum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.phoneNum.Name = "phoneNum";
            this.phoneNum.Size = new System.Drawing.Size(75, 13);
            this.phoneNum.TabIndex = 11;
            this.phoneNum.Text = "phone number";
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.id.Location = new System.Drawing.Point(29, 91);
            this.id.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(15, 13);
            this.id.TabIndex = 12;
            this.id.Text = "id";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.name.Location = new System.Drawing.Point(29, 231);
            this.name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(33, 13);
            this.name.TabIndex = 13;
            this.name.Text = "name";
            // 
            // accountNum
            // 
            this.accountNum.AutoSize = true;
            this.accountNum.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.accountNum.Location = new System.Drawing.Point(20, 57);
            this.accountNum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.accountNum.Name = "accountNum";
            this.accountNum.Size = new System.Drawing.Size(84, 13);
            this.accountNum.TabIndex = 14;
            this.accountNum.Text = "account number";
            // 
            // dateOfBirth
            // 
            this.dateOfBirth.AutoSize = true;
            this.dateOfBirth.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.dateOfBirth.Location = new System.Drawing.Point(29, 159);
            this.dateOfBirth.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dateOfBirth.Name = "dateOfBirth";
            this.dateOfBirth.Size = new System.Drawing.Size(63, 13);
            this.dateOfBirth.TabIndex = 15;
            this.dateOfBirth.Text = "date of birth";
            // 
            // accountType
            // 
            this.accountType.AutoSize = true;
            this.accountType.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.accountType.Location = new System.Drawing.Point(29, 335);
            this.accountType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.accountType.Name = "accountType";
            this.accountType.Size = new System.Drawing.Size(69, 13);
            this.accountType.TabIndex = 16;
            this.accountType.Text = "account type";
            // 
            // dateOfBirthPick
            // 
            this.dateOfBirthPick.Enabled = false;
            this.dateOfBirthPick.Location = new System.Drawing.Point(107, 159);
            this.dateOfBirthPick.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.dateOfBirthPick.Name = "dateOfBirthPick";
            this.dateOfBirthPick.Size = new System.Drawing.Size(181, 20);
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
            this.accountTypePick.Location = new System.Drawing.Point(197, 332);
            this.accountTypePick.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.accountTypePick.Name = "accountTypePick";
            this.accountTypePick.Size = new System.Drawing.Size(91, 21);
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
            this.addBtn.Location = new System.Drawing.Point(603, 332);
            this.addBtn.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(95, 25);
            this.addBtn.TabIndex = 19;
            this.addBtn.Text = "save";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // editBtn
            // 
            this.editBtn.BackColor = System.Drawing.Color.Black;
            this.editBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.editBtn.Location = new System.Drawing.Point(513, 332);
            this.editBtn.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(86, 25);
            this.editBtn.TabIndex = 21;
            this.editBtn.Text = "Edit";
            this.editBtn.UseVisualStyleBackColor = false;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // nextBtn
            // 
            this.nextBtn.BackColor = System.Drawing.Color.Black;
            this.nextBtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.nextBtn.Location = new System.Drawing.Point(764, 332);
            this.nextBtn.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(80, 26);
            this.nextBtn.TabIndex = 23;
            this.nextBtn.Text = "Next";
            this.nextBtn.UseVisualStyleBackColor = false;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // addNewBtn
            // 
            this.addNewBtn.BackColor = System.Drawing.Color.Black;
            this.addNewBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.addNewBtn.Location = new System.Drawing.Point(424, 332);
            this.addNewBtn.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.addNewBtn.Name = "addNewBtn";
            this.addNewBtn.Size = new System.Drawing.Size(85, 26);
            this.addNewBtn.TabIndex = 24;
            this.addNewBtn.Text = "Add New";
            this.addNewBtn.UseVisualStyleBackColor = false;
            this.addNewBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = global::agam.Properties.Resources.Netflix_Symbol1;
            this.pictureBox1.Location = new System.Drawing.Point(-78, 376);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(972, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkRed;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(-18, -1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(881, 33);
            this.button1.TabIndex = 26;
            this.button1.Text = "Accounts";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // frmAccountsM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(858, 472);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
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
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
    }
}