using Decomposer.Domain.Creator;
using Decomposer.Domain.Entities;
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
            return new NumberToDecompose()
            {
                NumberA = numberA
            };
        }

        protected override ResultNumberDecomposed ReturnDecomposedNumber(NumberToDecompose numberToDecompose)
        {
            throw new NotImplementedException();
        }
    }
}
