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
    class ContChange : Bases
    {
        Window w;
        Rent_Model a;
        Ship s;
        string name, manufacture, sostoyanie;
        int power_dv, speed_max;
        float dlina, shirina, osadka, visota_bort, vodoizmesch, rashod_topl;
        decimal sum_day;
        public ObservableCollection<Ship> ship { get; set; }
        public ObservableCollection<Tip_ship> TS { get; set; }
        public ContChange(Window win, Ship ss, Rent_Model db)
        {
            a = db;
            w = win;
            s = ss;
            TS = new ObservableCollection<Tip_ship>(a.Tip_ship);
            name = s.Name;
            manufacture = s.Manufacture;
            power_dv = s.Power_dv;
            dlina = s.Dlina;
            shirina = s.Shirina;
            osadka = s.Osadka;
            visota_bort = s.Visota_bort;
            speed_max = s.Speed_max;
            vodoizmesch = s.Vodoizmesch;
            rashod_topl = s.Rashod_topl;
            sostoyanie = s.Sostoyanie;
            sum_day = s.Sum_day;
            SelectedTip_ship = TS.Where(i => i.LTID == ss.LTFK).FirstOrDefault();
        }
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
                    Ship sh = a.Ship.Find(s.LID);
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
                    a.SaveChanges();
                    w.Close();
                });
            }
        }
    }
}
