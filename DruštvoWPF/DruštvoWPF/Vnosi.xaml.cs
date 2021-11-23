using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace DruštvoWPF
{
    /// <summary>
    /// Interaction logic for Vnosi.xaml
    /// </summary>
    public partial class Vnosi : Window
    {
        string pot = Resource1.pot;
        public Vnosi()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Darovi d = new Darovi();


            d.ZapŠT = int.Parse(txtZapŠt.Text);

            d.Datum = txtDatum.SelectedDate.Value;
            d.Namen = txtName.Text;

            d.Znesek = decimal.Parse(txtZnesek.Text);

            d.Opombe = txtOpomba.Text;

            FileStream fs = new FileStream(pot, FileMode.Append);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, d);
            fs.Close();
            txtZapŠt.Clear();
            txtName.Clear();
            txtZnesek.Clear();
            txtOpomba.Clear();
        }

        private void TextBlock_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
