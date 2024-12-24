using agam.Class;
using agam.Data;
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
    public partial class frmAddUsersC : Form
    {
        DataTable Tusers;
        int acnum;
        public frmAddUsersC(int num)
        {
            InitializeComponent();
            acnum = num;
        }
        private bool Check_input(Users d)
        {
            bool flag = true;

            try
            {
                d.UserName = nameTxt1.Text.ToString();
                errorProvider1.SetError(nameTxt1, "");
                flag = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                flag = false;
                errorProvider1.SetError(nameTxt1, ex.Message);
            }

            return flag;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            string strSql = "Select * from Users where username='" + nameTxt1.Text + "'";
            Class1.GetDataSet(strSql);
            if (Class1.ds.Tables[0].Rows.Count > 0)
                MessageBox.Show("username 1 is takem");
            else
            {
                Users c = new Users();

                if (Check_input(c))
                {
                    strSql = "INSERT INTO Users VALUES ('" + nameTxt1.Text + "',#" + pick1.Value + "#,'" + acnum + "')";
                    MessageBox.Show(GeneralUtilities.AddRecd(Tusers, strSql));
                   
                }
            }
            if (nameTxt2.Text.ToString() != "")
            {
                strSql = "Select * from Users where username='" + nameTxt2.Text + "'";
                Class1.GetDataSet(strSql);
                if (Class1.ds.Tables[0].Rows.Count > 0)
                    MessageBox.Show("username 2 is takem");
                else
                {
                    Users c = new Users();

                    if (Check_input(c))
                    {
                        strSql = "INSERT INTO Users VALUES ('" + nameTxt2.Text + "','" + pick2.Text + "','" + acnum + "')";
                        MessageBox.Show(GeneralUtilities.AddRecd(Tusers, strSql));

                    }
                }
            }
            if (nameTxt3.Text.ToString() != "")
            {
                strSql = "Select * from Users where username='" + nameTxt3.Text + "'";
                Class1.GetDataSet(strSql);
                if (Class1.ds.Tables[0].Rows.Count > 0)
                    MessageBox.Show("username 3 is takem");
                else
                {
                    Users c = new Users();

                    if (Check_input(c))
                    {
                        strSql = "INSERT INTO Users VALUES ('" + nameTxt3.Text + "','" + pick3.Text + "','" + acnum + "')";
                        MessageBox.Show(GeneralUtilities.AddRecd(Tusers, strSql));

                    }
                }
            }
            if (nameTxt4.Text.ToString() != "")
            {
                strSql = "Select * from Users where username='" + nameTxt4.Text + "'";
                Class1.GetDataSet(strSql);
                if (Class1.ds.Tables[0].Rows.Count > 0)
                    MessageBox.Show("username 4 is takem");
                else
                {
                    Users c = new Users();

                    if (Check_input(c))
                    {
                        strSql = "INSERT INTO Users VALUES ('" + nameTxt4.Text + "','" + pick4.Text + "','" + acnum + "')";
                        MessageBox.Show(GeneralUtilities.AddRecd(Tusers, strSql));

                    }
                }
            }
            if (nameTxt5.Text.ToString() != "")
            {
                strSql = "Select * from Users where username='" + nameTxt5.Text + "'";
                Class1.GetDataSet(strSql);
                if (Class1.ds.Tables[0].Rows.Count > 0)
                    MessageBox.Show("username 5 is takem");
                else
                {
                    Users c = new Users();

                    if (Check_input(c))
                    {
                        strSql = "INSERT INTO Users VALUES ('" + nameTxt5.Text + "','" + pick5.Text + "','" + acnum + "')";
                        MessageBox.Show(GeneralUtilities.AddRecd(Tusers, strSql));

                    }
                }
            }
            MessageBox.Show("Users added!");
            frmUsersChooseC users = new frmUsersChooseC(acnum.ToString());
            users.Show();
            this.Hide();
        }

        private void name3_Click(object sender, EventArgs e)
        {

        }

        private void nameTxt1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pick1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
