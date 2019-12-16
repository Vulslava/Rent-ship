namespace Rent_ship.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Ship")]
    public partial class Ship
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Ship()
        {
            Dogovor = new HashSet<Dogovor>();
        }

        [Key]
        public int LID { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [StringLength(50)]
        public string Manufacture { get; set; }

        public int Power_dv { get; set; }

        public float Dlina { get; set; }

        public float Shirina { get; set; }

        public float Osadka { get; set; }

        public float Visota_bort { get; set; }

        public int Speed_max { get; set; }

        public float Vodoizmesch { get; set; }

        public float Rashod_topl { get; set; }

        [Required]
        [StringLength(50)]
        public string Sostoyanie { get; set; }

        [Column(TypeName = "money")]
        public decimal Sum_day { get; set; }

        public int LTFK { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Dogovor> Dogovor { get; set; }

        public virtual Tip_ship Tip_ship { get; set; }
    }
}
