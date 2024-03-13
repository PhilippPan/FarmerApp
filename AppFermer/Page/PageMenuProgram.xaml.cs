using AppFermer.AppData;
using AppFermer.Window;
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
using System.Windows.Threading;

namespace AppFermer.Page
{
    /// <summary>
    /// Логика взаимодействия для PageMenuProgram.xaml
    /// </summary>
    public partial class PageMenuProgram
    {
        public PageMenuProgram()
        {
            InitializeComponent();

            CheckComboBox();

            CmbFiltr.SelectedValuePath = "Id";
            CmbFiltr.DisplayMemberPath = "Nazvanie";
            CmbFiltr.ItemsSource = AppConnect.modelOdb.VidProdukcii.ToList();

            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += UpdateDataGrid;
            timer.Start();
        }

        public void UpdateDataGrid(object sender, object e) {
            GridListProduct.ItemsSource = AppConnect.modelOdb.Produkcia.Where(x => x.Kolichestvo > 0).ToList();
            var ItogObj = AppConnect.modelOdb.Produkcia.Select(x => x.OtpysknayaCena * x.Kolichestvo).Sum();
            TxtCostBuyAll.Text = Convert.ToString(ItogObj);
        }

        public void CheckComboBox() {
            if (CmbFiltr.Text == "") {
                var ItogObj = AppConnect.modelOdb.Produkcia.Select(x => x.OtpysknayaCena * x.Kolichestvo).Sum();
                TxtCostBuyAll.Text = Convert.ToString(ItogObj);

                GridListProduct.ItemsSource = AppConnect.modelOdb.Produkcia.Where(x => x.Kolichestvo > 0).ToList();
            }
        }

        object ItogObj;

        private void CmbFiltr_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                TxtCostBuyAll.Text = null;
                GridListProduct.ItemsSource = null;

                TxtRub.Text = "руб.";
                int SelectedVidProduction = Convert.ToInt32(CmbFiltr.SelectedValue);
                GridListProduct.ItemsSource = AppConnect.modelOdb.Produkcia.Where(x => x.IdVidProdukcii == SelectedVidProduction && x.Kolichestvo > 0).ToList();
                
                ItogObj = AppConnect.modelOdb.Produkcia.Where(x => x.IdVidProdukcii == SelectedVidProduction)
                                                           .Select(x => x.OtpysknayaCena * x.Kolichestvo).Sum();
                
                TxtCostBuyAll.Text = Convert.ToString(ItogObj);
            }
            catch {
                TxtCostBuyAll.Text = "Данных нет!";
                TxtRub.Text = "";
                MessageBox.Show("Данных по данному виду продукции нет!", "Ошибка работы с данными", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void BtnClear_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Вы нажали очистка данных!", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
            CmbFiltr.SelectedIndex = -1;
            GridListProduct.ItemsSource = AppConnect.modelOdb.Produkcia.Where(x => x.Kolichestvo > 0).ToList();
            CheckComboBox();
        }

        private void BtnFermerInfo_Click(object sender, RoutedEventArgs e)
        {
            WindowFermerInfo windowFermerInfo = new WindowFermerInfo();
            windowFermerInfo.Show();
        }

        private void BtnAddProduction_Click(object sender, RoutedEventArgs e)
        {
            WindowAddProductFermer windowAddProductFermer = new WindowAddProductFermer();
            windowAddProductFermer.Show();
        }

        private void BtnDeleteProduct_Click(object sender, RoutedEventArgs e)
        {
            if (GridListProduct.SelectedItems.Count > 0) {
                for (int i=0; i < GridListProduct.SelectedItems.Count; i++) {
                    Produkcia produkciaObj = GridListProduct.SelectedItems[i] as Produkcia;
                    ProductInfoDelete.Id = produkciaObj.Id;
                    ProductInfoDelete.Name = produkciaObj.Nazvanie;
                    ProductInfoDelete.Count = produkciaObj.Kolichestvo;

                    WindowDeleteProduct windowDelete = new WindowDeleteProduct();
                    windowDelete.Show();
                }
            }
            else {
                MessageBox.Show("Данных нет!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void BtnTotalProduct_Click(object sender, RoutedEventArgs e)
        {
            WindowTotalProduct winTotal = new WindowTotalProduct();
            winTotal.Show();
        }

        private void BtnNessary_Click(object sender, RoutedEventArgs e)
        {
            WindowInfoNessary winNes = new WindowInfoNessary();
            winNes.Show();
        }

        private void BtnMoney_Click(object sender, RoutedEventArgs e)
        {
            WindowMoney winMoney = new WindowMoney();
            winMoney.Show();
        }
    }
}
