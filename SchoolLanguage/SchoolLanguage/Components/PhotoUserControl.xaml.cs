﻿using System;
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
    /// Логика взаимодействия для PhotoUserControl.xaml
    /// </summary>
    public partial class PhotoUserControl : UserControl
    {
        ServicePhoto servicePhoto;
        public PhotoUserControl(ServicePhoto _servicePhoto)
        {
            InitializeComponent();
            servicePhoto = _servicePhoto;
            this.DataContext = servicePhoto;
        }

        private void MainBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void DeleteBtn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
