namespace WhyNotEarth.Meredith.Data.Entity.Models.Modules.Hotel
{
    using System;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class Price : IEntityTypeConfiguration<Price>
    {
        public decimal Amount { get; set; }

        public DateTime Date { get; set; }

        public int Id { get; set; }

        public Hotel Hotel { get; set; }

        public int HotelId { get; set; }

        public void Configure(EntityTypeBuilder<Price> builder)
        {
            builder.Property(e => e.Amount).HasColumnType("numeric(5, 2)");
            builder.Property(e => e.Date).HasColumnType("date");
            builder.ToTable("Prices", "ModuleHotel");
        }
    }
}