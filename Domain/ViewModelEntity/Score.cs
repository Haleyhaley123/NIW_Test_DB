using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Score
    {
       public int ScoreId { get; set; }

       public int StudentId { get; set; }   

       public int SubjectId { get; set; }  
        
       public int score { get; set; }
    }
}
