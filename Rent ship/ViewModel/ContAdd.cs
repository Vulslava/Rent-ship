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
    public class ContAdd : Bases
    {
        Window w;
        Rent_Model a;
        public ObservableCollection<Ship> ship { get; set; }
        public ObservableCollection<Tip_ship> TS { get; set; }
        public ContAdd(Window win)
        {
            a = new Rent_Model();
            w = win;
            TS = new ObservableCollection<Tip_ship>(a.Tip_ship);
        }
        private string name = null;
        private string manufacture = null;
        private int power_dv = 0;
        private float dlina = 0;
        private float shirina = 0;
        private float osadka = 0;
        private float visota_bort = 0;
        private int speed_max = 0;
        private float vodoizmesch = 0;
        private float rashod_topl = 0;
        private string sostoyanie = null;
        private decimal sum_day = 0;
        public string Name
        {
            get { return name; }
            set { name = value; OnPropertyChanged("Name"); }
        }
        public string Manufacture
        {
            get { return manufacture; }
            set { manufacture = value; OnPropertyChanged("Manufacture"); }
        }
        public int Power_dv
        {
            get { return power_dv; }
            set { power_dv = value; OnPropertyChanged("Power_dv"); }
        }
        public float Dlina
        {
            get { return dlina; }
            set { dlina = value; OnPropertyChanged("Dlina"); }
        }
        public float Shirina
        {
            get { return shirina; }
            set { shirina = value; OnPropertyChanged("Shirina"); }
        }
        public float Osadka
        {
            get { return osadka; }
            set { osadka = value; OnPropertyChanged("Osadka"); }
        }
        public float Visota_bort
        {
            get { return visota_bort; }
            set { visota_bort = value; OnPropertyChanged("Visota_bort"); }
        }
        public int Speed_max
        {
            get { return speed_max; }
            set { speed_max = value; OnPropertyChanged("Speed_max"); }
        }
        public float Vodoizmesch
        {
            get { return vodoizmesch; }
            set { vodoizmesch = value; OnPropertyChanged("Vodoizmesch"); }
        }
        public float Rashod_topl
        {
            get { return rashod_topl; }
            set { rashod_topl = value; OnPropertyChanged("Rashod_topl"); }
        }
        public string Sostoyanie
        {
            get { return sostoyanie; }
            set { sostoyanie = value; OnPropertyChanged("Sostoyanie"); }
        }
        public decimal Sum_day
        {
            get { return sum_day; }
            set { sum_day = value; OnPropertyChanged("Sum_day"); }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
        Tip_ship selectedtip_ship;
        public Tip_ship SelectedTip_ship
        {
            get { return selectedtip_ship; }
            set { selectedtip_ship = value; OnPropertyChanged("SelectedTip_ship"); }
        }
        public RelayCommand AddShip
        {
            get
            {
                return new RelayCommand(obj =>
                {
                    Ship sh = new Ship();
                    sh.Name = name;
                    sh.Manufacture = manufacture;
                    sh.Power_dv = power_dv;
                    sh.Dlina = dlina;
                    sh.Shirina = shirina;
                    sh.Osadka = osadka;
                    sh.Visota_bort = visota_bort;
                    sh.Speed_max = speed_max;
                    sh.Vodoizmesch = vodoizmesch;
                    sh.Rashod_topl = rashod_topl;
                    sh.Sostoyanie = sostoyanie;
                    sh.Sum_day = sum_day;
                    sh.LTFK = selectedtip_ship.LTID;
                    sh.LID = 1;
                    a.Ship.Add(sh);
                    a.SaveChanges();
                    w.Close();
                });
            }
        }

    }
}
