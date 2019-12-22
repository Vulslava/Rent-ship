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
    public class AddClient : Bases
    {
        Window w;
        Rent_Model a;
        public ObservableCollection<Client> client { get; set; }
        public AddClient(Window win, Rent_Model db)
        {
            a = db;
            w = win;
        }
        private string fio = null;
        private string adres = null;
        private int tel = 0;
        private int serp = 0;
        private int nump = 0;
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
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
        public RelayCommand AddShip
        {
            get
            {
                return new RelayCommand(obj =>
                {
                    Client cl = new Client();
                    cl.FIO = fio;
                    cl.Adres = adres;
                    cl.Tel = tel;
                    cl.Serp = serp;
                    cl.Nump = nump;
                    cl.CID = 1;
                    a.Client.Add(cl);
                    a.SaveChanges();
                    w.Close();
                });
            }
        }
    }
}
