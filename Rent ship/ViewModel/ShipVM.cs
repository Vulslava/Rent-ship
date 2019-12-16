using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rent_ship.Model;

namespace Rent_ship.ViewModel
{
    public class ShipVM : Bases
    {
        private Ship ship;
        private Dogovor dogovor;
        public ShipVM(Ship s)
        {
            ship = s;
        }
        public int LID
        {
            get { return ship.LID; }
            set { ship.LID = value; OnPropertyChanged("LID"); }
        }
        public string Name
        {
            get { return ship.Name; }
        }
        public string Manufacture
        {
            get { return ship.Manufacture; }
        }
        public int Power_dv
        {
            get { return ship.Power_dv; }
        }
        public float Dlina
        {
            get { return ship.Dlina; }
        }
        public float Shirina
        {
            get { return ship.Shirina; }
        }
        public float Osadka
        {
            get { return ship.Osadka; }
        }
        public float Visota_bort
        {
            get { return ship.Visota_bort; }
        }
        public int Speed_max
        {
            get { return ship.Speed_max; }
        }
        public float Vodoizmesch
        {
            get { return ship.Vodoizmesch; }
        }
        public float Rashod_topl
        {
            get { return ship.Rashod_topl; }
        }
        public string Sostoyanie
        {
            get { return ship.Sostoyanie; }
        }
        public decimal Sum_day
        {
            get { return ship.Sum_day; }
        }
        public string Tip_ship
        {
            get { return String.Join("", ship.Tip_ship); }
        }
    }
}
