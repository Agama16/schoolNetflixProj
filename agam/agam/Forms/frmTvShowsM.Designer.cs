
namespace agam.Forms
{
    partial class frmTvShowsM
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
            this.showsGrid = new System.Windows.Forms.DataGridView();
            this.genre = new System.Windows.Forms.Label();
            this.seasons = new System.Windows.Forms.Label();
            this.ageLimit = new System.Windows.Forms.Label();
            this.releaseDate = new System.Windows.Forms.Label();
            this.producerName = new System.Windows.Forms.Label();
            this.tvShow = new System.Windows.Forms.Label();
            this.releaseDatePick = new System.Windows.Forms.DateTimePicker();
            this.description = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.genreTxt = new System.Windows.Forms.TextBox();
            this.seasonsTxt = new System.Windows.Forms.TextBox();
            this.ageLimitTxt = new System.Windows.Forms.TextBox();
            this.producerTxt = new System.Windows.Forms.TextBox();
            this.tvShowTxt = new System.Windows.Forms.TextBox();
            this.descriptionTxt = new System.Windows.Forms.TextBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.prevBtn = new System.Windows.Forms.Button();
            this.nextBtn = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.showsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // showsGrid
            // 
            this.showsGrid.BackgroundColor = System.Drawing.Color.White;
            this.showsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.showsGrid.Location = new System.Drawing.Point(434, 108);
            this.showsGrid.Name = "showsGrid";
            this.showsGrid.RowHeadersWidth = 62;
            this.showsGrid.RowTemplate.Height = 28;
            this.showsGrid.Size = new System.Drawing.Size(652, 317);
            this.showsGrid.TabIndex = 0;
            this.showsGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // genre
            // 
            this.genre.AutoSize = true;
            this.genre.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.genre.Location = new System.Drawing.Point(33, 354);
            this.genre.Name = "genre";
            this.genre.Size = new System.Drawing.Size(54, 20);
            this.genre.TabIndex = 1;
            this.genre.Text = "Genre";
            // 
            // seasons
            // 
            this.seasons.AutoSize = true;
            this.seasons.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.seasons.Location = new System.Drawing.Point(32, 305);
            this.seasons.Name = "seasons";
            this.seasons.Size = new System.Drawing.Size(153, 20);
            this.seasons.TabIndex = 2;
            this.seasons.Text = "Number Of Seasons";
            // 
            // ageLimit
            // 
            this.ageLimit.AutoSize = true;
            this.ageLimit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ageLimit.Location = new System.Drawing.Point(33, 257);
            this.ageLimit.Name = "ageLimit";
            this.ageLimit.Size = new System.Drawing.Size(75, 20);
            this.ageLimit.TabIndex = 3;
            this.ageLimit.Text = "Age Limit";
            // 
            // releaseDate
            // 
            this.releaseDate.AutoSize = true;
            this.releaseDate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.releaseDate.Location = new System.Drawing.Point(32, 166);
            this.releaseDate.Name = "releaseDate";
            this.releaseDate.Size = new System.Drawing.Size(107, 20);
            this.releaseDate.TabIndex = 4;
            this.releaseDate.Text = "Release Date";
            // 
            // producerName
            // 
            this.producerName.AutoSize = true;
            this.producerName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.producerName.Location = new System.Drawing.Point(33, 214);
            this.producerName.Name = "producerName";
            this.producerName.Size = new System.Drawing.Size(119, 20);
            this.producerName.TabIndex = 5;
            this.producerName.Text = "Producer Name";
            // 
            // tvShow
            // 
            this.tvShow.AutoSize = true;
            this.tvShow.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tvShow.Location = new System.Drawing.Point(32, 118);
            this.tvShow.Name = "tvShow";
            this.tvShow.Size = new System.Drawing.Size(119, 20);
            this.tvShow.TabIndex = 6;
            this.tvShow.Text = "TV Show Name";
            // 
            // releaseDatePick
            // 
            this.releaseDatePick.Location = new System.Drawing.Point(190, 157);
            this.releaseDatePick.Name = "releaseDatePick";
            this.releaseDatePick.Size = new System.Drawing.Size(200, 26);
            this.releaseDatePick.TabIndex = 7;
            // 
            // description
            // 
            this.description.AutoSize = true;
            this.description.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.description.Location = new System.Drawing.Point(32, 398);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(86, 20);
            this.description.TabIndex = 8;
            this.description.Text = "description";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "label2";
            // 
            // genreTxt
            // 
            this.genreTxt.Location = new System.Drawing.Point(190, 343);
            this.genreTxt.Name = "genreTxt";
            this.genreTxt.Size = new System.Drawing.Size(100, 26);
            this.genreTxt.TabIndex = 10;
            // 
            // seasonsTxt
            // 
            this.seasonsTxt.Location = new System.Drawing.Point(190, 300);
            this.seasonsTxt.Name = "seasonsTxt";
            this.seasonsTxt.Size = new System.Drawing.Size(100, 26);
            this.seasonsTxt.TabIndex = 11;
            // 
            // ageLimitTxt
            // 
            this.ageLimitTxt.Location = new System.Drawing.Point(190, 252);
            this.ageLimitTxt.Name = "ageLimitTxt";
            this.ageLimitTxt.Size = new System.Drawing.Size(100, 26);
            this.ageLimitTxt.TabIndex = 12;
            // 
            // producerTxt
            // 
            this.producerTxt.Location = new System.Drawing.Point(190, 203);
            this.producerTxt.Name = "producerTxt";
            this.producerTxt.Size = new System.Drawing.Size(100, 26);
            this.producerTxt.TabIndex = 13;
            // 
            // tvShowTxt
            // 
            this.tvShowTxt.Location = new System.Drawing.Point(190, 108);
            this.tvShowTxt.Name = "tvShowTxt";
            this.tvShowTxt.Size = new System.Drawing.Size(100, 26);
            this.tvShowTxt.TabIndex = 14;
            // 
            // descriptionTxt
            // 
            this.descriptionTxt.Location = new System.Drawing.Point(190, 394);
            this.descriptionTxt.Name = "descriptionTxt";
            this.descriptionTxt.Size = new System.Drawing.Size(100, 26);
            this.descriptionTxt.TabIndex = 15;
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.Black;
            this.addBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.addBtn.Location = new System.Drawing.Point(670, 454);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(136, 42);
            this.addBtn.TabIndex = 16;
            this.addBtn.Text = "Save";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.BackColor = System.Drawing.Color.Black;
            this.clearBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.clearBtn.Location = new System.Drawing.Point(516, 454);
            this.clearBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(148, 42);
            this.clearBtn.TabIndex = 25;
            this.clearBtn.Text = "Add New";
            this.clearBtn.UseVisualStyleBackColor = false;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // editBtn
            // 
            this.editBtn.BackColor = System.Drawing.Color.Black;
            this.editBtn.ForeColor = System.Drawing.Color.White;
            this.editBtn.Location = new System.Drawing.Point(813, 452);
            this.editBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(140, 42);
            this.editBtn.TabIndex = 27;
            this.editBtn.Text = "Edit";
            this.editBtn.UseVisualStyleBackColor = false;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // prevBtn
            // 
            this.prevBtn.BackColor = System.Drawing.Color.Black;
            this.prevBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.prevBtn.Location = new System.Drawing.Point(21, 451);
            this.prevBtn.Name = "prevBtn";
            this.prevBtn.Size = new System.Drawing.Size(132, 45);
            this.prevBtn.TabIndex = 29;
            this.prevBtn.Text = "prev";
            this.prevBtn.UseVisualStyleBackColor = false;
            this.prevBtn.Click += new System.EventHandler(this.prevBtn_Click);
            // 
            // nextBtn
            // 
            this.nextBtn.BackColor = System.Drawing.Color.Black;
            this.nextBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.nextBtn.Location = new System.Drawing.Point(958, 451);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(128, 45);
            this.nextBtn.TabIndex = 30;
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
            this.pictureBox1.Location = new System.Drawing.Point(-16, 534);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1122, 118);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Maroon;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(-57, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(1178, 66);
            this.button1.TabIndex = 32;
            this.button1.Text = "TV Shows";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // frmTvShowsM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1102, 671);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.nextBtn);
            this.Controls.Add(this.prevBtn);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.descriptionTxt);
            this.Controls.Add(this.tvShowTxt);
            this.Controls.Add(this.producerTxt);
            this.Controls.Add(this.ageLimitTxt);
            this.Controls.Add(this.seasonsTxt);
            this.Controls.Add(this.genreTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.description);
            this.Controls.Add(this.releaseDatePick);
            this.Controls.Add(this.tvShow);
            this.Controls.Add(this.producerName);
            this.Controls.Add(this.releaseDate);
            this.Controls.Add(this.ageLimit);
            this.Controls.Add(this.seasons);
            this.Controls.Add(this.genre);
            this.Controls.Add(this.showsGrid);
            this.Name = "frmTvShowsM";
            this.Text = "TvShowsM";
            this.Load += new System.EventHandler(this.frmTvShowsM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.showsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView showsGrid;
        private System.Windows.Forms.Label genre;
        private System.Windows.Forms.Label seasons;
        private System.Windows.Forms.Label ageLimit;
        private System.Windows.Forms.Label releaseDate;
        private System.Windows.Forms.Label producerName;
        private System.Windows.Forms.Label tvShow;
        private System.Windows.Forms.DateTimePicker releaseDatePick;
        private System.Windows.Forms.Label description;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox genreTxt;
        private System.Windows.Forms.TextBox seasonsTxt;
        private System.Windows.Forms.TextBox ageLimitTxt;
        private System.Windows.Forms.TextBox producerTxt;
        private System.Windows.Forms.TextBox tvShowTxt;
        private System.Windows.Forms.TextBox descriptionTxt;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Button prevBtn;
        private System.Windows.Forms.Button nextBtn;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}