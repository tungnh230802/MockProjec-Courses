using Course.DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Course.DAL.Configuration
{
    internal class SectionConfiguration : IEntityTypeConfiguration<Section>
    {
        public void Configure(EntityTypeBuilder<Section> builder)
        {
            // 1-n:course-section
            builder.HasOne(s => s.Course)
                .WithMany(c => c.sections)
                .HasForeignKey(s => s.CourseId);
        }
    }
}
