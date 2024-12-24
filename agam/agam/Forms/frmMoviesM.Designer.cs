
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.nextBtn = new System.Windows.Forms.Button();
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
            this.moviesGrid.Location = new System.Drawing.Point(393, 92);
            this.moviesGrid.Name = "moviesGrid";
            this.moviesGrid.RowHeadersWidth = 62;
            this.moviesGrid.RowTemplate.Height = 28;
            this.moviesGrid.Size = new System.Drawing.Size(664, 366);
            this.moviesGrid.TabIndex = 0;
            // 
            // description
            // 
            this.description.AutoSize = true;
            this.description.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.description.Location = new System.Drawing.Point(40, 415);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(89, 20);
            this.description.TabIndex = 1;
            this.description.Text = "Description";
            // 
            // ageLimit
            // 
            this.ageLimit.AutoSize = true;
            this.ageLimit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ageLimit.Location = new System.Drawing.Point(40, 358);
            this.ageLimit.Name = "ageLimit";
            this.ageLimit.Size = new System.Drawing.Size(75, 20);
            this.ageLimit.TabIndex = 2;
            this.ageLimit.Text = "Age Limit";
            // 
            // genre
            // 
            this.genre.AutoSize = true;
            this.genre.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.genre.Location = new System.Drawing.Point(40, 305);
            this.genre.Name = "genre";
            this.genre.Size = new System.Drawing.Size(54, 20);
            this.genre.TabIndex = 3;
            this.genre.Text = "Genre";
            // 
            // releaseDate
            // 
            this.releaseDate.AutoSize = true;
            this.releaseDate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.releaseDate.Location = new System.Drawing.Point(40, 240);
            this.releaseDate.Name = "releaseDate";
            this.releaseDate.Size = new System.Drawing.Size(107, 20);
            this.releaseDate.TabIndex = 4;
            this.releaseDate.Text = "Release Date";
            // 
            // producer
            // 
            this.producer.AutoSize = true;
            this.producer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.producer.Location = new System.Drawing.Point(40, 172);
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
            this.movieName.Location = new System.Drawing.Point(40, 120);
            this.movieName.Name = "movieName";
            this.movieName.Size = new System.Drawing.Size(96, 20);
            this.movieName.TabIndex = 6;
            this.movieName.Text = "Movie Name";
            // 
            // releasePick
            // 
            this.releasePick.Location = new System.Drawing.Point(164, 229);
            this.releasePick.Name = "releasePick";
            this.releasePick.Size = new System.Drawing.Size(200, 26);
            this.releasePick.TabIndex = 7;
            // 
            // producerTxt
            // 
            this.producerTxt.Location = new System.Drawing.Point(164, 168);
            this.producerTxt.Name = "producerTxt";
            this.producerTxt.Size = new System.Drawing.Size(100, 26);
            this.producerTxt.TabIndex = 8;
            // 
            // movieTxt
            // 
            this.movieTxt.Location = new System.Drawing.Point(164, 109);
            this.movieTxt.Name = "movieTxt";
            this.movieTxt.Size = new System.Drawing.Size(100, 26);
            this.movieTxt.TabIndex = 9;
            // 
            // genreTxt
            // 
            this.genreTxt.Location = new System.Drawing.Point(164, 294);
            this.genreTxt.Name = "genreTxt";
            this.genreTxt.Size = new System.Drawing.Size(100, 26);
            this.genreTxt.TabIndex = 10;
            // 
            // ageLimitTxt
            // 
            this.ageLimitTxt.Location = new System.Drawing.Point(164, 348);
            this.ageLimitTxt.Name = "ageLimitTxt";
            this.ageLimitTxt.Size = new System.Drawing.Size(100, 26);
            this.ageLimitTxt.TabIndex = 11;
            // 
            // descriptionTxt
            // 
            this.descriptionTxt.Location = new System.Drawing.Point(164, 405);
            this.descriptionTxt.Name = "descriptionTxt";
            this.descriptionTxt.Size = new System.Drawing.Size(100, 26);
            this.descriptionTxt.TabIndex = 12;
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.Black;
            this.addBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.addBtn.Location = new System.Drawing.Point(641, 480);
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
            this.clearBtn.Location = new System.Drawing.Point(483, 478);
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
            this.editBtn.Location = new System.Drawing.Point(789, 481);
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
            this.prevBtn.Location = new System.Drawing.Point(30, 478);
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
            // pictureBox1
            // 
            this.pictureBox1.Image = global::agam.Properties.Resources.Netflix_Symbol1;
            this.pictureBox1.Location = new System.Drawing.Point(-9, 532);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1108, 118);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Maroon;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(-52, -6);
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
            this.nextBtn.Location = new System.Drawing.Point(929, 481);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(128, 43);
            this.nextBtn.TabIndex = 31;
            this.nextBtn.Text = "Next";
            this.nextBtn.UseVisualStyleBackColor = false;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // frmMoviesM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1098, 669);
            this.Controls.Add(this.nextBtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button nextBtn;
    }
}