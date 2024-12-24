using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace agam.Forms
{
    public partial class frmlogin : Form
    {
        public frmlogin()
        {
            InitializeComponent();
        }

        private void passwordTxt_TextChanged(object sender, EventArgs e)
        {
            passwordTxt.PasswordChar = '*';
        }

        private void SignUpbtn_Click(object sender, EventArgs e)
        {
            frmSignUp signUp = new frmSignUp();
            signUp.Show();
            this.Hide();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            frmAccountsM signUp = new frmAccountsM();
            signUp.Show();
            this.Hide();
        }
    }
}
