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
                    strSql = "SELECT Users.userName, Users.dateOfBirth, Users.accountNum FROM Users WHERE (Users.accountNum) ='" +accountNumTxt.Text + "'";
                    Class1.GetDataSet(strSql);
                    if (Class1.ds.Tables[0].Rows.Count == 0)
                        MessageBox.Show("Cant add users for non existing account");
                    else
                    {
                        Users c = new Users();

                        if (Check_input(c))
                        {
                            strSql = "INSERT INTO Users VALUES ('" + userTxt.Text + "',#" + birthPick.Value + "#,'" +accountNumTxt.Text + "' )";
                            Utilities.GeneralUtilities.AddRecd(Tusers, strSql);
                        //    MessageBox.Show(GeneralUtilities.AddRecd(Tusers, strSql));
                            frmUsersM_Load(sender, e);
                        }
                    }
                }
            }

            if (checkpoint == "edit")
            {
                string strSql;
                if (!(DisplayUtilities.ContIsfull(this)))
                    MessageBox.Show("Missing data");
              
                else
                {
                    Users c = new Users();

                    if (Check_input(c))
                    {
                        strSql = "UPDATE Users SET Users.[username] = '" + userTxt.Text + "', Users.[dateOfBirth]=#" + birthPick.Value + "# WHERE Users.[accountNumber]='" + accountNumTxt.Text + "'";
                        Utilities.GeneralUtilities.UpDateRecd(Tusers, strSql);
                        MessageBox.Show(GeneralUtilities.AddRecd(Tusers, strSql));
                        frmUsersM_Load(sender, e);
                    }
                }
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
            DisplayUtilities.ClearControls(this);
            addBtn.Enabled = true;
            checkpoint = "add";
            DisplayUtilities.EnableControls(this);

        }

        private void accountNumTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            frmManagerDataM control = new frmManagerDataM();
            control.Show();
            this.Hide();
        }

        private void usersGrid_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            userTxt.Text = usersGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
            birthPick.Value = Convert.ToDateTime(usersGrid.Rows[e.RowIndex].Cells[1].Value.ToString());
            accountNumTxt.Text = usersGrid.Rows[e.RowIndex].Cells[2].Value.ToString();

        }

        private void clearBtn_Click_1(object sender, EventArgs e)
        {
            DisplayUtilities.ClearControls(this);
            addBtn.Enabled = true;
            checkpoint = "add";
            DisplayUtilities.EnableControls(this);
        }
    }
}
