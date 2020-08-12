using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace beka.Models
{
    public class Answer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual Question Question { get; set; }
    }
}
