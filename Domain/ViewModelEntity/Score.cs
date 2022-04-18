using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    [Table("cat_Score")]
    public class Score
    {
       public int ScoreId { get; set; }

       public int StudentId { get; set; }   

       public int SubjectId { get; set; }  
        
       public int sCore { get; set; }
    }
}
