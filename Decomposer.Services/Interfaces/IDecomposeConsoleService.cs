using Decomposer.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decomposer.Services.Interfaces
{
    public interface IDecomposeConsoleService 
    {
        void ExecuteDecomposeConsole();
        int WriterConsoleAndReturnNumber();

        void FinishApplication(ResultNumberDecomposed resultNumber);
    }
}
