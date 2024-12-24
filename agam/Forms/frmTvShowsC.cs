using agam.Data;
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
    public partial class frmTvShowsC : Form
    {
        string Uname;
        DataTable tshows;
        public frmTvShowsC(string name)
        {
            InitializeComponent();
            Uname = name;
            String sql = "SELECT TvShows.[tvShow], TvShows.[release date], TvShows.[producer], TvShows.[age limit], TvShows.[seasons], TvShows.[genre], TvShows.[description], TvShows.[showCode] FROM TvShows WHERE NOT TvShows.[showCode] ='0'";
            tshows = Class1.OpenTableWithCondition(sql);
            string fullPath = "C:/myProject/agam/Resources/" + tshows.Rows[1][7] + ".jpg";
            button1.BackgroundImage = Image.FromFile(fullPath);
            button1.Text = tshows.Rows[1][0].ToString();
            rd1.Text = tshows.Rows[1][1].ToString();
            p1.Text = tshows.Rows[1][2].ToString();
            ag1.Text = tshows.Rows[1][3].ToString();
            s1.Text = tshows.Rows[1][4].ToString();
            g1.Text = tshows.Rows[1][5].ToString();
            d1.Text = tshows.Rows[1][6].ToString();
            fullPath = "C:/myProject/agam/Resources/" + tshows.Rows[2][7] + ".jpg";
            button2.BackgroundImage = Image.FromFile(fullPath);
            button2.Text = tshows.Rows[2][0].ToString();
            rd2.Text = tshows.Rows[2][1].ToString();
            p2.Text = tshows.Rows[2][2].ToString();
            ag2.Text = tshows.Rows[2][3].ToString();
            s2.Text = tshows.Rows[2][4].ToString();
            g2.Text = tshows.Rows[2][5].ToString();
            d2.Text = tshows.Rows[2][6].ToString();
            fullPath = "C:/myProject/agam/Resources/" + tshows.Rows[3][7] + ".jpg";
            button3.BackgroundImage = Image.FromFile(fullPath);
            button3.Text = tshows.Rows[3][0].ToString();
            rd3.Text = tshows.Rows[3][1].ToString();
            p3.Text = tshows.Rows[3][2].ToString();
            ag3.Text = tshows.Rows[3][3].ToString();
            s3.Text = tshows.Rows[3][4].ToString();
            g3.Text = tshows.Rows[3][5].ToString();
            d3.Text = tshows.Rows[3][6].ToString();
            fullPath = "C:/myProject/agam/Resources/" + tshows.Rows[4][7] + ".jpg";
            button4.BackgroundImage = Image.FromFile(fullPath);
            button4.Text = tshows.Rows[4][0].ToString();
            rd4.Text = tshows.Rows[4][1].ToString();
            p4.Text = tshows.Rows[4][2].ToString();
            ag4.Text = tshows.Rows[4][3].ToString();
            s4.Text = tshows.Rows[4][4].ToString();
            g4.Text = tshows.Rows[4][5].ToString();
            d4.Text = tshows.Rows[4][6].ToString();
        }

        private void accountBtn_Click(object sender, EventArgs e)
        {
            DataTable t;
            string sql = "SELECT Users.[accountNum] FROM Users WHERE Users.userName='" + Uname + "'";
            t = Class1.OpenTableWithCondition(sql);
            string num = t.Rows[0][0].ToString();
            frmUsersChooseC users = new frmUsersChooseC(num);
            users.Show();
            this.Hide();
        }

        private void listBtn_Click(object sender, EventArgs e)
        {
            frmMyListC list = new frmMyListC(Uname);
            list.Show();
            this.Hide();
        }

        private void moviesBtn_Click(object sender, EventArgs e)
        {
            frmTvShowsC tv = new frmTvShowsC(Uname);
            tv.Show();
            this.Hide();
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void ag1_Click(object sender, EventArgs e)
        {

        }
    }
}
