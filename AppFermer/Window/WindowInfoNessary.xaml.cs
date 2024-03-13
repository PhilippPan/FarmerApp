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
    /// Логика взаимодействия для WindowInfoNessary.xaml
    /// </summary>
    public partial class WindowInfoNessary 
    {
        public WindowInfoNessary()
        {
            InitializeComponent();
            GridListNessary.ItemsSource = AppConnect.modelOdb.ZayavkiFermer.ToList();
        }

        private void MICreateNessery_Click(object sender, RoutedEventArgs e)
        {
            WindowNessary winNes = new WindowNessary();
            winNes.Show();
        }
    }
}
