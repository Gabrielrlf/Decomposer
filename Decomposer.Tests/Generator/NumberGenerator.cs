using Decomposer.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decomposer.Tests.Generator
{
    class NumberGenerator
    {
        public static IEnumerable<object[]> GetNumberToDecompose_Pass()
        {
            yield return new object []
            {
               new NumberToDecompose()
               {
                   EntryNumber = 1,
                   DividingNumbers = new List<int>(){ 3, 4, 5, 6}
               }
            };

            yield return new object[]
            {
               new NumberToDecompose()
               {
                   EntryNumber = 15,
                   DividingNumbers = new List<int>(){ 3, 8, 9, 6}
               }
            };
        }

        public static IEnumerable<object[]> GetNumberToDecompose_Fail()
        {
            yield return new object[]
            {
               new NumberToDecompose()
               {
               }
            };

        }
    }
}
