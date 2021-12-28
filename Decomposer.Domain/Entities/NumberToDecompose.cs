using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decomposer.Domain.Entities
{
    public class NumberToDecompose : BaseEntity
    {
        public NumberToDecompose() { }
        public NumberToDecompose(int _numberA, int _numberB)
        {
            NumberA = _numberA;
            NumberB = _numberB;
        }
        public int NumberA { get; set; }
        public int NumberB { get; set; }

    }
}
