using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;
namespace BranjeDatoteke
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Podatki> vsiPodatki = new List<Podatki>();
        CollectionViewSource podatkiNewSorce;
        public MainWindow()
        {
            InitializeComponent();
            podatkiNewSorce = (CollectionViewSource)(FindResource("podatkiViewSorce"));
            StreamReader sr = new StreamReader(@"d:\PRO2021\vaja.csv");
            string vrstica = sr.ReadLine();
            vrstica = sr.ReadLine();
            while (vrstica != null)
            {
                string[] p = vrstica.Split(';');
                Podatki novi = new Podatki();
                novi.Id = int.Parse(p[0]);
                novi.Datum = DateTime.Parse(p[1]);
                novi.Ime = p[2];
                novi.Znesek = double.Parse(p[3]);
                vsiPodatki.Add(novi);
                vrstica = sr.ReadLine();
            }
            sr.Close();
            DataContext = this;
            podatkiNewSorce.Source = vsiPodatki;
        }
    }
}
