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

namespace WindowsOMB.views
{
    /// <summary>
    /// Interaction logic for LoginCredenciales.xaml
    /// </summary>
    public partial class LoginCredenciales : UserControl
    {
        public LoginCredenciales()
        {
            InitializeComponent();
        }

        private void loginLoaded(object sender, RoutedEventArgs e)
        {
            txtUsuario.Focus();
        }
    }
}
