using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using SchoolLanguage.Components;
using SchoolLanguage.Pages;

namespace SchoolLanguage
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static LanguageSchoollllEntities db = new LanguageSchoollllEntities();
        public static bool isAdmin = false;

        public static MainWindow mainWindow;
        public static AddReadactPage servicePage;
    }
}
