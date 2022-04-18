using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    [Table("cat_Student")]
    public class Student
    {
        public int StudentId { get; set; }  
        public string FullName { get; set; }    
        public string Address { get; set; } 
        public string PhoneNumber { get; set; } 
        public string Email { get; set; }
    }
}
