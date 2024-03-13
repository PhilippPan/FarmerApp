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
    /// Логика взаимодействия для WindowFermerInfo.xaml
    /// </summary>
    public partial class WindowFermerInfo
    {
        public WindowFermerInfo()
        {
            InitializeComponent();

            AppConnect.modelOdb = new wsr_user_17Entities();
            GridFermerList.ItemsSource = AppConnect.modelOdb.Fermer.ToList();
        }
    }
}
