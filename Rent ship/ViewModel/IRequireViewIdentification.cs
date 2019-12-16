using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rent_ship.ViewModel
{
    public interface IRequireViewIdentification
    {
        Guid ViewID { get; }
    }
}
