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

namespace Rent_ship.View
{
    /// <summary>
    /// Логика взаимодействия для AddClient.xaml
    /// </summary>
    public partial class AddClient : Window
    {
        public AddClient(Rent_Model db)
        {
            InitializeComponent();
            DataContext = new ViewModel.AddClient(this, db);
        }
        public AddClient(Client client, Rent_Model db)
        {
            InitializeComponent();
            DataContext = new ViewModel.ChangeClient(this, client, db);
        }
    }
}
