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
using Rent_ship.View;

namespace Rent_ship.ViewModel
{
    public class ContSotr : Bases
    {
        Window w;
        Rent_Model db;
        Sotrudnik s;
        public ObservableCollection<Ship> Ships { get; set; }
        public ContSotr(Window win, Sotrudnik sotr)
        {
            db = new Rent_Model();
            w = win;
            s = sotr;
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
        public RelayCommand RemoveCommand
        {
            get
            {
                return new RelayCommand(obj =>
                {
                    if (SelectedShip != null)
                    {
                        selectedship.Sostoyanie = "Списан";
                        //db.Ship.Remove(selectedship);
                        db.SaveChanges();
                        Ships.Clear();
                        foreach (Ship i in db.Ship)
                            Ships.Add(i);
                    }
                });
            }
        }
        public RelayCommand ClientCommand
        {
            get
            {
                return new RelayCommand(obj =>
                {
                    c = new Clients(db);
                    c.ShowDialog();
                });
            }
        }
        public RelayCommand DogovorCommand
        {
            get
            {
                return new RelayCommand(obj =>
                {
                    if (SelectedShip != null && selectedship.Sostoyanie != "Списан" && selectedship.Sostoyanie != "Арендован")
                    {
                        d = new Dogovor(selectedship, s, db);
                        d.ShowDialog();
                        selectedship.Sostoyanie = "Арендован";
                        Ships.Clear();
                        foreach (Ship i in db.Ship)
                            Ships.Add(i);
                    }
                    if (SelectedShip != null && selectedship.Sostoyanie == "Арендован")
                    {
                        foreach (Model.Dogovor i in db.Dogovor)
                            if (i.LFK == selectedship.LID)
                                d = new Dogovor(selectedship, s, db, i);
                        d.ShowDialog();
                        selectedship.Sostoyanie = "Свободно";
                        Ships.Clear();
                        foreach (Ship i in db.Ship)
                            Ships.Add(i);
                    }
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
        public Clients c
        {
            get; private set;
        }
    }
}
