using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOCK_Course.DAL.Models
{
    public class CourseReview :BaseEntity
    {
        //[ForeignKey("Enrollment")]
        public Guid EnrollmentId { get; set; }
        public Enrollment Enrollment { get; set; }
        public string Content { get; set; }
    }
}
