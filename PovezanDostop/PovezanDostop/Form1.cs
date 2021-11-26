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

namespace PovezanDostop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lstPodatki.Items.Clear();
            string povezava = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = D:\PRO2021\NorthPrava\northwnd.mdf; Integrated Security = True; Connect Timeout = 30";
            SqlConnection p = new SqlConnection(povezava);
            string ukaz = "select * from employees";
            SqlCommand u = new SqlCommand();
            u.Connection = p;
            u.CommandText = ukaz;
            u.CommandType = CommandType.Text;

            p.Open();
            SqlDataReader bralec = u.ExecuteReader();
            while (bralec.Read())
            {
                lstPodatki.Items.Add(bralec[0] +" "+ bralec[1]+" "+bralec["Country"]+" "+bralec["City"]);
            }
            bralec.Close();
            p.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lstPodatki.Items.Clear();
            string povezava = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = D:\PRO2021\NorthPrava\northwnd.mdf; Integrated Security = True; Connect Timeout = 30";
            SqlConnection p = new SqlConnection(povezava);
            string ukaz = "";
            ukaz = "select * from employees where country =@Country";

            SqlCommand u = new SqlCommand();
            u.Connection = p;
            u.CommandText = ukaz;
            u.CommandType = CommandType.Text;
            SqlParameter par = new SqlParameter("@Country", SqlDbType.NChar);
            u.Parameters.Add(par);
            par.Value = textBox1.Text;
            p.Open();
            SqlDataReader bralec = u.ExecuteReader();//vrne tabelo
            while (bralec.Read())
            {
                lstPodatki.Items.Add(bralec[0] + " " + bralec[1] + " " + bralec["Country"] + " " + bralec["City"]);
            }
            bralec.Close();
            p.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lstPodatki.Items.Clear();
            string povezava = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = D:\PRO2021\NorthPrava\northwnd.mdf; Integrated Security = True; Connect Timeout = 30";
            SqlConnection p = new SqlConnection(povezava);
            string ukaz = "";
            ukaz = "select count(*) from employees";
            SqlCommand u = new SqlCommand();
            u.Connection = p;
            u.CommandText = ukaz;
            u.CommandType = CommandType.Text;
            p.Open();
            int z = (int)u.ExecuteScalar();
            lstPodatki.Items.Add("Število zaposlenih je " + z);
            p.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            lstPodatki.Items.Clear();
            string povezava = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = D:\PRO2021\NorthPrava\northwnd.mdf; Integrated Security = True; Connect Timeout = 30";
            SqlConnection p = new SqlConnection(povezava);
            string ukaz = "update employees set country='NZ' where Country='USA'";
            SqlCommand u = new SqlCommand();
            u.Connection = p;
            u.CommandText = ukaz;
            u.CommandType = CommandType.Text;
            p.Open();
            int x = u.ExecuteNonQuery();
            lstPodatki.Items.Add("Posodobljeno " + x + " zapisov");
            p.Close();
        }
    }
}
