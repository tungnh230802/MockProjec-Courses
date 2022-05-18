﻿using Course.DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Course.DAL.Configuration
{
    internal class LessonCompletionConfiguration : IEntityTypeConfiguration<LessonCompletion>
    {
        public void Configure(EntityTypeBuilder<LessonCompletion> builder)
        {
            // 1-n:user-lessonCompletion
            builder.HasOne(l => l.User)
                .WithMany(u => u.lessonCompletions)
                .HasForeignKey(l => l.UserId)
                .OnDelete(DeleteBehavior.NoAction);

            // 1-n:lession-lessionCompletion
            builder.HasOne(lc => lc.lesson)
                .WithMany(l => l.LessonCompletions)
                .HasForeignKey(lc => lc.LessonId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
