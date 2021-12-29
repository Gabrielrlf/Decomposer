﻿using Decomposer.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decomposer.Services.Interfaces
{
    public interface IDecomposeService
    {
        void CalculatedCousinPrime(ResultNumberDecomposed resultNumberDecomposed);

        List<int> DecompouseNumber(NumberToDecompose numberToDivider);
    }
}
