using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOCK_Course.DAL.Models
{
    public class Assignment : BaseEntity
    {
        [Required]
        [MaxLength(100)]
        public string Title { get; set; }
        public string Content { get; set; }
        public List<Attachment> Attachments { get; set; }

    }
}
