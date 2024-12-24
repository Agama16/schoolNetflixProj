using agam.Class;
using agam.Data;
using agam.utilities;
using agam.Utilities;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace agam.Forms
{
    public partial class frmAccountsM : Form
    {
        int count;
        DataTable Taccounts;
        public frmAccountsM()
        {
            InitializeComponent();
            Location = new Point(200, 200);

            Taccounts = Class1.OpenTable("Accounts");

            DisplayUtilities.FillDataGrid(accountsGrid, Taccounts);
            count = 0;
            DisplayRecord(0);

            //  DisplayRecord(count);

        }

        private void frmAccountsM_Load(object sender, EventArgs e)
        {
            
                Location = new Point(200, 200);

                Taccounts = Class1.OpenTable("Accounts"); 

               DisplayUtilities.FillDataGrid(accountsGrid, Taccounts);      
            count = 0;
            DisplayRecord(0);

          //  DisplayRecord(count);
            

        }

        private void DisplayRecord(int currentRow)
        {
            accountNumTxt.Text = accountsGrid.Rows[currentRow].Cells[0].Value.ToString();
            idTxt.Text = accountsGrid.Rows[currentRow].Cells[1].Value.ToString();
            phoneNumTxt.Text = accountsGrid.Rows[currentRow].Cells[2].Value.ToString();
            dateOfBirthPick.Value = Convert.ToDateTime(accountsGrid.Rows[currentRow].Cells[3].Value);
            chargeTxt.Text = accountsGrid.Rows[currentRow].Cells[4].Value.ToString();
            nameTxt.Text = accountsGrid.Rows[currentRow].Cells[5].Value.ToString();
            passwordTxt.Text = accountsGrid.Rows[currentRow].Cells[6].Value.ToString();
            creditCardTxt.Text = accountsGrid.Rows[currentRow].Cells[7].Value.ToString();
            accountTypePick.Text = accountsGrid.Rows[currentRow].Cells[8].Value.ToString();
            
        }
        private bool Check_input(Accounts d)
        {
            bool flag = true;
            try
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
            }
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
                d.PhoneNumber = phoneNumTxt.Text.ToString();
                errorProvider1.SetError(phoneNumTxt, "");
                flag = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                flag = false;
                errorProvider1.SetError(phoneNumTxt, ex.Message);
            }
            try
            {
                d.DateOfBirth = Convert.ToDateTime( dateOfBirthPick.Text.ToString());
                errorProvider1.SetError(dateOfBirthPick, "");
                flag = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                flag = false;
                errorProvider1.SetError(dateOfBirthPick, ex.Message);
            }
          
           
            try
            {
                d.Charge = Convert.ToInt32(chargeTxt.Text);
                errorProvider1.SetError(chargeTxt, "");
                flag = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                flag = false;
                errorProvider1.SetError(chargeTxt, ex.Message);
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
                d.CreditCard = creditCardTxt.Text.ToString();
                errorProvider1.SetError(creditCardTxt, "");
                flag = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                flag = false;
                errorProvider1.SetError(creditCardTxt, ex.Message);
            }
            try
            {
                d.AccountType = accountTypePick.Text.ToString();
                errorProvider1.SetError(accountTypePick, "");
                flag = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                flag = false;
                errorProvider1.SetError(accountTypePick, ex.Message);
            }
            return flag;
        }

        private void charge_Click(object sender, EventArgs e)
        {

        }

        private void frmAccountsM_Load_1(object sender, EventArgs e)
        {
          

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
                    strSql = "Select * from Accounts where accountNumber='" + accountNumTxt.Text + "'";
                    Class1.GetDataSet(strSql);
                    if (Class1.ds.Tables[0].Rows.Count > 0)
                        MessageBox.Show("This already exists");
                    else
                    {
                        Accounts c = new Accounts();

                        if (Check_input(c))
                        {
                            strSql = "INSERT INTO Accounts VALUES ('" + accountNumTxt.Text + "','" + idTxt.Text + "','" + phoneNumTxt.Text + "',#" + dateOfBirthPick.Text + "#,'" + chargeTxt.Text + "','" + nameTxt.Text + "','" + passwordTxt.Text + "','" + creditCardTxt.Text + "','" + accountTypePick.Text + "')";
                            Utilities.GeneralUtilities.AddRecd(Taccounts, strSql);
                            MessageBox.Show(GeneralUtilities.AddRecd(Taccounts, strSql));
                            frmAccountsM_Load(sender, e);
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
                    Accounts c = new Accounts();

                    if (Check_input(c))
                    {        
                        strSql = "UPDATE Accounts SET Accounts.[name] = '" + nameTxt.Text + "', Accounts.[id]='"+idTxt.Text+"', Accounts.[phoneNumber]='"+phoneNumTxt.Text+"', Accounts.[dateOfBirth]=#"+dateOfBirthPick.Value+"#, Accounts.[charge]='"+chargeTxt.Text+"',Accounts.[password]='"+passwordTxt.Text+"',Accounts.[accountType]='"+accountTypePick.Text+"',Accounts.[creditCard]='"+creditCardTxt.Text+"' WHERE Accounts.[accountNumber]= '" + accountNumTxt.Text + "'";
                        Utilities.GeneralUtilities.UpDateRecd(Taccounts, strSql);
                        MessageBox.Show(GeneralUtilities.AddRecd(Taccounts, strSql));
                        frmAccountsM_Load(sender, e);
                    }
                }
            }
        }

        private void accountsGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            frmUsersM user = new frmUsersM();
            user.Show();
            this.Hide();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            // clear fields
            addBtn.Enabled = true;
            checkpoint = "add";
            DisplayUtilities.EnableControls(this);
            DisplayUtilities.ClearControls(this);
            addBtn.Enabled = true;
            accountNumTxt.Text = (Taccounts.Rows.Count + 1).ToString();

        }
        string checkpoint;
        private void editBtn_Click(object sender, EventArgs e)
        {
            checkpoint = "edit";
            DisplayUtilities.EnableControls(this);
            accountNumTxt.Enabled = false;
            editBtn.Enabled = false;
            addBtn.Enabled = true;


        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            frmManagerDataM control = new frmManagerDataM();
            control.Show();
            this.Hide();
        }

        private void accountsGrid_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            accountNumTxt.Text = accountsGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
            idTxt.Text = accountsGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
            phoneNumTxt.Text = accountsGrid.Rows[e.RowIndex].Cells[2].Value.ToString();
            dateOfBirthPick.Value = Convert.ToDateTime(accountsGrid.Rows[e.RowIndex].Cells[3].Value);
            chargeTxt.Text = accountsGrid.Rows[e.RowIndex].Cells[4].Value.ToString();
            nameTxt.Text = accountsGrid.Rows[e.RowIndex].Cells[5].Value.ToString();
            passwordTxt.Text = accountsGrid.Rows[e.RowIndex].Cells[6].Value.ToString();
            creditCardTxt.Text = accountsGrid.Rows[e.RowIndex].Cells[7].Value.ToString();
            accountTypePick.Text = accountsGrid.Rows[e.RowIndex].Cells[8].Value.ToString();

        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string txt = searchBox.Text;

            string sql = $"SELECT * FROM AccountTypes WHERE name LIKE '%{nameTxt.Text}%' OR " +
                $"id LIKE '%{idTxt.Text}%' OR " +
                $"phoneNumber LIKE '%{phoneNumTxt.Text}%' OR " +
                $"dateOfBirth LIKE '%{dateOfBirthPick.Value}%' OR " +
                $"creditCard LIKE '%{creditCardTxt.Text}%'OR " +
                $"accountType LIKE '%{accountTypePick.Text}%' OR " +
                $"accountNumber LIKE '%{accountNumTxt.Text}%'OR " +
                $"charge LIKE '%{chargeTxt.Text}%'OR " +
                $"password LIKE '%{passwordTxt.Text}%'";

            Taccounts = Class1.OpenTableWithCondition(sql);
            DisplayUtilities.FillDataGrid(accountsGrid, Taccounts);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmAccountsM_Load(sender, e);
        }
    }
}
