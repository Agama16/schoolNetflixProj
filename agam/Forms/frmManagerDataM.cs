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
    public partial class frmManagerDataM : Form
    {
        public frmManagerDataM()
        {
            InitializeComponent();
        }

        private void AccountsBtn_Click(object sender, EventArgs e)
        {
            frmAccountsM acc = new frmAccountsM();
            acc.Show();
            this.Hide();
        }

        private void UsersBtn_Click(object sender, EventArgs e)
        {
            frmUsersM us = new frmUsersM();
            us.Show();
            this.Hide();
        }

        private void accountTypeBtn_Click(object sender, EventArgs e)
        {
            //frmAccountTypesM acc = new frmAccountTypesM();
            //acc.Show();
            //this.Hide();
        }

        private void MoviesBtn_Click(object sender, EventArgs e)
        {
            frmMoviesM mv = new frmMoviesM();
            mv.Show();
            this.Hide();
        }

        private void tvShowBtn_Click(object sender, EventArgs e)
        {
            frmTvShowsM tv = new frmTvShowsM();
            tv.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
