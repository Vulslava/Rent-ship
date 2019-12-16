using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rent_ship.Model
{
    public class DogovorModel
    {
        public int DID { get; set; }
        public DateTime Date_of { get; set; }
        public DateTime Date_sd { get; set; }
        public DateTime Date_ok { get; set; }
        public double Sum { get; set; }
        public int CFK { get; set; }
        public int SFK { get; set; }
        public int LFK { get; set; }
        
        public DogovorModel(int DID, DateTime Date_of, DateTime Date_sd, DateTime Date_ok, double Sum, int CFK, int SFK, int LFK)
        {
            this.DID = DID;
            this.Date_of = Date_of;
            this.Date_sd = Date_sd;
            this.Date_ok = Date_ok;
            this.Sum = Sum;
            this.CFK = CFK;
            this.SFK = SFK;
            this.LFK = LFK;
        }
    }
}
