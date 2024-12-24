using agam.Class;
using agam.Data;
using agam.utilities;
using agam.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace agam.Forms
{
    public partial class frmTvShowsM : Form
    {
        DataTable Ttvshows;
        int count;
        public frmTvShowsM()
        {
            InitializeComponent();
        }

        private void prevBtn_Click(object sender, EventArgs e)
        {
            frmUsersM user = new frmUsersM();
            user.Show();
            this.Hide();
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            frmMoviesM movie = new frmMoviesM();
            movie.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmTvShowsM_Load(object sender, EventArgs e)
        {
            Location = new Point(200, 200);

            Ttvshows = Class1.OpenTable("TvShows");

            DisplayUtilities.FillDataGrid(showsGrid, Ttvshows);
            count = 0;
            DisplayRecord(0);
        }
        private void DisplayRecord(int currentRow)
        {
            tvShowTxt.Text = showsGrid.Rows[currentRow].Cells[0].Value.ToString();
            releaseDatePick.Value = Convert.ToDateTime( showsGrid.Rows[currentRow].Cells[1].Value.ToString());
            producerTxt.Text = showsGrid.Rows[currentRow].Cells[2].Value.ToString();
            ageLimitTxt.Text = showsGrid.Rows[currentRow].Cells[3].Value.ToString();
            seasonsTxt.Text = showsGrid.Rows[currentRow].Cells[4].Value.ToString();
            genreTxt.Text = showsGrid.Rows[currentRow].Cells[5].Value.ToString();
            descriptionTxt.Text = showsGrid.Rows[currentRow].Cells[6].Value.ToString();

        }
        private bool Check_input(TvShows d)
        {
            bool flag = true;
            try
            {
                d.TvShow = tvShowTxt.Text.ToString();
                errorProvider1.SetError(tvShowTxt, "");
                flag = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                flag = false;
                errorProvider1.SetError(tvShowTxt, ex.Message);
            }
            try
            {
                d.Producer = producerTxt.Text.ToString();
                errorProvider1.SetError(producerTxt, "");
                flag = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                flag = false;
                errorProvider1.SetError(producerTxt, ex.Message);
            }
            try
            {
                d.Genre = genreTxt.Text.ToString();
                errorProvider1.SetError(genreTxt, "");
                flag = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                flag = false;
                errorProvider1.SetError(genreTxt, ex.Message);
            }
            try
            {
                d.Seasons = seasonsTxt.Text.ToString();
                errorProvider1.SetError(seasonsTxt, "");
                flag = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                flag = false;
                errorProvider1.SetError(seasonsTxt, ex.Message);
            }
            try
            {
                d.AgeLimit = ageLimitTxt.Text.ToString();
                errorProvider1.SetError(ageLimitTxt, "");
                flag = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                flag = false;
                errorProvider1.SetError(ageLimitTxt, ex.Message);
            }
            try
            {
                d.ReleaseDate = Convert.ToDateTime(releaseDatePick.ToString());
                errorProvider1.SetError(releaseDate, "");
                flag = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                flag = false;
                errorProvider1.SetError(releaseDatePick, ex.Message);
            }
            try
            {
                d.Description = descriptionTxt.Text.ToString();
                errorProvider1.SetError(descriptionTxt, "");
                flag = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                flag = false;
                errorProvider1.SetError(descriptionTxt, ex.Message);
            }
           
            return flag;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (checkpoint == "add")
            {
                string strSql;
                if (!(DisplayUtilities.ContIsfull(this)))
                    MessageBox.Show("Missing data");
                else
                {
                    strSql = "Select * from TvShows where showCode='" + showCode.Text + "'";
                    Class1.GetDataSet(strSql);
                    if (Class1.ds.Tables[0].Rows.Count > 0)
                        MessageBox.Show("This already exists");
                    else
                    {
                        TvShows c = new TvShows();

                        if (Check_input(c))
                        {
                            strSql = "INSERT INTO TvShows VALUES ('" + tvShowTxt.Text + "','" + releaseDatePick.Text + "','" + producerTxt.Text + "','" + genreTxt.Text + "','" + seasonsTxt.Text + "','" + ageLimitTxt.Text + "','" + descriptionTxt.Text +"')";
                            Utilities.GeneralUtilities.AddRecd(Ttvshows, strSql);
                            MessageBox.Show(GeneralUtilities.AddRecd(Ttvshows, strSql));
                            frmTvShowsM_Load(sender, e);
                        }
                    }
                }
            }

            if (checkpoint == "edit")
            {
                string strSql;
                if (!(DisplayUtilities.ContIsfull(this)))
                    MessageBox.Show("Missing data");
               
                else
                {
                    TvShows c = new TvShows();

                    if (Check_input(c))
                    {
                        strSql = "UPDATE TvShows SET TvShows.[tvShow] = '" + tvShowTxt.Text + "', TvShows.[releaseDate]=#" + releaseDatePick.Value + "#, TvShows.[producer]='" + producerTxt.Text + "', Movies.[ageLimit]='" + ageLimitTxt.Text + "', Movies.[genre]='" + genreTxt.Text + "',Movies.[description]='" + descriptionTxt.Text + "',TvShows.[seasons]='"+seasonsTxt.Text+"' WHERE TvShow.[showCode]='" + showCode.Text + "'";
                        Utilities.GeneralUtilities.UpDateRecd(Ttvshows, strSql);
                        MessageBox.Show(GeneralUtilities.AddRecd(Ttvshows, strSql));
                        frmTvShowsM_Load(sender, e);
                    }
                }
            }
        }
        string checkpoint;

        private void clearBtn_Click(object sender, EventArgs e)
        {
            // clear fields
            addBtn.Enabled = true;
            checkpoint = "add";
            DisplayUtilities.EnableControls(this);
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            checkpoint = "edit";
            DisplayUtilities.EnableControls(this);
            showCode.Enabled = false;
            editBtn.Enabled = false;

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            frmManagerDataM control = new frmManagerDataM();
            control.Show();
            this.Hide();
        }
        private void showsGrid__RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            tvShowTxt.Text = showsGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
            releaseDatePick.Value = Convert.ToDateTime(showsGrid.Rows[e.RowIndex].Cells[1].Value.ToString());
            producerTxt.Text = showsGrid.Rows[e.RowIndex].Cells[2].Value.ToString();
            ageLimitTxt.Text = showsGrid.Rows[e.RowIndex].Cells[3].Value.ToString();
            seasonsTxt.Text = showsGrid.Rows[e.RowIndex].Cells[4].Value.ToString();
            genreTxt.Text = showsGrid.Rows[e.RowIndex].Cells[5].Value.ToString();
            descriptionTxt.Text = showsGrid.Rows[e.RowIndex].Cells[6].Value.ToString();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmTvShowsM_Load(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string txt = searchBox.Text;

            string sql = $"SELECT * FROM TvShows WHERE tvShow LIKE '%{tvShowTxt.Text}%' OR " +
                $"releaseDate LIKE '%{releaseDatePick.Value}%' OR " +
                $"producer LIKE '%{producerTxt.Text}%' OR " +
                $"genre LIKE '%{genreTxt.Text}%' OR " +
                $"showCode LIKE '%{showCode.Text}%' OR " +
                $"ageLimit LIKE '%{ageLimitTxt.Text}%' OR " +
                $"description LIKE '%{descriptionTxt.Text}%' OR"+
                $"seasons LIKE '%{seasonsTxt.Text}%'";

            Ttvshows = Class1.OpenTableWithCondition(sql);
            DisplayUtilities.FillDataGrid(showsGrid, Ttvshows);
        }
    }
}
