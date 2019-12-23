using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;
using Rent_ship.Model;
using System.ComponentModel;

namespace Rent_ship.ViewModel
{
    class ContOtchet : Bases
    {
        Window w;
        Rent_Model db;
        public ObservableCollection<Model.Dogovor> Dogovor { get; set; }
        public ObservableCollection<Ship> ship { get; set; }
        public ContOtchet(Window win, Rent_Model g)
        {
            db = g;
            w = win;
            Dogovor = new ObservableCollection<Model.Dogovor>(db.Dogovor);
            ship = new ObservableCollection<Ship>(db.Ship);
        }
        string selectedship;
        public string SelectedShip
        {
            get { return selectedship; }
            set { selectedship = value; OnPropertyChanged("SelectedShip"); }
        }
        public RelayCommand Search
        {
            get
            {
                return new RelayCommand(obj =>
                {
                    Model.Dogovor d = new Model.Dogovor();
                    Dogovor.Clear();
                    foreach (Model.Dogovor i in db.Dogovor)
                        if (i.Ship.Name == selectedship)
                            Dogovor.Add(i);
                });
            }
        }
    }
}
