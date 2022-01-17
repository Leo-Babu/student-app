using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace StudentAPI.Entities
{
    public class Course
    {
        [Key]
        public int Id { get; set; }
        public String Name { get; set; }
        public String Subject { get; set; }
        
    }
}
