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
    public class ContSotr : Bases
    {
        Window w;
        Rent_Model db;
        public ObservableCollection<Ship> Ships { get; set; }
        public ContSotr(Window win)
        {
            db = new Rent_Model();
            w = win;
            Ships = new ObservableCollection<Ship>(db.Ship);
        }
        public RelayCommand AddCommand
        {
            get
            {
                return new RelayCommand(obj =>
                {
                    a = new Addship(db);
                    a.ShowDialog();
                    Ships.Clear();
                    foreach (Ship i in db.Ship)
                        Ships.Add(i);
                });
            }
        }
        public RelayCommand ChangeCommand
        {
            get
            {
                return new RelayCommand(obj =>
                {
                    if (SelectedShip != null)
                    {
                        a = new Addship(SelectedShip, db);
                        a.ShowDialog();
                        Ships.Clear();
                        foreach(Ship i in db.Ship )
                            Ships.Add(i);
                    }
                });
            }
        }
        private List<IObserver> obs;
        private int ID;
        public void NotifyObservers()
        {
            foreach (IObserver o in obs)
            {
                o.Update(ID);
            }
        }
        Ship selectedship;
        public Ship SelectedShip
        {
            get { return selectedship; }
            set
            {
                selectedship = value;
                OnPropertyChanged("SelectedShip");
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }

        public RelayCommand RemoveCommand
        {
            get
            {
                return new RelayCommand(obj =>
                {
                    if (SelectedShip != null)
                    {
                        db.Ship.Remove(selectedship);
                        db.SaveChanges();
                        Ships.Clear();
                        foreach (Ship i in db.Ship)
                            Ships.Add(i);
                    }
                });
            }
        }
        public RelayCommand DogovorCommand
        {
            get
            {
                return new RelayCommand(obj =>
                {
                    d = new Dogovor();
                    d.ShowDialog();
                });
            }
        }
        public Addship a
        {
            get; private set;
        }
        public Dogovor d
        {
            get; private set;
        }
    }
}
