using Decomposer.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decomposer.Tests.Generator
{
    class DecomposeGenerator
    {
        public static IEnumerable<object[]> GetResultNumberDecomposed_Pass()
        {
            yield return new object[]
            {
               new ResultNumberDecomposed()
               {
                   EntryNumber = 45,
                   DividingNumbers = { 45, 15, 9, 5, 3, 1 }
               }
            };

            yield return new object[]
            {
               new ResultNumberDecomposed()
               {
                   EntryNumber = 25,
                   DividingNumbers = { 25, 5, 1 }

               }
            };
        }
    }
}
