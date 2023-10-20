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
using SchoolLanguage.Components;


namespace SchoolLanguage.Pages
{
    /// <summary>
    /// Логика взаимодействия для AddReadactPage.xaml
    /// </summary>
    public partial class AddReadactPage : Page
    {
        private Service service;
        public AddReadactPage(Service _service)
        {
            InitializeComponent();
            service = _service;

        }

        private void EditImage_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
