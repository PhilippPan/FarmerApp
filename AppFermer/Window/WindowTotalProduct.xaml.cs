using AppFermer.AppData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
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
using System.Windows.Threading;

namespace AppFermer.Window
{
    /// <summary>
    /// Логика взаимодействия для WindowTotalProduct.xaml
    /// </summary>
    public partial class WindowTotalProduct
    {
        public WindowTotalProduct()
        {
            InitializeComponent();

            AppConnect.modelOdb = new wsr_user_17Entities();

            CmbVidProdukcii.SelectedValuePath = "Id";
            CmbVidProdukcii.DisplayMemberPath = "Nazvanie";
            CmbVidProdukcii.ItemsSource = AppConnect.modelOdb.VidProdukcii.ToList();

            GridProizvodstvo.ItemsSource = AppConnect.modelOdb.Proizvodstvo.ToList();

            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(25);
            timer.Tick += UpdateData;
            timer.Start();
        }

        public void UpdateData(object sender, object e) {
            GridProdukcia.ItemsSource = AppConnect.modelOdb.Produkcia.ToList();
            GridProizvodstvo.ItemsSource = AppConnect.modelOdb.Proizvodstvo.ToList();
        }

        private void CmbVidProdukcii_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int SelectedVidProduct = Convert.ToInt32(CmbVidProdukcii.SelectedValue);
            GridProizvodstvo.ItemsSource = AppConnect.modelOdb.Proizvodstvo.Where(x => x.Produkcia.IdVidProdukcii == SelectedVidProduct).ToList();
        }

        private void BtnClear_Click(object sender, RoutedEventArgs e)
        {
            GridProizvodstvo.ItemsSource = AppConnect.modelOdb.Proizvodstvo.ToList();
        }
    }
}
