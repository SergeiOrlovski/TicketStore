namespace TicketStore.Domain.DbContext
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class StoreTicketDb : DbContext
    {
        public StoreTicketDb()
            : base("name=StoreTicketDb")
        {
        }

        public virtual DbSet<BusStop> BusStops { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Status> Status { get; set; }
        public virtual DbSet<Ticket> Tickets { get; set; }
        public virtual DbSet<VoyageData> VoyageDatas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BusStop>()
                .HasMany(e => e.VoyageDatas)
                .WithRequired(e => e.BusStop)
                .HasForeignKey(e => e.DepartureStopID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BusStop>()
                .HasMany(e => e.VoyageDatas1)
                .WithRequired(e => e.BusStop1)
                .HasForeignKey(e => e.ArrivalStopID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Order>()
                .HasMany(e => e.Tickets)
                .WithRequired(e => e.Order)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Status>()
                .HasMany(e => e.Orders)
                .WithRequired(e => e.Status1)
                .HasForeignKey(e => e.Status)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Status>()
                .HasMany(e => e.Tickets)
                .WithOptional(e => e.Status1)
                .HasForeignKey(e => e.Status);

            modelBuilder.Entity<VoyageData>()
                .Property(e => e.TicketCoast)
                .HasPrecision(19, 4);

            modelBuilder.Entity<VoyageData>()
                .HasMany(e => e.Tickets)
                .WithRequired(e => e.VoyageData)
                .WillCascadeOnDelete(false);
        }
    }
}
