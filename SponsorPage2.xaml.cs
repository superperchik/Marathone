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

namespace Marathone
{
    /// <summary>
    /// Логика взаимодействия для SponsorPage2.xaml
    /// </summary>
    public partial class SponsorPage2 : Page
    {
        public SponsorPage2()
        {
            InitializeComponent();
        }
        int click = 0;
        int power = 10;

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            click = click + power;
            Summa.Content = "Внесено: " + click +" $";

        }
    }
}
