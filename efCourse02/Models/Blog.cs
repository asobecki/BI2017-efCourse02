using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace efCourse02.Models
{
    public class Blog
    {
        public Guid Id { get; set; }
        [MaxLength(32)]
        public string Title { get; set; }
        [ForeignKey("UserProfile")]
        public int UserId { get; set; }

        public virtual UserProfile UserProfile { get; set; }
        public string Content { get; set; }
        public JsonObject<List<string>> Tags { get; set; }
    }
}
