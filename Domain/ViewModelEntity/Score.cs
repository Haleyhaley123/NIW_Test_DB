using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    [Table("cat_Score")]
    public class Score
    {
        [Key]
       public Int64 ScoreId { get; set; }

       public Int64 StudentId { get; set; }   

       public Int64 SubjectId { get; set; }  
        
       public int sCore { get; set; }
    }
}
