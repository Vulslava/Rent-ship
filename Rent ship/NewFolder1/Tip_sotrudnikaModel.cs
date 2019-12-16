using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rent_ship.Model
{
    public class Tip_sotrudnikaModel
    {
        public int TID { get; set; }
        public string Name { get; set; }

        public Tip_sotrudnikaModel(int TID, string Name)
        {
            this.TID = TID;
            this.Name = Name;
        }
    }
}
