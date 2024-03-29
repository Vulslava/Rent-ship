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
using System.Windows.Shapes;
using Rent_ship.Model;

namespace Rent_ship
{
    /// <summary>
    /// Логика взаимодействия для Dogovor.xaml
    /// </summary>
    public partial class Dogovor : Window
    {
        public Dogovor(Ship shi, Sotrudnik sot, Rent_Model db)
        {
            InitializeComponent();
            DataContext = new ViewModel.ContDogovor(this, db, shi, sot);
        }
        public Dogovor(Ship shi, Sotrudnik sot, Rent_Model db, Model.Dogovor d)
        {
            InitializeComponent();
            DataContext = new ViewModel.ContDogovor1(this, db, shi, sot, d);
        }
    }
}
