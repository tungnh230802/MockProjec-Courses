﻿using Course.DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Course.DAL.Configuration
{
    internal class ShoppingCartConfiguration : IEntityTypeConfiguration<ShoppingCart>
    {
        public void Configure(EntityTypeBuilder<ShoppingCart> builder)
        {
            // 1-n:user-cart
            builder.HasOne(c => c.User)
                .WithMany(u => u.carts)
                .HasForeignKey(c => c.UserId);

            // 1-n:course-cart
            builder.HasOne(ct => ct.Course)
                .WithMany(c => c.carts)
                .HasForeignKey(ct => ct.CourseId).
                OnDelete(DeleteBehavior.NoAction).
                OnDelete(DeleteBehavior.NoAction);
        }
    }
}
