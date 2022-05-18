using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOCK_Course.DAL.Models
{
    public class CategoryCourse : BaseEntity
    {
        public Guid CategoryId { get; set; }
        public Guid CourseId { get; set; }
        public Category Category { get; set; }
        public Course Course { get; set; }

    }
}
