using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Windows;
using Rent_ship.Model;
using System.ComponentModel;
using System.Windows.Controls;

namespace Rent_ship.ViewModel
{
    class ContDogovor1 : Bases
    {
        Window w;
        Rent_Model a;
        Ship sh;
        Sotrudnik so;
        Model.Dogovor d;
        string name, fios;
        public ObservableCollection<Dogovor> dogovor { get; set; }
        public ObservableCollection<Ship> ship { get; set; }
        public ObservableCollection<Client> client { get; set; }
        public ObservableCollection<Sotrudnik> sotrudnik { get; set; }
        public ContDogovor1(Window win, Rent_Model db, Ship shi, Sotrudnik sot, Model.Dogovor dog)
        {
            a = db;
            w = win;
            sh = shi;
            so = sot;
            d = dog;
            client = new ObservableCollection<Client>(a.Client);
            ship = new ObservableCollection<Ship>(a.Ship);
            sotrudnik = new ObservableCollection<Sotrudnik>(a.Sotrudnik);
            foreach (Client i in db.Client)
                if (i.CID == d.CFK)
                    SelectedClient = i;
            foreach (Ship i in db.Ship)
                if (i.LID == d.LFK)
                    name = i.Name;
            foreach (Sotrudnik i in db.Sotrudnik)
                if (i.SID == d.SFK)
                    fios = i.FIO;
            date_of = d.Date_of;
            date_ok = d.Date_ok;
            date_sd = d.Date_sd;
        }
        private decimal sum;
        private DateTime date_of, date_sd, date_ok;
        public string FIOS
        {
            get { return fios; }
            set { fios = value; OnPropertyChanged("FIOS"); }
        }
        public string Name
        {
            get { return name; }
            set { name = value; OnPropertyChanged("Name"); }
        }
        public decimal Sum
        {
            get { return sum; }
            set { sum = value; OnPropertyChanged("Sum"); }
        }
        public DateTime Date_of
        {
            get { return date_of; }
            set
            {
                date_of = value; OnPropertyChanged("Date_of");
                if (date_sd <= date_ok)
                    Sum = (date_sd - date_of).Days * sh.Sum_day;
                else
                    Sum = ((date_ok - date_of).Days * sh.Sum_day) + (date_sd - date_ok).Days * sh.Sum_day * (decimal)3.4;
            }
        }
        public DateTime Date_sd
        {
            get { return date_sd; }
            set
            {
                date_sd = value; OnPropertyChanged("Date_sd");
                if (date_sd <= date_ok)
                    Sum = (date_sd - date_of).Days * sh.Sum_day;
                else
                    Sum = ((date_ok - date_of).Days * sh.Sum_day) + (date_sd - date_ok).Days * sh.Sum_day * (decimal)3.4;
            }
        }
        public DateTime Date_ok
        {
            get { return date_ok; }
            set
            {
                date_ok = value; OnPropertyChanged("Date_ok");
                if (date_sd <= date_ok)
                    Sum = (date_sd - date_of).Days * sh.Sum_day;
                else
                    Sum = ((date_ok - date_of).Days * sh.Sum_day) + (date_sd - date_ok).Days * sh.Sum_day * (decimal)3.4;
            }
        }
        Client selectedclient;
        public Client SelectedClient
        {
            get { return selectedclient; }
            set { selectedclient = value; OnPropertyChanged("SelectedClient"); }
        }
        public RelayCommand AddDogovor
        {
            get
            {
                return new RelayCommand(obj =>
                {
                    Model.Dogovor dogo = a.Dogovor.Find(d.DID);
                    dogo.Date_of = date_of;
                    dogo.Date_sd = date_sd;
                    dogo.Date_ok = date_ok;
                    dogo.Sum = sum;
                    dogo.CFK = selectedclient.CID;
                    dogo.SFK = d.SFK;
                    dogo.LFK = d.LFK;
                    a.SaveChanges();
                    w.Close();
                });
            }
        }
    }
}
