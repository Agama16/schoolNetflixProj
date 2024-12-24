
namespace agam.Forms
{
    partial class FrmAccountTypesM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAccountTypesM));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.typeName = new System.Windows.Forms.Label();
            this.charge = new System.Windows.Forms.Label();
            this.chargeTxt = new System.Windows.Forms.TextBox();
            this.typeNameTxt = new System.Windows.Forms.TextBox();
            this.header = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.addNewBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.prevBtn = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(324, 77);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(597, 243);
            this.dataGridView1.TabIndex = 0;
            // 
            // typeName
            // 
            this.typeName.AutoSize = true;
            this.typeName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.typeName.Location = new System.Drawing.Point(42, 125);
            this.typeName.Name = "typeName";
            this.typeName.Size = new System.Drawing.Size(106, 20);
            this.typeName.TabIndex = 1;
            this.typeName.Text = "Account Type";
            // 
            // charge
            // 
            this.charge.AutoSize = true;
            this.charge.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.charge.Location = new System.Drawing.Point(42, 204);
            this.charge.Name = "charge";
            this.charge.Size = new System.Drawing.Size(61, 20);
            this.charge.TabIndex = 2;
            this.charge.Text = "Charge";
            // 
            // chargeTxt
            // 
            this.chargeTxt.Location = new System.Drawing.Point(178, 198);
            this.chargeTxt.Name = "chargeTxt";
            this.chargeTxt.Size = new System.Drawing.Size(100, 26);
            this.chargeTxt.TabIndex = 3;
            // 
            // typeNameTxt
            // 
            this.typeNameTxt.Location = new System.Drawing.Point(178, 119);
            this.typeNameTxt.Name = "typeNameTxt";
            this.typeNameTxt.Size = new System.Drawing.Size(100, 26);
            this.typeNameTxt.TabIndex = 4;
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.DarkRed;
            this.header.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.header.Location = new System.Drawing.Point(-148, -3);
            this.header.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(1322, 51);
            this.header.TabIndex = 27;
            this.header.Text = "Account Types";
            this.header.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = global::agam.Properties.Resources.Netflix_Symbol1;
            this.pictureBox1.Location = new System.Drawing.Point(-217, 414);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1458, 107);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // addNewBtn
            // 
            this.addNewBtn.BackColor = System.Drawing.Color.Black;
            this.addNewBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.addNewBtn.Location = new System.Drawing.Point(427, 338);
            this.addNewBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addNewBtn.Name = "addNewBtn";
            this.addNewBtn.Size = new System.Drawing.Size(128, 40);
            this.addNewBtn.TabIndex = 29;
            this.addNewBtn.Text = "Add New";
            this.addNewBtn.UseVisualStyleBackColor = false;
            this.addNewBtn.Click += new System.EventHandler(this.addNewBtn_Click);
            // 
            // editBtn
            // 
            this.editBtn.BackColor = System.Drawing.Color.Black;
            this.editBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.editBtn.Location = new System.Drawing.Point(561, 338);
            this.editBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(129, 38);
            this.editBtn.TabIndex = 30;
            this.editBtn.Text = "Edit";
            this.editBtn.UseVisualStyleBackColor = false;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.Black;
            this.addBtn.Enabled = false;
            this.addBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.addBtn.Location = new System.Drawing.Point(696, 338);
            this.addBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(142, 38);
            this.addBtn.TabIndex = 31;
            this.addBtn.Text = "save";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // prevBtn
            // 
            this.prevBtn.BackColor = System.Drawing.Color.Black;
            this.prevBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.prevBtn.Location = new System.Drawing.Point(46, 338);
            this.prevBtn.Name = "prevBtn";
            this.prevBtn.Size = new System.Drawing.Size(120, 40);
            this.prevBtn.TabIndex = 32;
            this.prevBtn.Text = "prev";
            this.prevBtn.UseVisualStyleBackColor = false;
            this.prevBtn.Click += new System.EventHandler(this.prevBtn_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmAccountTypesM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1030, 520);
            this.Controls.Add(this.prevBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.addNewBtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.header);
            this.Controls.Add(this.typeNameTxt);
            this.Controls.Add(this.chargeTxt);
            this.Controls.Add(this.charge);
            this.Controls.Add(this.typeName);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmAccountTypesM";
            this.Text = "FrmAccountTypesM";
            this.Load += new System.EventHandler(this.FrmAccountTypesM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label typeName;
        private System.Windows.Forms.Label charge;
        private System.Windows.Forms.TextBox chargeTxt;
        private System.Windows.Forms.TextBox typeNameTxt;
        private System.Windows.Forms.Button header;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button addNewBtn;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button prevBtn;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}