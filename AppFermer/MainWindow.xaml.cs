using AppFermer.AppData;
using AppFermer.Page;
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

namespace AppFermer
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();

            AppConnect.modelOdb = new wsr_user_17Entities();

            FrmMain.Navigate(new PageMenuProgram());

            CmbQuality.SelectedValuePath = "Id";
            CmbQuality.DisplayMemberPath = "Nazvanie";
            CmbQuality.ItemsSource = AppConnect.modelOdb.Kachestvo.ToList();

            CmbEdinici.SelectedValuePath = "Id";
            CmbEdinici.DisplayMemberPath = "Nazvanie";
            CmbEdinici.ItemsSource = AppConnect.modelOdb.EdinicaIzmerenia.ToList();

            CmbVidProdukcii.SelectedValuePath = "Id";
            CmbVidProdukcii.DisplayMemberPath = "Nazvanie";
            CmbVidProdukcii.ItemsSource = AppConnect.modelOdb.VidProdukcii.ToList();
        }

        private void BtnCreate_Click(object sender, RoutedEventArgs e)
        {
            Fermer fermerObj = new Fermer() { 
                Familia = TxbSurname.Text,
                Imya = TxbName.Text,
                Otchestvo = TxbLastname.Text,
                Adres = TxbAddress.Text
            };

            AppConnect.modelOdb.Fermer.Add(fermerObj);
            AppConnect.modelOdb.SaveChanges();
            MessageBox.Show("Фермер успешно добавлен!", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void BtnAddProduct_Click(object sender, RoutedEventArgs e)
        {
            Produkcia produkciaObj = new Produkcia() {
                Nazvanie = TxbNameProduct.Text,
                Kolichestvo = Convert.ToInt32(TxbAmount.Text),
                Kachestvo = CmbQuality.SelectedItem as Kachestvo,
                OtpysknayaCena = Convert.ToDecimal(TxbCost.Text),
                VidProdukcii = CmbVidProdukcii.SelectedItem as VidProdukcii,
                EdinicaIzmerenia = CmbEdinici.SelectedItem as EdinicaIzmerenia
            };

            AppConnect.modelOdb.Produkcia.Add(produkciaObj);
            AppConnect.modelOdb.SaveChanges();
            TxbNameProduct.Text = "";
            TxbAmount.Text = "";
            TxbCost.Text = "";
            CmbQuality.SelectedIndex = -1;
            MessageBox.Show("Товар успешно добавлен!", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
