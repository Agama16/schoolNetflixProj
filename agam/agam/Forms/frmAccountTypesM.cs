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
                            MessageBox.Show(GeneralUtilities.AddRecd(TaccountTypes, strSql));
                            FrmAccountTypesM_Load(sender, e);
                        }
                    }
                }
            }

            if (checkpoint == "edit")
            {

            }
        }
    }
}
