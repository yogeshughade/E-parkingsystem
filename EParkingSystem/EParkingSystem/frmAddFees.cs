using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace EParkingSystem
{
    public partial class frmAddFees : Form
    {
        public frmAddFees()
        {
            InitializeComponent();
        }
        string sql;
        clsProgram p1 = new clsProgram();
        SqlConnection con = new SqlConnection("Data Source=RK-PC;Initial Catalog=EParking;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter adp = new SqlDataAdapter();
        DataSet ds = new DataSet();
        public void reset()
        {
            txtPrice.Text = "";
            cmbType.SelectedIndex = -1;
            cmbType.Focus();
        }
        
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (cmbType.Text == "")
            {
                MessageBox.Show("Please  Select Type First");
            }
            
            else
            {
                sql = "Update tblAddPrice set Price='" + txtPrice.Text + "' Where Type = '" + cmbType .Text + "'";
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("New Price Updated Successfully");
                reset();
            }
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            int b;
            int a = e.KeyChar;
            if (a >= 48 && a <= 57 || a == 8 || a == 46)
            {
                b = 0;
            }
            else
            {
                e.Handled = true;
            }
        
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
