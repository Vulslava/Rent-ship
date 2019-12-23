using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;
using Rent_ship.Model;
using Rent_ship.View;
using System.ComponentModel;

namespace Rent_ship.ViewModel
{
    class ContAdm : Bases
    {
        Window w;
        Rent_Model db;
        public ObservableCollection<Sotrudnik> Sotrudniks { get; set; }
        public ContAdm(Window win)
        {
            db = new Rent_Model();
            w = win;
            Sotrudniks = new ObservableCollection<Sotrudnik>(db.Sotrudnik);
        }
        public RelayCommand AddCommand
        {
            get
            {
                return new RelayCommand(obj =>
                {
                    a = new Addsotr(db);
                    a.ShowDialog();
                    Sotrudniks.Clear();
                    foreach (Sotrudnik i in db.Sotrudnik)
                        Sotrudniks.Add(i);
                });
            }
        }
        public RelayCommand ChangeCommand
        {
            get
            {
                return new RelayCommand(obj =>
                {
                    if (SelectedSotrudnik != null)
                    {
                        a = new Addsotr(SelectedSotrudnik, db);
                        a.ShowDialog();
                        Sotrudniks.Clear();
                        foreach (Sotrudnik i in db.Sotrudnik)
                            Sotrudniks.Add(i);
                    }
                });
            }
        }
        Sotrudnik selectedsotrudnik;
        public Sotrudnik SelectedSotrudnik
        {
            get { return selectedsotrudnik; }
            set
            {
                selectedsotrudnik = value;
                OnPropertyChanged("SelectedSotrudnik");
            }
        }
        public RelayCommand RemoveCommand
        {
            get
            {
                return new RelayCommand(obj =>
                {
                    if (SelectedSotrudnik != null)
                    {
                        db.Sotrudnik.Remove(selectedsotrudnik);
                        db.SaveChanges();
                        Sotrudniks.Clear();
                        foreach (Sotrudnik i in db.Sotrudnik)
                            Sotrudniks.Add(i);
                    }
                });
            }
        }
        public RelayCommand OtchetCommand
        {
            get
            {
                return new RelayCommand(obj =>
                {
                    o = new Otchet(db);
                    o.ShowDialog();
                });
            }
        }
        public Otchet o
        {
            get; private set;
        }
        public Addsotr a
        {
            get; private set;
        }
    }
}
