using Decomposer.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decomposer.Services.Interfaces
{
    public interface IDecomposeService
    {
        ResultNumberDecomposed MakeOperation(int number);
        void CalculatedCousinPrime(ResultNumberDecomposed resultNumberDecomposed);

        void DecompouseNumber(NumberToDecompose numberToDivider);
    }
}
