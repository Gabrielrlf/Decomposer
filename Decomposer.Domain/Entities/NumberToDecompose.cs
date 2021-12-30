using Decomposer.Domain.Exception;
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
            DividingNumbers = new();
        }
        public NumberToDecompose(int _numberA)
        {
            if (_numberA == 0)
                throw new NumberException("Não é possível dividir por 0");

            EntryNumber = _numberA;
        }
    }

}
