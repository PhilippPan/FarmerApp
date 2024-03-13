using AppFermer.AppData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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
    /// Логика взаимодействия для WindowNessary.xaml
    /// </summary>
    public partial class WindowNessary
    {
        public WindowNessary()
        {
            InitializeComponent();
            CmbTypeNessary.SelectedValuePath = "Id";
            CmbTypeNessary.DisplayMemberPath = "Nazvanie";
            CmbTypeNessary.ItemsSource = AppConnect.modelOdb.Potrebnost.ToList();

            CmbNameFermer.SelectedValuePath = "Id";
            CmbNameFermer.DisplayMemberPath = "PersonalInfo";
            CmbNameFermer.ItemsSource = AppConnect.modelOdb.Fermer.ToList();

            TxtDateToday.Text = DateTime.Now.ToString();

            AppConnect.modelOdb = new wsr_user_17Entities();
        }

        private void BtnCreateNessary_Click(object sender, RoutedEventArgs e)
        {
            string SplitInfo = CmbNameFermer.Text;
            string[] FermerInfo = SplitInfo.Split(new char[] { ' ' });
            string Surname = FermerInfo[0];
            var FamiliaObj = AppConnect.modelOdb.Fermer.FirstOrDefault(x => x.Familia == Surname);
            int IdFermer = FamiliaObj.Id;

            string TotalPotrebnost = CmbTypeNessary.Text;
            var PotrebnostObj = AppConnect.modelOdb.Potrebnost.FirstOrDefault(x => x.Nazvanie == TotalPotrebnost);
            int IdPotrebnost = PotrebnostObj.Id;

            try {
                ZayavkiFermer zayavkiFermerObj = new ZayavkiFermer() {
                    IdStatus = 1,
                    IdFermer = IdFermer,
                    IdPotrebnost = IdPotrebnost,
                    DataZayavki = DateTime.Now,
                    Opisanie = TxbTextNessary.Text
                };
                AppConnect.modelOdb.ZayavkiFermer.Add(zayavkiFermerObj);
                AppConnect.modelOdb.SaveChanges();
                MessageBox.Show("Заявка успешно создана!", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch
            {
                MessageBox.Show("Возникла критическая ошибка по работе с добавлением данных.", "Критическая ошибка" ,MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void BtnPrintNessary_Click(object sender, RoutedEventArgs e)
        {
            BtnCreateNessary.Background = Brushes.Transparent;
            BtnCreateNessary.BorderBrush= Brushes.Transparent;
            BtnCreateNessary.Content = "";
            
            BtnPrintNessary.Background = Brushes.Transparent;
            BtnPrintNessary.BorderBrush = Brushes.Transparent;
            BtnPrintNessary.Content = "";

            PrintDialog printDialog = new PrintDialog();
            if (printDialog.ShowDialog() == true) {
                printDialog.PrintVisual(Canvas, "На печать");
            }
        }
    }
}
