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
    class ContDogovor : Bases
    {
        Window w;
        Rent_Model a;
        Ship sh;
        Sotrudnik so;
        string name, fios;
        decimal sum;
        public ObservableCollection<Dogovor> dogovor { get; set; }
        public ObservableCollection<Ship> ship { get; set; }
        public ObservableCollection<Client> client { get; set; }
        public ObservableCollection<Sotrudnik> sotrudnik { get; set; }
        public ContDogovor(Window win, Rent_Model db, Ship shi, Sotrudnik sot)
        {
            a = db;
            w = win;
            sh = shi;
            so = sot;
            client = new ObservableCollection<Client>(a.Client);
            ship = new ObservableCollection<Ship>(a.Ship);
            sotrudnik = new ObservableCollection<Sotrudnik>(a.Sotrudnik);
            SelectedClient = client.Where(i => i.CID == 1).LastOrDefault();
            name = sh.Name;
            fios = so.FIO;
        }
        private string fio;
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
        public string FIO
        {
            get { return fio; }
            set { fio = value; OnPropertyChanged("FIO"); }
        }
        public decimal Sum
        {
            get { return sum; }
            set { sum = value; OnPropertyChanged("Sum"); }
        }
        public DateTime Date_of
        {
            get { return date_of; }
            set { date_of = value; OnPropertyChanged("Date_of");
                if (date_sd <= date_ok)
                    Sum = (date_sd - date_of).Days * sh.Sum_day;
                else
                    Sum = ((date_ok - date_of).Days * sh.Sum_day) + (date_sd - date_ok).Days * sh.Sum_day * (decimal)3.4;
            }
        }
        /*public DateTime Date_sd
        {
            get { return date_sd; }
            set { date_sd = value;
                OnPropertyChanged("Date_sd");
                if (date_sd <= date_ok)
                    Sum = (date_sd - date_of).Days * sh.Sum_day;
                else
                    Sum = ((date_ok - date_of).Days * sh.Sum_day) + (date_sd - date_ok).Days * sh.Sum_day * (decimal)3.4;
            }
        }*/
        public DateTime Date_ok
        {
            get { return date_ok; }
            set { date_ok = value; OnPropertyChanged("Date_ok");
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
                    Model.Dogovor d = new Model.Dogovor();
                    d.Date_of = date_of;
                    d.Date_sd = date_of;
                    d.Date_ok = date_ok;
                    d.Sum = 0;
                    d.CFK = selectedclient.CID;
                    d.SFK = so.SID;
                    d.LFK = sh.LID;
                    d.DID = 1;
                    a.Dogovor.Add(d);
                    a.SaveChanges();
                    w.Close();
                });
            }
        }
    }
}
