namespace Rent_ship.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Client")]
    public partial class Client
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Client()
        {
            Dogovor = new HashSet<Dogovor>();
        }

        [Key]
        public int CID { get; set; }

        [Required]
        [StringLength(50)]
        public string FIO { get; set; }

        [StringLength(50)]
        public string Adres { get; set; }

        public int? Tel { get; set; }

        public int Serp { get; set; }

        public int Nump { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Dogovor> Dogovor { get; set; }
    }
}
