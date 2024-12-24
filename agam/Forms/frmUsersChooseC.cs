using agam.Data;
using agam.utilities;
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
   
    public partial class frmUsersChooseC : Form
    {
        DataTable Tusers;
        int count;
        string acNum;
        public frmUsersChooseC(String accountNum)
        {
            InitializeComponent();
            acNum = accountNum;
            Location = new Point(200, 200);
            string sql = "SELECT * FROM Users WHERE (Users.accountNum)='" + accountNum + "'";

            //  string sql= "SELECT Users.userName, Users.dateOfBirth, Users.accountNum FROM Users WHERE Users.accountNum='1'";
            

            Class1.GetDataSet(sql);
            //if (Class1.ds.Tables[0].Rows.Count == 0)
            //    MessageBox.Show("לקוח לא קיים") ;
            Tusers = Class1.ds.Tables[0];


          //  Tusers = Class1.OpenTable(sql);
            count = 0;
            
            user1.Text = Tusers.Rows[0][0].ToString();
            if(Tusers.Rows.Count>1)
                user2.Text = Tusers.Rows[1][0].ToString();
            if (Tusers.Rows.Count > 2)
                user3.Text = Tusers.Rows[2][0].ToString();
            if (Tusers.Rows.Count > 3)
                user4.Text = Tusers.Rows[3][0].ToString();
            if (Tusers.Rows.Count > 4)
                user5.Text = Tusers.Rows[5][0].ToString();
            //DisplayRecord(0);
        }
      
        private void frmUsersChooseC_Load(object sender, EventArgs e)
        {
        }

        private void user1_Click(object sender, EventArgs e)
        {
            frmMyListC list = new frmMyListC(user1.Text.ToString());
            this.Hide();
            list.Show();

        }

        private void user2_Click(object sender, EventArgs e)
        {
            frmMyListC list = new frmMyListC(user2.Text.ToString());
            this.Hide();
            list.Show();
        }

        private void user3_Click(object sender, EventArgs e)
        {
            frmMyListC list = new frmMyListC(user3.Text.ToString());
            this.Hide();
            list.Show();
        }

        private void user4_Click(object sender, EventArgs e)
        {
            frmMyListC list = new frmMyListC(user4.Text.ToString());
            this.Hide();
            list.Show();
        }

        private void user5_Click(object sender, EventArgs e)
        {
            frmMyListC list = new frmMyListC(user5.Text.ToString());
            this.Hide();
            list.Show();
        }
    }
}
