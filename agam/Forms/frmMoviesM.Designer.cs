
namespace agam.Forms
{
    partial class frmMoviesM
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
            this.moviesGrid = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.description = new System.Windows.Forms.Label();
            this.ageLimit = new System.Windows.Forms.Label();
            this.genre = new System.Windows.Forms.Label();
            this.releaseDate = new System.Windows.Forms.Label();
            this.producer = new System.Windows.Forms.Label();
            this.movieName = new System.Windows.Forms.Label();
            this.releasePick = new System.Windows.Forms.DateTimePicker();
            this.producerTxt = new System.Windows.Forms.TextBox();
            this.movieTxt = new System.Windows.Forms.TextBox();
            this.genreTxt = new System.Windows.Forms.TextBox();
            this.ageLimitTxt = new System.Windows.Forms.TextBox();
            this.descriptionTxt = new System.Windows.Forms.TextBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.prevBtn = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.nextBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.movieCode = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.searchBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.moviesGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // moviesGrid
            // 
            this.moviesGrid.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.moviesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.moviesGrid.Location = new System.Drawing.Point(334, 165);
            this.moviesGrid.Name = "moviesGrid";
            this.moviesGrid.RowHeadersWidth = 62;
            this.moviesGrid.RowTemplate.Height = 28;
            this.moviesGrid.Size = new System.Drawing.Size(664, 366);
            this.moviesGrid.TabIndex = 0;
            this.moviesGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.moviesGrid_CellContentClick);
            // 
            // description
            // 
            this.description.AutoSize = true;
            this.description.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.description.Location = new System.Drawing.Point(12, 409);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(89, 20);
            this.description.TabIndex = 1;
            this.description.Text = "Description";
            // 
            // ageLimit
            // 
            this.ageLimit.AutoSize = true;
            this.ageLimit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ageLimit.Location = new System.Drawing.Point(12, 351);
            this.ageLimit.Name = "ageLimit";
            this.ageLimit.Size = new System.Drawing.Size(75, 20);
            this.ageLimit.TabIndex = 2;
            this.ageLimit.Text = "Age Limit";
            // 
            // genre
            // 
            this.genre.AutoSize = true;
            this.genre.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.genre.Location = new System.Drawing.Point(12, 294);
            this.genre.Name = "genre";
            this.genre.Size = new System.Drawing.Size(54, 20);
            this.genre.TabIndex = 3;
            this.genre.Text = "Genre";
            // 
            // releaseDate
            // 
            this.releaseDate.AutoSize = true;
            this.releaseDate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.releaseDate.Location = new System.Drawing.Point(12, 235);
            this.releaseDate.Name = "releaseDate";
            this.releaseDate.Size = new System.Drawing.Size(107, 20);
            this.releaseDate.TabIndex = 4;
            this.releaseDate.Text = "Release Date";
            // 
            // producer
            // 
            this.producer.AutoSize = true;
            this.producer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.producer.Location = new System.Drawing.Point(12, 171);
            this.producer.Name = "producer";
            this.producer.Size = new System.Drawing.Size(119, 20);
            this.producer.TabIndex = 5;
            this.producer.Text = "Producer Name";
            this.producer.Click += new System.EventHandler(this.label5_Click);
            // 
            // movieName
            // 
            this.movieName.AutoSize = true;
            this.movieName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.movieName.Location = new System.Drawing.Point(20, 115);
            this.movieName.Name = "movieName";
            this.movieName.Size = new System.Drawing.Size(96, 20);
            this.movieName.TabIndex = 6;
            this.movieName.Text = "Movie Name";
            // 
            // releasePick
            // 
            this.releasePick.Location = new System.Drawing.Point(128, 235);
            this.releasePick.Name = "releasePick";
            this.releasePick.Size = new System.Drawing.Size(200, 26);
            this.releasePick.TabIndex = 7;
            // 
            // producerTxt
            // 
            this.producerTxt.Location = new System.Drawing.Point(136, 171);
            this.producerTxt.Name = "producerTxt";
            this.producerTxt.Size = new System.Drawing.Size(100, 26);
            this.producerTxt.TabIndex = 8;
            // 
            // movieTxt
            // 
            this.movieTxt.Location = new System.Drawing.Point(136, 109);
            this.movieTxt.Name = "movieTxt";
            this.movieTxt.Size = new System.Drawing.Size(100, 26);
            this.movieTxt.TabIndex = 9;
            // 
            // genreTxt
            // 
            this.genreTxt.Location = new System.Drawing.Point(136, 294);
            this.genreTxt.Name = "genreTxt";
            this.genreTxt.Size = new System.Drawing.Size(100, 26);
            this.genreTxt.TabIndex = 10;
            // 
            // ageLimitTxt
            // 
            this.ageLimitTxt.Location = new System.Drawing.Point(136, 351);
            this.ageLimitTxt.Name = "ageLimitTxt";
            this.ageLimitTxt.Size = new System.Drawing.Size(100, 26);
            this.ageLimitTxt.TabIndex = 11;
            // 
            // descriptionTxt
            // 
            this.descriptionTxt.Location = new System.Drawing.Point(136, 398);
            this.descriptionTxt.Name = "descriptionTxt";
            this.descriptionTxt.Size = new System.Drawing.Size(100, 26);
            this.descriptionTxt.TabIndex = 12;
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.Black;
            this.addBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.addBtn.Location = new System.Drawing.Point(513, 539);
            this.addBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(142, 43);
            this.addBtn.TabIndex = 20;
            this.addBtn.Text = "Save";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.BackColor = System.Drawing.Color.Black;
            this.clearBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.clearBtn.Location = new System.Drawing.Point(355, 537);
            this.clearBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(152, 45);
            this.clearBtn.TabIndex = 25;
            this.clearBtn.Text = "Add new";
            this.clearBtn.UseVisualStyleBackColor = false;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // editBtn
            // 
            this.editBtn.BackColor = System.Drawing.Color.Black;
            this.editBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.editBtn.Location = new System.Drawing.Point(661, 539);
            this.editBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(134, 43);
            this.editBtn.TabIndex = 27;
            this.editBtn.Text = "Edit";
            this.editBtn.UseVisualStyleBackColor = false;
            // 
            // prevBtn
            // 
            this.prevBtn.BackColor = System.Drawing.Color.Black;
            this.prevBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.prevBtn.Location = new System.Drawing.Point(24, 535);
            this.prevBtn.Name = "prevBtn";
            this.prevBtn.Size = new System.Drawing.Size(146, 46);
            this.prevBtn.TabIndex = 28;
            this.prevBtn.Text = "prev";
            this.prevBtn.UseVisualStyleBackColor = false;
            this.prevBtn.Click += new System.EventHandler(this.prevBtn_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Maroon;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(-34, -3);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(1152, 72);
            this.button1.TabIndex = 30;
            this.button1.Text = "Movies";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // nextBtn
            // 
            this.nextBtn.BackColor = System.Drawing.Color.Black;
            this.nextBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.nextBtn.Location = new System.Drawing.Point(973, 537);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(128, 43);
            this.nextBtn.TabIndex = 31;
            this.nextBtn.Text = "Next";
            this.nextBtn.UseVisualStyleBackColor = false;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.Black;
            this.backBtn.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.ForeColor = System.Drawing.Color.DarkRed;
            this.backBtn.Location = new System.Drawing.Point(490, 589);
            this.backBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(184, 66);
            this.backBtn.TabIndex = 35;
            this.backBtn.Text = "back to main";
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(18, 462);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 36;
            this.label1.Text = "Movie Code";
            // 
            // movieCode
            // 
            this.movieCode.Location = new System.Drawing.Point(136, 451);
            this.movieCode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.movieCode.Name = "movieCode";
            this.movieCode.Size = new System.Drawing.Size(100, 26);
            this.movieCode.TabIndex = 37;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(901, 123);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 36);
            this.button2.TabIndex = 40;
            this.button2.Text = "search";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = global::agam.Properties.Resources.refresh;
            this.pictureBox1.Location = new System.Drawing.Point(334, 123);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(54, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(394, 128);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(505, 26);
            this.searchBox.TabIndex = 39;
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            // 
            // frmMoviesM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1113, 669);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.movieCode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.nextBtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.prevBtn);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.descriptionTxt);
            this.Controls.Add(this.ageLimitTxt);
            this.Controls.Add(this.genreTxt);
            this.Controls.Add(this.movieTxt);
            this.Controls.Add(this.producerTxt);
            this.Controls.Add(this.releasePick);
            this.Controls.Add(this.movieName);
            this.Controls.Add(this.producer);
            this.Controls.Add(this.releaseDate);
            this.Controls.Add(this.genre);
            this.Controls.Add(this.ageLimit);
            this.Controls.Add(this.description);
            this.Controls.Add(this.moviesGrid);
            this.Name = "frmMoviesM";
            this.Text = "frmMoviesM";
            this.Load += new System.EventHandler(this.frmMoviesM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.moviesGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView moviesGrid;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label description;
        private System.Windows.Forms.Label ageLimit;
        private System.Windows.Forms.Label genre;
        private System.Windows.Forms.Label releaseDate;
        private System.Windows.Forms.Label producer;
        private System.Windows.Forms.Label movieName;
        private System.Windows.Forms.DateTimePicker releasePick;
        private System.Windows.Forms.TextBox producerTxt;
        private System.Windows.Forms.TextBox movieTxt;
        private System.Windows.Forms.TextBox genreTxt;
        private System.Windows.Forms.TextBox ageLimitTxt;
        private System.Windows.Forms.TextBox descriptionTxt;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Button prevBtn;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button nextBtn;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.TextBox movieCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox searchBox;
    }
}