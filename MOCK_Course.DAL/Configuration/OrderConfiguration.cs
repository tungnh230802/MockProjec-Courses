﻿using Course.DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Course.DAL.Configuration
{
    internal class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            // 1-n:user-order
            builder.HasOne(o => o.User)
                .WithMany(u => u.orders)
                .HasForeignKey(o => o.UserId)
                .OnDelete(DeleteBehavior.NoAction);

            // 1-n:course-order
            builder.HasOne(o => o.Course)
                .WithMany(c => c.orders)
                .HasForeignKey(o => o.CourseId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.Property(o => o.Price).HasColumnType("money");
        }
    }
}
