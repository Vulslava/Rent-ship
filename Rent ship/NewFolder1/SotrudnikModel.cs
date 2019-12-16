using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rent_ship.Model
{
    public class SotrudnikModel
    {
        public int SID { get; set; }
        public string FIO { get; set; }
        public int Num { get; set; }
        public string Pass { get; set; }
        public int TFK { get; set; }

        public SotrudnikModel(int SID, string FIO, int Num, string Pass, int TFK)
        {
            this.SID = SID;
            this.FIO = FIO;
            this.Num = Num;
            this.Pass = Pass;
            this.TFK = TFK;
        }
    }
}
