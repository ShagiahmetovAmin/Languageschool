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

namespace SchoolLanguage.Components
{
    /// <summary>
    /// Логика взаимодействия для ServiceUserControl.xaml
    /// </summary>
    public partial class ServiceUserControl : UserControl
    {
        public ServiceUserControl(Image image, string title,decimal cost, string costTime, string sale, Visibility costVisibility)
        {
            
            InitializeComponent();
            SerImg = image;
            CosTb.Text = cost.ToString("0");
            TitleTb.Text = title;
            CostTimeTb.Text = costTime;
            SaleTb.Text = sale;
            CosTb.Visibility = costVisibility;
            if(App.isAdmin == false)
            {
                RedactBtn.Visibility = Visibility.Hidden;
                DeleteBtn.Visibility = Visibility.Hidden;
            }
            //else
            //{
            //    RedactBtn.Visibility = Visibility.Visible;
            //    DeleteBtn.Visibility = Visibility.Visible;
            //}
        }
    }
}
