using agam.Class;
using agam.Data;
using agam.utilities;
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
        DataTable Taccounts;

        public frmSignUp()
        {
            InitializeComponent();
            Location = new Point(200, 200);

            Taccounts = Class1.OpenTable("Accounts");
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            frmlogin x = new frmlogin();
            x.Show();
            this.Hide();
        }

        private bool Check_input(Accounts d)
        {
            bool flag = true;
           
            try
            {
                d.Id = idTxt.Text.ToString();
                errorProvider1.SetError(idTxt, "");
                flag = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                flag = false;
                errorProvider1.SetError(idTxt, ex.Message);
            }
            try
            {
                d.PhoneNumber = phoneTxt.Text.ToString();
                errorProvider1.SetError(phoneTxt, "");
                flag = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                flag = false;
                errorProvider1.SetError(phoneTxt, ex.Message);
            }
            try
            {
                d.DateOfBirth = Convert.ToDateTime(dateTimePicker.Text.ToString());
                errorProvider1.SetError(dateTimePicker, "");
                flag = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                flag = false;
                errorProvider1.SetError(dateTimePicker, ex.Message);
            }

            try
            {
                d.Name = nameTxt.Text.ToString();
                errorProvider1.SetError(nameTxt, "");
                flag = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                flag = false;
                errorProvider1.SetError(nameTxt, ex.Message);
            }
            try
            {
                d.Password = passwordTxt.Text.ToString();
                errorProvider1.SetError(passwordTxt, "");
                flag = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                flag = false;
                errorProvider1.SetError(passwordTxt, ex.Message);
            }

            try
            {
                d.CreditCard = creditTxt.Text.ToString();
                errorProvider1.SetError(creditTxt, "");
                flag = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                flag = false;
                errorProvider1.SetError(creditTxt, ex.Message);
            }
            try
            {
                d.AccountType = typePick.Text.ToString();
                errorProvider1.SetError(typePick, "");
                flag = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                flag = false;
                errorProvider1.SetError(typePick, ex.Message);
            }
            return flag;
        }
        private void signUpbtn_Click(object sender, EventArgs e)
        {
            string strSql;
            if (!(DisplayUtilities.ContIsfull(this)))
                MessageBox.Show("Missing data");
            else
            {
                int accountNum = Taccounts.Rows.Count + 1;
                 Accounts c = new Accounts();
                string sql = "SELECT AccountTypes.[charge] FROM AccountTypes WHERE AccountTypes.[typeName]='"+typePick.Text+"'";
                DataTable db = Class1.OpenTableWithCondition(sql);
                double charge = Convert.ToDouble(db.Rows[0][0]);
                    if (Check_input(c))
                    {
                        strSql = "INSERT INTO Accounts VALUES ('" + accountNum + "','" + idTxt.Text + "','" + phoneTxt.Text + "',#" + dateTimePicker.Value + "#,'" + charge + "','" + nameTxt.Text + "','" + passwordTxt.Text + "','" + creditTxt.Text + "','" + typePick.Text + "')";
                        Utilities.GeneralUtilities.AddRecd(Taccounts, strSql);
                        MessageBox.Show("account added!");
                        frmAddUsersC users = new frmAddUsersC(accountNum);
                        users.Show();
                        this.Hide();
                    }
            }
        }

        private void typePick_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
