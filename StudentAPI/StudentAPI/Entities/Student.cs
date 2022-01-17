using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace StudentAPI.Entities
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        public String Name { get; set; }
        public string Address { get; set; }
        public String Phone { get; set; }
        public String Course { get; set; }
    }
}
