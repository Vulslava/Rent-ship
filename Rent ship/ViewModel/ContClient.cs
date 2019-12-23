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
    public class ContClient : Bases
    {
        Window w;
        Rent_Model db;
        public ObservableCollection<Client> Clients { get; set; }
        public ContClient(Window win, Rent_Model a)
        {
            db = a;
            w = win;
            Clients = new ObservableCollection<Client>(db.Client);
        }
        public RelayCommand AddCommand
        {
            get
            {
                return new RelayCommand(obj =>
                {
                    a = new View.AddClient(db);
                    a.ShowDialog();
                    Clients.Clear();
                    foreach (Client i in db.Client)
                        Clients.Add(i);
                });
            }
        }
        public RelayCommand ChangeCommand
        {
            get
            {
                return new RelayCommand(obj =>
                {
                    if (SelectedClient != null)
                    {
                        a = new View.AddClient(SelectedClient, db);
                        a.ShowDialog();
                        Clients.Clear();
                        foreach (Client i in db.Client)
                            Clients.Add(i);
                    }
                });
            }
        }
        Client selectedclient;
        public Client SelectedClient
        {
            get { return selectedclient; }
            set
            {
                selectedclient = value;
                OnPropertyChanged("SelectedClient");
            }
        }
        public View.AddClient a
        {
            get; private set;
        }
    }
}
