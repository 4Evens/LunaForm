using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication99.Entities
{
    public class Content
    {
        [Key]
        public int ContentId { get; set; }
        [StringLength(500)]
        public string ContentValue { get; set; }
        public DateTime ContentDate { get; set; } = DateTime.Now;

        public int HeadingId { get; set; }
        public virtual Heading Heading { get; set; }
    }
}
