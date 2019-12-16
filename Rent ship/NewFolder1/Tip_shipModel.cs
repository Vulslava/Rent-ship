using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rent_ship.Model
{
    public class Tip_shipModel
    {
        public int LTID { get; set; }
        public string Name { get; set; }

        public Tip_shipModel(int LTID, string Name)
        {
            this.LTID = LTID;
            this.Name = Name;
        }
    }
}
