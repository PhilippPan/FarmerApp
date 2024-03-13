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
    /// Логика взаимодействия для WindowMoney.xaml
    /// </summary>
    public partial class WindowMoney
    {
        public WindowMoney()
        {
            InitializeComponent();

            AppConnect.modelOdb = new wsr_user_17Entities();

            CmbFermer.SelectedValuePath = "Id";
            CmbFermer.DisplayMemberPath = "Info";
            CmbFermer.ItemsSource = AppConnect.modelOdb.Fermer.ToList();

            CmbProductFermer.SelectedValuePath = "Id";
            CmbProductFermer.DisplayMemberPath = "Nazvanie";
        }

        private void CmbFermer_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int SelectFermer = Convert.ToInt32(CmbFermer.SelectedValue);
            CmbProductFermer.ItemsSource = AppConnect.modelOdb.Proizvodstvo.Where(x => x.IdProdukcia == SelectFermer).ToList();
        }
    }
}
