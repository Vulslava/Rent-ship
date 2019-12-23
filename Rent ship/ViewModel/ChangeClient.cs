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
    class ChangeClient : Bases
    {
        Window w;
        Rent_Model a;
        Client c;
        string fio, adres;
        int tel, serp, nump;
        public ObservableCollection<Client> client { get; set; }
        public ChangeClient(Window win, Client cl, Rent_Model db)
        {
            a = db;
            w = win;
            c = cl;
            fio = c.FIO;
            adres = c.Adres;
            tel = (int)c.Tel;
            serp = c.Serp;
            nump = c.Nump;
        }
        public string FIO
        {
            get { return fio; }
            set { fio = value; OnPropertyChanged("FIO"); }
        }
        public string Adres
        {
            get { return adres; }
            set { adres = value; OnPropertyChanged("Adres"); }
        }
        public int Tel
        {
            get { return tel; }
            set { tel = value; OnPropertyChanged("Tel"); }
        }
        public int Serp
        {
            get { return serp; }
            set { serp = value; OnPropertyChanged("Serp"); }
        }
        public int Nump
        {
            get { return nump; }
            set { nump = value; OnPropertyChanged("Nump"); }
        }
        public RelayCommand AddClient
        {
            get
            {
                return new RelayCommand(obj =>
                {
                    Client cl = a.Client.Find(c.CID);
                    cl.FIO = fio;
                    cl.Adres = adres;
                    cl.Tel = tel;
                    cl.Serp = serp;
                    cl.Nump = nump;
                    a.SaveChanges();
                    w.Close();
                });
            }
        }
    }
}
