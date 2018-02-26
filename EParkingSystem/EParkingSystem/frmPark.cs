using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EParkingSystem
{
    public partial class frmPark : Form
    {
        public frmPark()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        string sql;
        clsProgram p1 = new clsProgram();
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Trim() == "" || txtMobile.Text.Trim() == "" || txtcar.Text.Trim() == "" || cmbType.Text.Trim() == "" || cmbDocument.Text.Trim() == "" || txtDocumentno.Text.Trim() == "")
            {
                MessageBox.Show("Please Enter All Data");
            }
            else
            {
                sql = "insert into tblPark(Date,Name,Mobile,CarNo,CarType,Documents,DocumentNo)values('" + string.Format("{0:MM/dd/yyyy}", dtpDate.Value) + "','" + txtName.Text + "','" + txtMobile.Text + "','" + txtcar.Text + "','" + cmbType.Text + "','" + cmbDocument.Text + "','" + txtDocumentno.Text + "')";
                p1.execute(sql);
                MessageBox.Show("Record Insert sucessfully");
                reset();
            }
        }
        int b;
        private void txtMobile_KeyPress(object sender, KeyPressEventArgs e)
        {
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
        public void reset()
        {
            txtName.Text = "";
            txtMobile.Text="";
            txtcar.Text = "";
            cmbType.SelectedIndex = -1;
            cmbDocument.SelectedIndex = -1;
            txtDocumentno.Text = "";
            txtName.Focus();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
