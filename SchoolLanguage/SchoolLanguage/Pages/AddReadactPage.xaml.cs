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
using Microsoft.Win32;
using SchoolLanguage.Components;
using System.IO;


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
            this.DataContext = service;

        }

        private void EditImage_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog()
            {
                Filter = "*.png|*.png|*.jpg|*.jng|*.jpeg|*.jpeg"
            };
            if(openFile.ShowDialog().GetValueOrDefault())
            {
                service.MainImage = File.ReadAllBytes
                    (openFile.FileName);
                KursImage.Source = new BitmapImage(new Uri(openFile.FileName));
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(service.ID == 0)
            {
                App.db.Service.Add(service);
            }
            App.db.SaveChanges();
        }
    }
}
