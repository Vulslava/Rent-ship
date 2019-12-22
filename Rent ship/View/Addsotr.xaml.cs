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
using Rent_ship.Model;
using System.Windows.Shapes;

namespace Rent_ship
{
    /// <summary>
    /// Логика взаимодействия для Addsotr.xaml
    /// </summary>
    public partial class Addsotr : Window
    {
        public Addsotr(Rent_Model db)
        {
            InitializeComponent();
            DataContext = new ViewModel.Addsotrud(this, db);
        }
        public Addsotr(Sotrudnik sotrudnik, Rent_Model db)
        {
            InitializeComponent();
            DataContext = new ViewModel.Changesotrud(this, sotrudnik, db);
        }
    }
}
