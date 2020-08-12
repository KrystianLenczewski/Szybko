using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace beka.Models
{
    public class Question
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual Test Test { get; set; }
        public virtual IEnumerable<Answer> Answers { get; set; }
    }
}
