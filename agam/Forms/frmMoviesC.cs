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
    public partial class frmMoviesC : Form
    {
        DataTable tmovies;
        string Uname;
        public frmMoviesC(string name)
        {
            InitializeComponent();
            Uname = name;
            String sql = "SELECT Movies.[movieName], Movies.[releaseDate], Movies.[movieGenre], Movies.[ageLimit], Movies.[producer], Movies.[description], Movies.[movieCode] FROM Movies WHERE NOT Movies.[movieCode] ='0'";
            tmovies = Class1.OpenTableWithCondition(sql);
            string fullPath = "C:/myProject/agam/Resources/" + tmovies.Rows[1][6] + ".jpg";
            button1.BackgroundImage = Image.FromFile(fullPath);
            button1.Text = tmovies.Rows[1][0].ToString();
            rd1.Text = tmovies.Rows[1][1].ToString();
            g1.Text = tmovies.Rows[1][2].ToString();
            ag1.Text = tmovies.Rows[1][3].ToString();
            p1.Text= tmovies.Rows[1][4].ToString();
            d1.Text = tmovies.Rows[1][5].ToString();
            fullPath = "C:/myProject/agam/Resources/" + tmovies.Rows[2][6] + ".jpg";
            button2.BackgroundImage = Image.FromFile(fullPath);
            button2.Text = tmovies.Rows[2][0].ToString();
            rd2.Text = tmovies.Rows[2][1].ToString();
            g2.Text = tmovies.Rows[2][2].ToString();
            ag2.Text = tmovies.Rows[2][3].ToString();
            p2.Text = tmovies.Rows[2][4].ToString();
            d2.Text = tmovies.Rows[2][5].ToString();
            fullPath = "C:/myProject/agam/Resources/" + tmovies.Rows[3][6] + ".jpg";
            button3.BackgroundImage = Image.FromFile(fullPath);
            button3.Text = tmovies.Rows[3][0].ToString();
            rd3.Text = tmovies.Rows[3][1].ToString();
            g3.Text = tmovies.Rows[3][2].ToString();
            ag3.Text = tmovies.Rows[3][3].ToString();
            p3.Text = tmovies.Rows[3][4].ToString();
            d3.Text = tmovies.Rows[3][5].ToString();
            fullPath = "C:/myProject/agam/Resources/" + tmovies.Rows[4][6] + ".jpg";
            button4.BackgroundImage = Image.FromFile(fullPath);
            button4.Text = tmovies.Rows[4][0].ToString();
            rd4.Text = tmovies.Rows[4][1].ToString();
            g4.Text = tmovies.Rows[4][2].ToString();
            ag4.Text = tmovies.Rows[4][3].ToString();
            p4.Text = tmovies.Rows[4][4].ToString();
            d4.Text = tmovies.Rows[4][5].ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
          
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
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

        private void watch1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
