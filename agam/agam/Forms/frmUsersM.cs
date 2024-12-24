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
    public partial class frmUsersM : Form
    {
        int count;
        DataTable Tusers;
        public frmUsersM()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AddBtn_Click(object sender, EventArgs e)
        {

        }

        private void prevBtn_Click(object sender, EventArgs e)
        {
            frmAccountsM account = new frmAccountsM();
            account.Show();
            this.Hide();
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            frmTvShowsM show = new frmTvShowsM();
            show.Show();
            this.Hide();
        }

        private void frmUsersM_Load(object sender, EventArgs e)
        {
            Location = new Point(200, 200);

            Tusers = Class1.OpenTable("Users");

            DisplayUtilities.FillDataGrid(usersGrid, Tusers);
            count = 0;
            DisplayRecord(0);

        }
        private void DisplayRecord(int currentRow)
        {
            userTxt.Text = usersGrid.Rows[currentRow].Cells[0].Value.ToString();
            birthPick.Value = Convert.ToDateTime( usersGrid.Rows[currentRow].Cells[1].Value.ToString());
            accountNumTxt.Text = usersGrid.Rows[currentRow].Cells[2].Value.ToString();

        }
        private bool Check_input(Users d)
        {
            bool flag = true;
            /*try
            {
                d.AccountNum = accountNumTxt.Text.ToString();
                errorProvider1.SetError(accountNumTxt, "");
                flag = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                flag = false;
                errorProvider1.SetError(accountNumTxt, ex.Message);
            }*/
            try
            {
                d.UserName = userTxt.Text.ToString();
                errorProvider1.SetError(userTxt, "");
                flag = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                flag = false;
                errorProvider1.SetError(userTxt, ex.Message);
            }
            
            return flag;
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
                    strSql = "Select * from Users where accountNumber='" + accountNumTxt.Text + "'";
                    Class1.GetDataSet(strSql);
                    if (Class1.ds.Tables[0].Rows.Count > 0)
                        MessageBox.Show("This already exists");
                    else
                    {
                        Users c = new Users();

                        if (Check_input(c))
                        {
                            strSql = "INSERT INTO Users VALUES ('" + accountNumTxt.Text + "','" + userTxt.Text + "','" + birthPick.Text +"')";
                            MessageBox.Show(GeneralUtilities.AddRecd(Tusers, strSql));
                            frmUsersM_Load(sender, e);
                        }
                    }
                }
            }

            if (checkpoint == "edit")
            {

            }
        }
        string checkpoint;
        private void editBtn_Click(object sender, EventArgs e)
        {
            checkpoint = "edit";
            DisplayUtilities.EnableControls(this);
            accountNumTxt.Enabled = false;
            editBtn.Enabled = false;


        }
        private void clearBtn_Click(object sender, EventArgs e)
        {
            // clear fields
            addBtn.Enabled = true;
            checkpoint = "add";
            DisplayUtilities.EnableControls(this);

        }

        private void accountNumTxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
