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
    public partial class FrmAccountTypesM : Form
    {
        int count;
        DataTable TaccountTypes;
        public FrmAccountTypesM()
        {
            InitializeComponent();
        }

        private void addNewBtn_Click(object sender, EventArgs e)
        {
            // clear fields
            addBtn.Enabled = true;
            checkpoint = "add";
            DisplayUtilities.EnableControls(this);
            typeNameTxt.Text = (TaccountTypes.Rows.Count + 1).ToString();
        }

        private void FrmAccountTypesM_Load(object sender, EventArgs e)
        {
            Location = new Point(200, 200);

            TaccountTypes = Class1.OpenTable("AccountTypes");

            DisplayUtilities.FillDataGrid(dataGridView1, TaccountTypes);
            count = 0;
            DisplayRecord(0);
        }
        private void DisplayRecord(int currentRow)
        {
            typeNameTxt.Text =dataGridView1.Rows[currentRow].Cells[0].Value.ToString();
           chargeTxt.Text = dataGridView1.Rows[currentRow].Cells[1].Value.ToString();
        }
        private bool Check_input(AccountTypes d)
        {
            bool flag = true;
            try
            {
                d.TypeName = typeNameTxt.Text.ToString();
                errorProvider1.SetError(typeNameTxt, "");
                flag = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                flag = false;
                errorProvider1.SetError(typeNameTxt, ex.Message);
            }
            try
            {
                d.Charge = Convert.ToDouble(chargeTxt.Text);
                errorProvider1.SetError(chargeTxt, "");
                flag = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                flag = false;
                errorProvider1.SetError(chargeTxt, ex.Message);
            }

            return flag;
        }
        string checkpoint;

        private void editBtn_Click(object sender, EventArgs e)
        {
            checkpoint = "edit";
            DisplayUtilities.EnableControls(this);
            typeNameTxt.Enabled = false;
            editBtn.Enabled = false;
            typeNameTxt.Enabled = false;

        }

        private void prevBtn_Click(object sender, EventArgs e)
        {
            frmMoviesM movie = new frmMoviesM();
            movie.Show();
            this.Hide();
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
                    strSql = "Select * from AccountTypes where typeName='" + typeName.Text + "'";
                    Class1.GetDataSet(strSql);
                    if (Class1.ds.Tables[0].Rows.Count > 0)
                        MessageBox.Show("This already exists");
                    else
                    {
                        AccountTypes c = new AccountTypes();

                        if (Check_input(c))
                        {
                            strSql = "INSERT INTO AccountTypes VALUES ('" + typeNameTxt.Text + "','" + chargeTxt.Text + "')";
                            Utilities.GeneralUtilities.AddRecd(TaccountTypes, strSql);
                            MessageBox.Show(GeneralUtilities.AddRecd(TaccountTypes, strSql));
                            FrmAccountTypesM_Load(sender, e);
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
                    AccountTypes c = new AccountTypes();

                    if (Check_input(c))
                    {
                        strSql = "UPDATE AccountTypes SET AccountTypes.[typeName] = '" + typeNameTxt.Text + "', Accounts.[charge]='" + chargeTxt.Text + "'";
                        Utilities.GeneralUtilities.UpDateRecd(TaccountTypes, strSql);
                        MessageBox.Show(GeneralUtilities.AddRecd(TaccountTypes, strSql));
                        FrmAccountTypesM_Load(sender, e);
                    }
                }
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            frmManagerDataM control = new frmManagerDataM();
            control.Show();
            this.Hide();
        }
        private void dataGridView1__RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            typeNameTxt.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            chargeTxt.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string txt = searchBox.Text;

            string sql = $"SELECT * FROM AccountTypes WHERE typeName LIKE '%{typeNameTxt.Text}%' OR " +
                $"charge LIKE '%{chargeTxt.Text}%'";

            TaccountTypes = Class1.OpenTableWithCondition(sql);
            DisplayUtilities.FillDataGrid(dataGridView1, TaccountTypes);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FrmAccountTypesM_Load(sender, e);
        }
    }
}
