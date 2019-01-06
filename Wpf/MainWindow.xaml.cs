using BusinessLogicLayer.NTierBLL;
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

namespace Wpf
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        FacultyBLL _facBll = new FacultyBLL();
        public MainWindow()
        {
            InitializeComponent();
            GridInit();
        }
        private void GridInit(int? id = null, string searchText = null)
        {
            var temp = _facBll.Get(id = 1, searchText);
            DataGrid1.ItemsSource = temp;
        }
    }
}
