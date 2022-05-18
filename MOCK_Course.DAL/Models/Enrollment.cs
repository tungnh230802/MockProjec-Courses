using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOCK_Course.DAL.Models
{
    public class Enrollment : BaseEntity
    {
        public Guid CourseId { get; set; }
        public Guid UserId { get; set; }

    }
}
