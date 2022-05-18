using Course.DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Course.DAL.Configuration
{
    internal class SubscriptionConfiguration : IEntityTypeConfiguration<Subscription>
    {
        public void Configure(EntityTypeBuilder<Subscription> builder)
        {
            // 1-n: user-subscription
            builder.HasOne(s => s.User)
                .WithMany(u => u.subscriptions)
                .HasForeignKey(s => s.UserId);
        }
    }
}
