namespace TicketStore.Domain.DbContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VoyageData")]
    public partial class VoyageData
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public VoyageData()
        {
            Orders = new HashSet<Order>();
            Tickets = new HashSet<Ticket>();
        }

        [Key]
        public int VoyageID { get; set; }

        public int DepartureStopID { get; set; }

        public int ArrivalStopID { get; set; }

        public DateTime DepartureDateTime { get; set; }

        public DateTime ArrivalDateTime { get; set; }

        public TimeSpan? TravelTime { get; set; }

        public int VoyageNumber { get; set; }

        public string VoyageName { get; set; }

        public int NumberSeats { get; set; }

        [Column(TypeName = "money")]
        public decimal TicketCoast { get; set; }

        public virtual BusStop BusStop { get; set; }

        public virtual BusStop BusStop1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order> Orders { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ticket> Tickets { get; set; }

        public DateTime GetData(DateTime datetime)
        {
            var data = datetime;
            data.ToShortDateString();
            return (DateTime)data;
        }

    }
}
