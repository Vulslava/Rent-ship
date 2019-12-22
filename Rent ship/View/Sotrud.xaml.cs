using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Rent_ship.Model;
using System.Windows.Controls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Rent_ship
{
    /// <summary>
    /// Логика взаимодействия для Sotrud.xaml
    /// </summary>
    public partial class Sotrud : Window
    {
        public Sotrud(Sotrudnik s)
        {
            InitializeComponent();
            DataContext = new ViewModel.ContSotr(this, s);
        }
    }
}
