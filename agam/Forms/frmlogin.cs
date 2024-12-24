using agam.Data;
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

            DataTable t;
            if (usernameTxt.Text == "admin" && passwordTxt.Text == "admin123")
            {
                frmManagerDataM admin = new frmManagerDataM();
                admin.Show();
                this.Hide();
            }
            else
            {
                string sql = "SELECT * FROM Accounts WHERE name='" + usernameTxt.Text + "' AND password='" + passwordTxt.Text + "'";
                t = Class1.OpenTableWithCondition(sql);
                if (t.Rows.Count>0)
                {
                    string sql2 = "SELECT * FROM Accounts WHERE name='" + usernameTxt.Text + "' AND password='" + passwordTxt.Text + "'";
                    DataTable table= Class1.OpenTableWithCondition(sql2);
                    string acNum = table.Rows[0][0].ToString();
                    frmUsersChooseC myList = new frmUsersChooseC(acNum);
                    myList.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Account doesnt exist");
                    
                }
               
            }
        }

        private void frmlogin_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }
    }
}
