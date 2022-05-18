using MOCK_Course.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.DAL.Models
{
    public class ShoppingCart : BaseEntity<Guid>
    {
        public Guid UserId { get; set; }
        public AppUser User { get; set; }

        public Guid CourseId { get; set; }
        public Courses Course { get; set; }
    }
}
