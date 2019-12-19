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
using System.Windows.Shapes;
using Rent_ship.Model;

namespace Rent_ship
{
    /// <summary>
    /// Логика взаимодействия для Addship.xaml
    /// </summary>
    public partial class Addship : Window
    {
        public Addship(Rent_Model db)
        {
            InitializeComponent();
            DataContext = new ViewModel.ContAdd(this, db);
        }
        public Addship(Ship ship, Rent_Model db)
        {
            InitializeComponent();
            DataContext = new ViewModel.ContChange(this, ship, db);
        }
    }
}
