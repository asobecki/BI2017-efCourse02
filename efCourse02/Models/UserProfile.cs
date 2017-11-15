using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace efCourse02.Models
{
    public class UserProfile
    {
        [Key]
        public int UserId { get; set; }
        [MaxLength(64)]
        public string Name { get; set; }
    }
}
