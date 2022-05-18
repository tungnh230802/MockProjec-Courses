using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOCK_Course.DAL.Models
{
    public class Course : BaseEntity
    {
        //public Guid CategoryId { get; set; }
        public Guid UserId { get; set; }
         
        [Required]
        [MaxLength(100)]
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        [Column(TypeName = "money")]
        public decimal OriginalPrice { get; set; }
        public string TrailerUrl { get; set; }
        public Guid PromotionId { get; set; }
        public bool IsPublish { get; set; } = false;
        public List<CategoryCourse> CategoryCourses { get; set; }
        public List<Section> Sections { get; set; }

    }
}
