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
using System.IO;

namespace SchoolLanguage
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var path = @"C:\Users\222117\Desktop\";
            foreach(var i in App.db.Service.ToArray())
            {
                var fullPath = path + i.MainImagePath.Trim();
                var imageByte = File.ReadAllBytes(fullPath);
                i.MainImage = imageByte;
            }
            App.db.SaveChanges();
        }
    }
}
