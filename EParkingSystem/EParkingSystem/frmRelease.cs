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
    public partial class frmRelease : Form
    {
        public frmRelease()
        {
            InitializeComponent();
        }
        clsProgram p1 = new clsProgram();
        string sql;
        DataSet ds;
       
        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            cmbCarNo.Items.Clear();
            sql = "select CarNo from tblPark where Date='" + string.Format("{0:MM/dd/yyyy}", dtpDate.Value) + "'";
            ds = p1.fillds(sql);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                cmbCarNo.Items.Add(ds.Tables[0].Rows[i].ItemArray[0].ToString());

            }

        }

        private void cmbCarNo_TextChanged(object sender, EventArgs e)
        {
            sql = "select Name,CarType,Documents,DocumentNo from tblPark where CarNo = '" + cmbCarNo.Text + "' AND Date='" + string.Format("{0:MM/dd/yyyy}", dtpDate.Value) + "'";
            ds = p1.fillds(sql);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                txtName.Text = ds.Tables[0].Rows[i].ItemArray[0].ToString();
                txtType.Text = ds.Tables[0].Rows[i].ItemArray[1].ToString();
                txtDocument.Text = ds.Tables[0].Rows[i].ItemArray[2].ToString();
                txtDocumentno.Text = ds.Tables[0].Rows[i].ItemArray[3].ToString();
              
            }
            sql = "select Price from tblAddPrice where Type = '" + txtType.Text + "'";
            ds = p1.fillds(sql);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                txtCharge.Text = ds.Tables[0].Rows[i].ItemArray[0].ToString();

            }
        }

        private void cmbDays_TextChanged(object sender, EventArgs e)
        {
            if (cmbDays.Text == "1")
            {
                txtTotal.Text = Convert.ToString(Convert.ToDouble(txtCharge.Text) * 1);
            }
            else if (cmbDays.Text == "2")
            {
                txtTotal.Text = Convert.ToString(Convert.ToDouble(txtCharge.Text) * 2);
            }

            else if (cmbDays.Text == "3")
            {
                txtTotal.Text = Convert.ToString(Convert.ToDouble(txtCharge.Text) * 3);
            }
            else if (cmbDays.Text == "4")
            {
                txtTotal.Text = Convert.ToString(Convert.ToDouble(txtCharge.Text) * 4);
            }
            else if (cmbDays.Text == "5")
            {
                txtTotal.Text = Convert.ToString(Convert.ToDouble(txtCharge.Text) * 5);
            }
            else if (cmbDays.Text == "6")
            {
                txtTotal.Text = Convert.ToString(Convert.ToDouble(txtCharge.Text) * 6);
            }
            else if (cmbDays.Text == "7")
            {
                txtTotal.Text = Convert.ToString(Convert.ToDouble(txtCharge.Text) * 7);
            }
            else if (cmbDays.Text == "8")
            {
                txtTotal.Text = Convert.ToString(Convert.ToDouble(txtCharge.Text) * 8);
            }
            else if (cmbDays.Text == "9")
            {
                txtTotal.Text = Convert.ToString(Convert.ToDouble(txtCharge.Text) * 9);
            }
            else if (cmbDays.Text == "10")
            {
                txtTotal.Text = Convert.ToString(Convert.ToDouble(txtCharge.Text) * 10);
            }
            else if (cmbDays.Text == "11")
            {
                txtTotal.Text = Convert.ToString(Convert.ToDouble(txtCharge.Text) * 11);
            }
            else if (cmbDays.Text == "12")
            {
                txtTotal.Text = Convert.ToString(Convert.ToDouble(txtCharge.Text) * 12);
            }
            else if (cmbDays.Text == "13")
            {
                txtTotal.Text = Convert.ToString(Convert.ToDouble(txtCharge.Text) * 13);
            }
            else if (cmbDays.Text == "14")
            {
                txtTotal.Text = Convert.ToString(Convert.ToDouble(txtCharge.Text) * 14);
            }
            else if (cmbDays.Text == "15")
            {
                txtTotal.Text = Convert.ToString(Convert.ToDouble(txtCharge.Text) * 15);
            }
            else if (cmbDays.Text == "16")
            {
                txtTotal.Text = Convert.ToString(Convert.ToDouble(txtCharge.Text) * 16);
            }
            else if (cmbDays.Text == "17")
            {
                txtTotal.Text = Convert.ToString(Convert.ToDouble(txtCharge.Text) * 17);
            }
            else if (cmbDays.Text == "18")
            {
                txtTotal.Text = Convert.ToString(Convert.ToDouble(txtCharge.Text) * 18);
            }
            else if (cmbDays.Text == "19")
            {
                txtTotal.Text = Convert.ToString(Convert.ToDouble(txtCharge.Text) * 19);
            }
            else if (cmbDays.Text == "20")
            {
                txtTotal.Text = Convert.ToString(Convert.ToDouble(txtCharge.Text) * 20);
            }
            else if (cmbDays.Text == "21")
            {
                txtTotal.Text = Convert.ToString(Convert.ToDouble(txtCharge.Text) * 21);
            }
            else if (cmbDays.Text == "22")
            {
                txtTotal.Text = Convert.ToString(Convert.ToDouble(txtCharge.Text) * 22);
            }
            else if (cmbDays.Text == "23")
            {
                txtTotal.Text = Convert.ToString(Convert.ToDouble(txtCharge.Text) * 23);
            }
            else if (cmbDays.Text == "24")
            {
                txtTotal.Text = Convert.ToString(Convert.ToDouble(txtCharge.Text) * 24);
            }
            else if (cmbDays.Text == "25")
            {
                txtTotal.Text = Convert.ToString(Convert.ToDouble(txtCharge.Text) * 25);
            }
            else if (cmbDays.Text == "26")
            {
                txtTotal.Text = Convert.ToString(Convert.ToDouble(txtCharge.Text) * 26);
            }
            else if (cmbDays.Text == "27")
            {
                txtTotal.Text = Convert.ToString(Convert.ToDouble(txtCharge.Text) * 27);
            }
            else if (cmbDays.Text == "28")
            {
                txtTotal.Text = Convert.ToString(Convert.ToDouble(txtCharge.Text) * 28);
            }
            else if (cmbDays.Text == "29")
            {
                txtTotal.Text = Convert.ToString(Convert.ToDouble(txtCharge.Text) * 29);
            }
            else if (cmbDays.Text == "30")
            {
                txtTotal.Text = Convert.ToString(Convert.ToDouble(txtCharge.Text) * 30);
            }



        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cmbDays.Text.Trim() == "" || cmbCarNo.Text.Trim() == "")
            {
                MessageBox.Show("Please Enter all fields");
            }
            else
            {
                sql = "insert into tblRelease(Date,CarNo,Name,CarType,Charge,Days,TotalFees)values('" + string.Format("{0:MM/dd/yyyy}", dtpDate.Value) + "','" + cmbCarNo.Text + "','" + txtName.Text + "','" + txtType.Text + "','" + txtCharge.Text + "','" + cmbDays.Text + "','" + txtTotal.Text + "')";
                p1.execute(sql);
                MessageBox.Show("Record Insert sucessfully");
                reset();
            }
        }
        public void reset()
        {
            cmbCarNo.SelectedIndex=-1;
                txtName.Text="";
                txtType.Text="";
                    txtDocument.Text="";
                    txtDocumentno.Text="";
                        txtCharge.Text="";
                        cmbDays.SelectedIndex = -1;
                            txtTotal.Text="";
                            cmbCarNo.Focus();
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       }
}
