namespace TicketStore.Domain.DbContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class BusStop
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BusStop()
        {
            VoyageDatas = new HashSet<VoyageData>();
            VoyageDatas1 = new HashSet<VoyageData>();
        }

        public int BusStopID { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string StatusStop { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VoyageData> VoyageDatas { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VoyageData> VoyageDatas1 { get; set; }

        public override string ToString()
        {
            return Name.ToString();
        }
    }
}
