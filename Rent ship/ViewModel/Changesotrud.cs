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
    public class Changesotrud : Bases
    {
        Window w;
        Rent_Model a;
        Sotrudnik s;
        public ObservableCollection<Sotrudnik> sotrudnik { get; set; }
        public ObservableCollection<Tip_sotrudnika> TS { get; set; }
        public Changesotrud(Window win, Sotrudnik sotr, Rent_Model db)
        {
            a = db;
            w = win;
            s = sotr;
            TS = new ObservableCollection<Tip_sotrudnika>(a.Tip_sotrudnika);
            fio = s.FIO;
            pass = s.Pass;
            SelectedTip_sotrudnika = TS.Where(i => i.TID == sotr.TFK).FirstOrDefault();
        }
        private string fio;
        private string pass;
        public string FIO
        {
            get { return fio; }
            set { fio = value; OnPropertyChanged("FIO"); }
        }
        public string Pass
        {
            get { return pass; }
            set { pass = value; OnPropertyChanged("Pass"); }
        }
        Tip_sotrudnika selectedtip_sotrudnika;
        public Tip_sotrudnika SelectedTip_sotrudnika
        {
            get { return selectedtip_sotrudnika; }
            set { selectedtip_sotrudnika = value; OnPropertyChanged("SelectedTip_sotrudnika"); }
        }
        public RelayCommand AddSotrudnika
        {
            get
            {
                return new RelayCommand(obj =>
                {
                    Sotrudnik s = new Sotrudnik();
                    s.FIO = fio;
                    s.Pass = pass;
                    s.TFK = selectedtip_sotrudnika.TID;
                    a.SaveChanges();
                    w.Close();
                });
            }
        }
    }
}
