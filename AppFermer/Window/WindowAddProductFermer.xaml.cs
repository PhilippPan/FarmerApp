using AppFermer.AppData;
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
using System.Windows.Shapes;

namespace AppFermer.Window
{
    /// <summary>
    /// Логика взаимодействия для WindowAddProductFermer.xaml
    /// </summary>
    public partial class WindowAddProductFermer
    {
        public WindowAddProductFermer()
        {
            InitializeComponent();
            AppConnect.modelOdb = new wsr_user_17Entities();
            CmbFermer.SelectedValuePath = "Id";
            CmbFermer.DisplayMemberPath = "Familia";
            CmbFermer.ItemsSource = AppConnect.modelOdb.Fermer.ToList();

            CmbProduct.SelectedValuePath = "Id";
            CmbProduct.DisplayMemberPath = "Nazvanie";
            CmbProduct.ItemsSource = AppConnect.modelOdb.Produkcia.ToList();

            TxtDateTime.Text = DateTime.Now.ToString();
        }

        private void BtnOk_Click(object sender, RoutedEventArgs e)
        {
            Proizvodstvo proizvodstvoObj = new Proizvodstvo() {
                Fermer = CmbFermer.SelectedItem as Fermer,
                Produkcia = CmbProduct.SelectedItem as Produkcia,
                DataPoseshenia = Convert.ToDateTime(TxtDateTime.Text),
                Commentarii = TxtComment.Text
            };
            AppConnect.modelOdb.Proizvodstvo.Add(proizvodstvoObj);
            AppConnect.modelOdb.SaveChanges();
            MessageBox.Show("Данные успешно внесены!", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
