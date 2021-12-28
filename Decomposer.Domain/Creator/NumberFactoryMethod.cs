using Decomposer.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decomposer.Domain.Creator
{
    public abstract class NumberFactoryMethod
    {
        protected abstract ResultNumberDecomposed ReturnDecomposedNumber(NumberToDecompose numberToDivider);
    }
}
