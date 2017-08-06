namespace TicketStore.Domain.DbContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Order")]
    public partial class Order
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Order()
        {
            Tickets = new HashSet<Ticket>();
        }

        public int OrderID { get; set; }

        public int? VoyageID { get; set; }

        public short Status { get; set; }

        [Required]
        [StringLength(128)]
        public string UserId { get; set; }

        public virtual Status Status1 { get; set; }

        public virtual VoyageData VoyageData { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ticket> Tickets { get; set; }
    }
}
