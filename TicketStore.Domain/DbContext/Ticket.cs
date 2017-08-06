namespace TicketStore.Domain.DbContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Ticket")]
    public partial class Ticket
    {
        public int TicketID { get; set; }

        public int OrderID { get; set; }

        public int VoyageID { get; set; }

        public string PassengerFirstName { get; set; }

        public string PassengerLastName { get; set; }

        public string PassengerDocNumber { get; set; }

        [Range(1,40)]
        public int PassengerSeatNumber { get; set; }

        public short? Status { get; set; }

        public virtual Order Order { get; set; }

        public virtual Status Status1 { get; set; }

        public virtual VoyageData VoyageData { get; set; }
    }
}
