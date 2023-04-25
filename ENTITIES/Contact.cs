using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication99.Entities
{
    public class Contact
    {
        [Key]
        public int ContactId { get; set; }
        [StringLength(50)]
        public string UserName { get; set; }
        [StringLength(50)]
        public string Email { get; set; }
        [StringLength(50)]
        public string Subject { get; set; }
        [StringLength(500)]
        public string Message { get; set; }
    }
}
