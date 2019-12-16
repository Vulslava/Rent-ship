using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rent_ship.Model
{
    public class ShipModel
    {
        public int LID { get; set; }
        public string Name { get; set; }
        public string Manufacture { get; set; }
        public int Power_dv { get; set; }
        public double Dlina { get; set; }
        public double Shirina { get; set; }
        public double Osadka { get; set; }
        public double Visota_bort { get; set; }
        public int Speed_max { get; set; }
        public double Vodoizmesch { get; set; }
        public double Rashod_topl { get; set; }
        public string Sostoyanie { get; set; }
        public double Sum_day { get; set; }
        public int LTFK { get; set; }
        
        public ShipModel(int LID, string Name, string Manufacture, int Power_dv, double Dlina, double Shirina, double Osadka, double Visota_bort, int Speed_max, double Vodoizmesch, double Rashod_topl, string Sostoyanie, double Sum_day, int LTFK)
        {
            this.LID = LID;
            this.Name = Name;
            this.Manufacture = Manufacture;
            this.Power_dv = Power_dv;
            this.Dlina = Dlina;
            this.Shirina = Shirina;
            this.Osadka = Osadka;
            this.Visota_bort = Visota_bort;
            this.Speed_max = Speed_max;
            this.Vodoizmesch = Vodoizmesch;
            this.Rashod_topl = Rashod_topl;
            this.Sostoyanie = Sostoyanie;
            this.Sum_day = Sum_day;
            this.LTFK = LTFK;
        }
    }
}
