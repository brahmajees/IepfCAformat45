using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace IepfCAformat45
{
    public partial class iepfcacdsl45 : Form
    {
        public iepfcacdsl45()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
                //SqlConnection con = new SqlConnection("Data Source=VCCIPL-TECH\\VENTURESQLEXP;Initial Catalog=VCCIPL;Integrated Security=True;");
                SqlConnection con = new SqlConnection("Data Source=192.168.0.138,1433;Initial Catalog=VCCIPL;User ID=sa;Password=Password123$;Integrated Security = true;");
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into Iepfcacdsl45hd " +
                    "(Record_Id,Rta_Id,Rtaint_Refno,Isin,Ca_Type," +
                    "Bapr_Dt,Exec_Dt,Totdrqty,Totdrqty_Lin,Filler01,Totcrqty," +
                    "Totcrqty_Lin,Totdetrec,Filler02,Cin_Bcin_No,Email_Co," +
                    "Fywdivrel,Totnomamt_Shr,Masteruniqno) " +
                    "values(@Record_Id,@Rta_Id,@Rtaint_Refno,@Isin,@Ca_Type,@Bapr_Dt," +
                    "@Exec_Dt,@Totdrqty,@Totdrqty_Lin,@Filler01,@Totcrqty,@Totcrqty_Lin," +
                    "@Totdetrec,@Filler02,@Cin_Bcin_No,@Email_Co,@Fywdivrel,@Totnomamt_Shr,@MasteruniqNo)", con);
                cmd.Parameters.AddWithValue("@Record_Id", txtRecidentification.Text);
                cmd.Parameters.AddWithValue("@Rta_Id", txtFileidentification.Text);
                cmd.Parameters.AddWithValue("@Rtaint_Refno", txtIntrefno.Text);
                cmd.Parameters.AddWithValue("@Isin", txtIsin.Text);
                cmd.Parameters.AddWithValue("@Ca_Type", txtCaType01.Text);
                cmd.Parameters.AddWithValue("@Bapr_Dt", dateTimePicker1.Value.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@Exec_Dt", dateTimePicker2.Value.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@Totdrqty", txtDrqty.Text);
                cmd.Parameters.AddWithValue("@Totdrqty_Lin", txtTotaldrqtyli.Text);
                cmd.Parameters.AddWithValue("@Filler01", txtFiller01.Text);
                cmd.Parameters.AddWithValue("@Totcrqty", txtTotcrqty.Text);
                cmd.Parameters.AddWithValue("@Totcrqty_Lin", txtCrqtylin.Text);
                cmd.Parameters.AddWithValue("@Totdetrec", txtTotdedrec.Text);
                cmd.Parameters.AddWithValue("@Filler02", txtFiller2.Text);
                cmd.Parameters.AddWithValue("@Cin_Bcin_No", txtCinBcinNo.Text);
                cmd.Parameters.AddWithValue("@Email_Co", txtCompanyEmailid.Text);
                cmd.Parameters.AddWithValue("@Fywdivrel", txtFyAmtRel.Text);
                cmd.Parameters.AddWithValue("@Totnomamt_Shr", txtTotNominalAmtShr.Text);
                cmd.Parameters.AddWithValue("@MasterUniqNo", txtMun01.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Data has saved in Iepfcacdsl45hd Database");
        }

        private void btnView01_Click(object sender, EventArgs e)
        {
               //< add name = "ConnectionString" connectionString = "Data Source=192.168.0.82,1433;Network Library=DBMSSOCN;Initial Catalog=NewsAdvt;User ID=sa;Password=sql;" providerName = "System.Data.SqlClient" />
                SqlConnection con = new SqlConnection("Data Source=192.168.0.138,1433;Initial Catalog=VCCIPL;User ID=sa;Password=Password123$;Integrated Security = true;");
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from Iepfcacdsl45hd", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnSave02_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=192.168.0.138,1433;Initial Catalog=VCCIPL;User ID=sa;Password=Password123$;Integrated Security = true;");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Iepfcacdsl45dt " +
                "(Record_Id,Rec_Lineno,Credit_Boid,Debit_Boid,Dr_Qty,Dr_Qty_Lin,Dr_Lin_Code," +
                "Dr_Lin_Exp_Dt,Filler01,Cr_Qty,Cr_Qty_Lin,Cr_Lin_Code," +
                "Cr_Lin_Exp_Dt,Filler02,MasterUniqNo) " +
                "values(@Record_Id,@Rec_Lineno,@Credit_Boid,@Debit_Boid,@Dr_Qty,@Dr_Qty_Lin,@Dr_Lin_Code," +
                "@Dr_Lin_Exp_Dt,@Filler01,@Cr_Qty,@Cr_Qty_Lin,@Cr_Lin_Code,@Cr_Lin_Exp_Dt," +
                "@Filler02,@MasterUniqNo)", con);
            cmd.Parameters.AddWithValue("@Record_Id", txtRecid02.Text);
            cmd.Parameters.AddWithValue("@Rec_Lineno", txtDetrec02.Text);
            cmd.Parameters.AddWithValue("@Credit_Boid", txtCrBoid.Text);
            cmd.Parameters.AddWithValue("@Debit_Boid", txtDrBoid.Text);
            cmd.Parameters.AddWithValue("@Dr_Qty", txtDebitQty.Text);
            cmd.Parameters.AddWithValue("@Dr_Qty_Lin", txtDrlinqty.Text);
            var drlincode = comboBox9.Text.Substring(0, 2);
            cmd.Parameters.AddWithValue("@Dr_Lin_Code", drlincode);
            cmd.Parameters.AddWithValue("@Dr_Lin_Exp_Dt", dateTimePicker3.Value.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("@Filler01", txtFiller0201.Text);
            cmd.Parameters.AddWithValue("@Cr_Qty", txtCrQty.Text);
            cmd.Parameters.AddWithValue("@Cr_Qty_Lin", txtCrlinqty.Text);
            var crlincode = comboBox1.Text.Substring(0, 2);
            cmd.Parameters.AddWithValue("@Cr_Lin_Code", crlincode);
            cmd.Parameters.AddWithValue("@Cr_Lin_Exp_Dt", dateTimePicker3.Value.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("@Filler02", txtFiller0202.Text);
            cmd.Parameters.AddWithValue("@MasterUniqNo", txtMastuniqno02.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data has saved in Iepfcacdsl45dt Database");

        }

        private void btnView02_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=192.168.0.138,1433;Initial Catalog=VCCIPL;User ID=sa;Password=Password123$;Integrated Security = true;");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Iepfcacdsl45dt", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;
        }

    }
}

/*
Record_Id,Rta_Id,Rtaint_Refno,Isin,Ca_Type,Bapr_Dt,Exec_Dt,Totdrqty,Totdrqty_Lin,Filler01,Totcrqty,Totcrqty_Lin,Totdetrec,Filler02,Cin_Bcin_No,Email_Co,Fywdivrel,Totnomamt_Shr,Masteruniqno
--
@Record_Id,@Rta_Id,@Rtaint_Refno,@Isin,@Ca_Type,@Bapr_Dt,@Exec_Dt,@Totdrqty,@Totdrqty_Lin,@Filler01,@Totcrqty,@Totcrqty_Lin,@Totdetrec,@Filler02,@Cin_Bcin_No,@Email_Co,@Fywdivrel,@Totnomamt_Shr,@MasteruniqNo@
*/

/*
Record_Id,Rec_Lineno,Credit_Boid,Debit_Boid,Dr_Qty,Dr_Qty_Lin,Dr_Lin_Code,Dr_Lin_Exp_Dt,Filler01,Cr_Qty,Cr_Qty_Lin,Cr_Lin_Code,Cr_Lin_Exp_Dt,Filler02,MasterUniqNo	

@Record_Id,@Rec_Lineno,@Credit_Boid,@Debit_Boid,@Dr_Qty,@Dr_Qty_Lin,@Dr_Lin_Code,@Dr_Lin_Exp_Dt,@Filler01,@Cr_Qty,@Cr_Qty_Lin,@Cr_Lin_Code,@Cr_Lin_Exp_Dt,@Filler02,@MasterUniqNo	

*/