using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Društvo
{
    public partial class Pregled : Form
    {
        List<Darovi> spremembe = new List<Darovi>();
        string pot = Resource1.pot;
        int števecSprememb=0;
        public Pregled()
        {
            InitializeComponent();
        }

        private void Pregled_Load(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(pot, FileMode.Open);
                BinaryFormatter bf = new BinaryFormatter();
                Darovi d;
                try
                {
                    while (true)
                    {
                        d = (Darovi)bf.Deserialize(fs);
                        spremembe.Add(d);
                    }
                }catch (SerializationException) { }
                fs.Close();
                dgwPodatki.DataSource = spremembe;
            }catch (Exception) { }
        }

        private void Pregled_Shown(object sender, EventArgs e)
        {
            Updatevew();
        }

        public void Updatevew()
        {
            DataGridViewCellStyle dcs = new DataGridViewCellStyle();
            dcs.Format = "##0.00 €";
            dgwPodatki.Columns[3].DefaultCellStyle = dcs;
            dgwPodatki.Columns[4].Width = 175;
            foreach (DataGridViewRow r in dgwPodatki.Rows)
            {
                double tip = double.Parse(r.Cells[3].Value.ToString());
                if (tip < 0)
                {
                    r.DefaultCellStyle.BackColor = Color.LightPink;
                }
                else
                {
                    r.DefaultCellStyle.BackColor = Color.LightGray;
                }
            }
        }

        private void dgwPodatki_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int vrstica = e.RowIndex;
            int stolpec = e.ColumnIndex;
            Darovi d = new Darovi();
            d.ZapŠT = int.Parse(dgwPodatki.Rows[vrstica].Cells["ZapŠT"].Value.ToString());
            d.Datum = DateTime.Parse(dgwPodatki.Rows[vrstica].Cells["Datum"].Value.ToString());
            d.Namen = dgwPodatki.Rows[vrstica].Cells["Namen"].Value.ToString();
            d.Opombe = dgwPodatki.Rows[vrstica].Cells["Znesek"].Value.ToString();
            d.Znesek = decimal.Parse(dgwPodatki.Rows[vrstica].Cells["Opombe"].Value.ToString());
            spremembe[vrstica] = d;
            števecSprememb++;
            Updatevew();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(pot, FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();
            foreach(Darovi d in spremembe)
            {
                bf.Serialize(fs, d);
            }
            fs.Close();
            števecSprememb = 0;
        }

        private void Pregled_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (števecSprememb != 0)
            {
                DialogResult x = MessageBox.Show("Ostajajo neshranjene spremembe. \n shranim sedaj","Shranjevanje",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
                if (x == DialogResult.Yes)
                {
                    FileStream fs = new FileStream(pot, FileMode.Create);
                    BinaryFormatter bf = new BinaryFormatter();
                    foreach (Darovi d in spremembe)
                    {
                        bf.Serialize(fs, d);
                    }
                    fs.Close();
                    števecSprememb = 0;
                }
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            DialogResult x = MessageBox.Show("Hočeš zbrisat \n shranim sedaj", "Brisanje", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) ;
            if (x == DialogResult.Yes)
            {
                DataGridViewRow vrstica = dgwPodatki.CurrentRow;
                int index = vrstica.Index;
                spremembe.RemoveAt(index);
                dgwPodatki.Rows.RemoveAt(index);
                dgwPodatki.DataSource = null;
                dgwPodatki.Rows.Clear();
                dgwPodatki.DataSource = spremembe;
                Updatevew();
                števecSprememb++;
            }
        }
    }
}
