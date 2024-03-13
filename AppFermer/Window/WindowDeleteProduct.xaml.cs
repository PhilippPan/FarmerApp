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
    /// Логика взаимодействия для WindowDeleteProduct.xaml
    /// </summary>
    public partial class WindowDeleteProduct
    {
        public WindowDeleteProduct()
        {
            InitializeComponent();
            TxtCount.Text = "(" + Convert.ToString(ProductInfoDelete.Count) + ")";
            TxtNameProduct.Text = ProductInfoDelete.Name;
        }

        private void BtnAccept_Click(object sender, RoutedEventArgs e)
        {
            var TotalObj = AppConnect.modelOdb.Produkcia.Where(x => x.Id == ProductInfoDelete.Id).FirstOrDefault();
            TotalObj.Kolichestvo -= Convert.ToInt32(TxbTotalProduct.Text);
            AppConnect.modelOdb.SaveChanges();
            MessageBox.Show("Количество продукта успешно изменено!", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            var TotalObj = AppConnect.modelOdb.Produkcia.Where(x => x.Id == ProductInfoDelete.Id).FirstOrDefault();
            TotalObj.Kolichestvo -= Convert.ToInt32(ProductInfoDelete.Count);
            AppConnect.modelOdb.SaveChanges();
            MessageBox.Show("Данные о товаре успешно очищены!", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
