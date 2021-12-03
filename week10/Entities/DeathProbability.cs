using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using week10.Entities;

namespace week10.Entities
{
    public class DeathProbability
    {
        public Gender Gender { get; set; }
        public int Age { get; set; }
        public double P { get; set; }

        public DeathProbability()
        {

        }
    }
}
