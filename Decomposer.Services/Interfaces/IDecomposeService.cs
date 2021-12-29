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
        bool IsCousinPrime(int numberA);
        List<int> DecompouseNumber(NumberToDecompose numberToDivider);

        NumberToDecompose CreateDecomposeModel(int numberA, List<int> decomposer);
    }
}
