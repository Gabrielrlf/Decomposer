using Decomposer.Domain.Creator;
using Decomposer.Domain.Entities;
using Decomposer.Domain.Exception;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decomposer.Domain.Factory
{
    public class NumberFactory : NumberFactoryMethod
    {
        protected override NumberToDecompose CreateNumberToDecompose(int numberA)
        {
            return new NumberToDecompose(numberA);
        }
        protected override ResultNumberDecomposed ReturnDecomposedNumber(NumberToDecompose numberToDecompose)
        {
            if (numberToDecompose.EntryNumber == 0)
                throw new NumberException("Não é possível dividir por 0");

            return new ResultNumberDecomposed()
            {
                EntryNumber = numberToDecompose.EntryNumber,
                DividingNumbers = numberToDecompose.DividingNumbers
            };
        }
    }
}
