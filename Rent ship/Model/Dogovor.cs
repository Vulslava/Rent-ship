namespace Rent_ship.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Dogovor")]
    public partial class Dogovor
    {
        [Key]
        public int DID { get; set; }

        public DateTime Date_of { get; set; }

        public DateTime Date_sd { get; set; }

        public DateTime Date_ok { get; set; }

        [Column(TypeName = "money")]
        public decimal Sum { get; set; }

        public int? CFK { get; set; }

        public int? SFK { get; set; }

        public int? LFK { get; set; }

        public virtual Client Client { get; set; }

        public virtual Ship Ship { get; set; }

        public virtual Sotrudnik Sotrudnik { get; set; }
    }
}
