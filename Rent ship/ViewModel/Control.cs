﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rent_ship.Model;
using System.Configuration;
using System.Data;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Controls;
using System.Windows;
using System.Data.SqlClient;

namespace Rent_ship.ViewModel
{
    public class Control : INotifyPropertyChanged, IRequireViewIdentification
    {
        private string pass, login;
        public Control()
        {
            //_viewID = Guid.NewGuid();
            //logincommand = new RelayCommand(logincom, i => true);
        }
        //public RelayCommand MW { get { return logincommand; } }
        public string FIO
        {
            get { return login; }
            set { login = value; NotifyPropertyChanged("FIO"); }
        }
        public string Pass
        {
            get { return pass; }
            set { pass = value; NotifyPropertyChanged("Pass"); }
        }
        private void logincom(object q)
        {
            PasswordBox passwordBox = q as PasswordBox;
            string clearTextPassword = passwordBox.Password;
            /*try
            {
                if (FIO == "1" && clearTextPassword == "1") throw new UnauthorizedAccessException();
                NotifyPropertyChanged("AuthenticatedUser");
                NotifyPropertyChanged("IsAuthenticated");
                _IsAuthenticated = true;
                Close();
            }*/
        }

        private bool CanLogin(object parameter)
        {
            return !IsAuthenticated;
        }

        private bool _IsAuthenticated = false;
        public bool IsAuthenticated
        {
            get { return _IsAuthenticated; }
        }
        private Guid _viewId;
        public Guid ViewID
        {
            get { return _viewId; }
        }

        private void Logout(object parameter)
        {
            NotifyPropertyChanged("AuthenticatedUser");
            NotifyPropertyChanged("IsAuthenticated");
            //_loginCommand.RaiseCanExecuteChanged();
            //_logoutCommand.RaiseCanExecuteChanged();
        }


        #region INotifyPropertyChanged Members
        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
    /*Window w;
    Rent_Model a;
    public ObservableCollection<Sotrudnik> sotr { get; set; }
    public Control(Window win)
    {
        w = win;
        a = new Rent_Model();
        sotr = new ObservableCollection<Sotrudnik>(a.Sotrudnik);
    }
    public RelayCommand MW
    {
        get { return new RelayCommand(obj => 
                {
                if ()
                    {
                        Sotrudnik s = new Sotrudnik();
                        w.Hide();
                        Sotrud = new Sotrud();
                        Sotrud.ShowDialog();
                        w.Close();
                    }
                });
            }
    }
    public Sotrud Sotrud
    {
        get; private set;
    }*/
}

