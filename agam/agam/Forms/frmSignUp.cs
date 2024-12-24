using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace agam.Forms
{
    public partial class frmSignUp : Form
    {
        public frmSignUp()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            frmlogin x = new frmlogin();
            x.Show();
            this.Hide();
        }


        private void signUpbtn_Click(object sender, EventArgs e)
        {
            
        }
    }
}
