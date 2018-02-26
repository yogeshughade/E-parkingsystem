using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System .Data;

namespace EParkingSystem
{
    class clsProgram
    {
        SqlConnection con = new SqlConnection("Data Source=RK-PC;Initial Catalog=EParking;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter adp = new SqlDataAdapter();
        DataSet ds;
        int u;
        public void conn()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }
         public int exescl(string sql)
        {
            conn();
            cmd = new SqlCommand(sql, con);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            int xyz = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();
            return xyz;
        }

        public void execute(string sql)
        {
            
            cmd = new SqlCommand(sql, con);
            conn();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public int scalar(string sql)
        {
            cmd = new SqlCommand(sql, con);
            conn();
             u = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();
            return u;
        }
        public DataSet fillds(string sql)
        {
            adp = new SqlDataAdapter(sql, con);
            con.Open();
            conn();
            ds = new DataSet();
            adp.Fill(ds);
            con.Close();
            return ds;
        }



    }
    }

