using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decomposer.Domain.Entities
{
    public class ResultNumberDecomposed
    {
        public int EntryNumber { get; set; }
        public List<int> DividingNumbers { get; set; }
        public List<int> PrimeDivisers { get; set; }
    }
}
