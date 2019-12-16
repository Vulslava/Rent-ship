using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rent_ship.Model
{
    public class ClientModel
    {
        public int CID { get; set; }
        public string FIO { get; set; }
        public string Adres { get; set; }
        public int Tel { get; set; }
        public int Ser { get; set; }
        public int Nump { get; set; }

        public ClientModel(int CID, string FIO, string Adres, int Tel, int Ser, int Nump)
        {
            this.CID = CID;
            this.FIO = FIO;
            this.Adres = Adres;
            this.Tel = Tel;
            this.Ser = Ser;
            this.Nump = Nump;
        }
    }
}
