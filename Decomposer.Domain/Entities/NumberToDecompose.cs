using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decomposer.Domain.Entities
{
    public class NumberToDecompose : BaseEntity
    {
        public NumberToDecompose()
        {
            DividingNumbers = new List<int>();
        }
        public NumberToDecompose(int _numberA)
        {
            EntryNumber = _numberA;

        }
    }

}
