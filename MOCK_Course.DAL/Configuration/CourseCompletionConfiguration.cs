﻿using Course.DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Course.DAL.Configuration
{
    internal class CourseCompletionConfiguration : IEntityTypeConfiguration<CourseCompletion>
    {
        public void Configure(EntityTypeBuilder<CourseCompletion> builder)
        {
            // 1-n: course-courseCompletion
            builder.HasOne(cc => cc.Course)
                .WithMany(c => c.courseCompletions)
                .HasForeignKey(cc => cc.CourseId).
                OnDelete(DeleteBehavior.NoAction);

            // 1-n: user-courseCompletion
            builder.HasOne(cc => cc.User)
                .WithMany(u => u.courseCompletions)
                .HasForeignKey(cc => cc.UserId);
        }
    }
}
