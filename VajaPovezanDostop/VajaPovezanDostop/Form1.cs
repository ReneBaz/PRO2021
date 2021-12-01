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

namespace VajaPovezanDostop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label3.Text = "";
            string povezava = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\PRO2021\StudentNet\ŠtudentNet.mdf;Integrated Security=True;Connect Timeout=30";
            SqlConnection p = new SqlConnection(povezava);
            string ukaz = "select ImePredmeta from Predmet";
            SqlCommand u = new SqlCommand();
            u.Connection = p;
            u.CommandText = ukaz;
            u.CommandType = CommandType.Text;

            p.Open();
            SqlDataReader bralec = u.ExecuteReader();
            while (bralec.Read())
            {
                label3.Text += bralec[0]+"\n";
            }
            bralec.Close();
            p.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label3.Text = "";
            string povezava = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\PRO2021\StudentNet\ŠtudentNet.mdf;Integrated Security=True;Connect Timeout=30";
            SqlConnection p = new SqlConnection(povezava);
            string ukaz = "select ocena from ocene where idpredmeta=@predmet";
            SqlCommand u = new SqlCommand();
            u.Connection = p;
            u.CommandText = ukaz;
            u.CommandType = CommandType.Text;

            SqlParameter par = new SqlParameter("@predmet", SqlDbType.Int);
            u.Parameters.Add(par);
            par.Value = textBox1.Text;

            p.Open();
            SqlDataReader bralec = u.ExecuteReader();
            while (bralec.Read())
            {
                label3.Text += bralec[0] + "\n";
            }
            bralec.Close();
            p.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label3.Text = "";
            string povezava = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\PRO2021\StudentNet\ŠtudentNet.mdf;Integrated Security=True;Connect Timeout=30";
            SqlConnection p = new SqlConnection(povezava);
            string ukaz = "select avg(ocena) from ocene where idštudenta=@student";
            SqlCommand u = new SqlCommand();
            u.Connection = p;
            u.CommandText = ukaz;
            u.CommandType = CommandType.Text;

            SqlParameter par = new SqlParameter("@student", SqlDbType.Int);
            u.Parameters.Add(par);
            par.Value = int.Parse(textBox2.Text);

            p.Open();
            object z = u.ExecuteScalar();
            label3.Text = "" + z;
            p.Close();
        }
    }
}
