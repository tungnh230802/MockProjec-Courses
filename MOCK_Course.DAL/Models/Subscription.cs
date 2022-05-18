using MOCK_Course.DAL.Models;
using System;

namespace Course.DAL.Models
{
    public class Subscription : BaseEntity<Guid>
    {
        public Guid UserId { get; set; }
        public AppUser User { get; set; }
    }
}
