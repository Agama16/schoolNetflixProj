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
    public partial class frmMoviesM : Form
    {
        int count;
        DataTable Tmovies;
        public frmMoviesM()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

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
                    strSql = "Select * from Movies where movie name='" + movieName.Text + "'";
                    Class1.GetDataSet(strSql);
                    if (Class1.ds.Tables[0].Rows.Count > 0)
                        MessageBox.Show("This already exists");
                    else
                    {
                        Movies c = new Movies();

                        if (Check_input(c))
                        {
                            strSql = "INSERT INTO Movies VALUES ('" + movieTxt.Text + "','" + releasePick.Text + "','" + producerTxt.Text + "','" + ageLimitTxt.Text + "','" + genreTxt.Text + "','" + descriptionTxt.Text +"')";
                            MessageBox.Show(GeneralUtilities.AddRecd(Tmovies, strSql));
                            frmMoviesM_Load(sender, e);
                        }
                    }
                }
            }

            if (checkpoint == "edit")
            {

            }
        }

        private void frmMoviesM_Load(object sender, EventArgs e)
        {
            Location = new Point(200, 200);

            Tmovies = Class1.OpenTable("Movies");

            DisplayUtilities.FillDataGrid(moviesGrid, Tmovies);
            count = 0;
            DisplayRecord(0);
        }
        private void DisplayRecord(int currentRow)
        {
            movieTxt.Text = moviesGrid.Rows[currentRow].Cells[0].Value.ToString();
            releasePick.Text = moviesGrid.Rows[currentRow].Cells[1].Value.ToString();
            producerTxt.Text = moviesGrid.Rows[currentRow].Cells[2].Value.ToString();
            ageLimitTxt.Text = moviesGrid.Rows[currentRow].Cells[3].Value.ToString();
            genreTxt.Text = moviesGrid.Rows[currentRow].Cells[4].Value.ToString();
            descriptionTxt.Text = moviesGrid.Rows[currentRow].Cells[5].Value.ToString();
           
        }
        private bool Check_input(Movies d)
        {
            bool flag = true;
            try
            {
                d.MovieName = movieTxt.Text.ToString();
                errorProvider1.SetError(movieTxt, "");
                flag = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                flag = false;
                errorProvider1.SetError(movieTxt, ex.Message);
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
            try
            {
                d.MovieGenre = genreTxt.Text.ToString();
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
          
            /*try
            {
                d.ReleaseDate = releasePick.ToString();
                errorProvider1.SetError(releasePick, "");
                flag = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                flag = false;
                errorProvider1.SetError(releasePick, ex.Message);
            }*/
            return flag;
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
            movieTxt.Enabled = false;
            editBtn.Enabled = false;


        }

        private void prevBtn_Click(object sender, EventArgs e)
        {
            frmTvShowsM show = new frmTvShowsM();
            show.Show();
            this.Hide();
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            FrmAccountTypesM at = new FrmAccountTypesM();
            at.Show();
            this.Hide();
        }
    }
}
