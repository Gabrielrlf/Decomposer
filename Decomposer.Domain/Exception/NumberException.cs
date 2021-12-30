using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decomposer.Domain.Exception
{
    public class NumberException : ArgumentException
    {
        public NumberException(string message) : base(message)
        {
        }
    }
}
