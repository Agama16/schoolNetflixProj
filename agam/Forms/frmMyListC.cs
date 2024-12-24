using agam.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace agam.Forms
{
    public partial class frmMyListC : Form
    {
        DataTable tlist;
        string Uname;
        public frmMyListC(string name)
        {
            InitializeComponent();
            Uname = name;
            
            String sql = "SELECT  Movies.movieCode , Movies.movieName AS Movies_movieName, Movies.releaseDate, Movies.movieGenre , Movies.ageLimit, Movies.producer AS Movies_producer, Movies.description AS Movies_description, MyList.movieName AS MyList_movieName, MyList.userName, MyList.TvShowName FROM Movies INNER JOIN MyList ON Movies.[movieName] = MyList.[movieName]  WHERE MyList.userName ='" + name + "'";
            tlist = Class1.OpenTableWithCondition(sql);
            string fullPath;
            string str;
            if (tlist.Rows.Count > 0)
            {
                 str=tlist.Rows[0][0] + ".jpg";
                 fullPath = Path.GetFullPath(str);
                tv1.BackgroundImage = Image.FromFile(fullPath);
                tv1.Text = tlist.Rows[0][1].ToString();
            }
            else
            {
                tv1.Text = "You didn't watch anything yet";
            }
            if (tlist.Rows.Count > 1)
            {
                str = tlist.Rows[1][0] + ".jpg";
                fullPath = Path.GetFullPath(str);
                tv2.BackgroundImage = Image.FromFile(fullPath);
                tv2.Text = tlist.Rows[1][1].ToString();
            }
            else
            {
                tv2.Text = "You didn't watch anything yet";
            }
            if (tlist.Rows.Count > 2)
            {
                str = tlist.Rows[2][0] + ".jpg";
                fullPath=Path.GetFullPath(str);
                tv3.BackgroundImage = Image.FromFile(fullPath);
                tv3.Text = tlist.Rows[2][1].ToString();
            }
            else
            {
                tv3.Text = "You didn't watch anything yet";
            }
            if (tlist.Rows.Count > 3)
            {
                str =  tlist.Rows[3][0] + ".jpg";
                fullPath = Path.GetFullPath(str);
                tv4.BackgroundImage = Image.FromFile(fullPath);
                tv4.Text = tlist.Rows[3][1].ToString();
            }
            else
            {
                tv4.Text = "You didn't watch anything yet";
            }
        }

        private void recomendedBtn_Click(object sender, EventArgs e)
        {

        }

        private void frmMyListC_Load(object sender, EventArgs e)
        {

        }
        private void tv1_Click(object sender, EventArgs e)
        {

        }

        private void tv2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void moviesBtn_Click(object sender, EventArgs e)
        {
            frmMoviesC movies = new frmMoviesC(Uname);
            movies.Show();
            this.Hide();
        }

        private void tvShowsBtn_Click(object sender, EventArgs e)
        {
            frmTvShowsC tv = new frmTvShowsC(Uname);
            tv.Show();
            this.Hide();
        }

        private void accountBtn_Click(object sender, EventArgs e)
        {
            DataTable t;
            string sql = "SELECT Users.[accountNum] FROM Users WHERE Users.userName='"+Uname+"'";
            t = Class1.OpenTableWithCondition(sql);
            string num = t.Rows[0][0].ToString();
            frmUsersChooseC users = new frmUsersChooseC(num);
            users.Show();
            this.Hide();
        }
    }
}



