using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using SchoolLanguage.Components;

namespace SchoolLanguage
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static LanguageSchoollllEntities db = new LanguageSchoollllEntities();
    }
}
