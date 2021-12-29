using Decomposer.Domain.Entities;
using Decomposer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decomposer.Services
{
    public class DecomposeConsoleService : IDecomposeConsoleService
    {
        public void FinishApplication(ResultNumberDecomposed resultNumber)
        {
            Console.Clear();
            Console.WriteLine($"Número de entrada: {resultNumber.EntryNumber} \n");
            resultNumber.PrintDividingNumbers();
        }

        public int WriterConsoleAndReturnNumber()
        {
            System.Console.WriteLine("Inicializando a aplicação...");
            Console.Write("Digite seu número de entrada: ");
            return int.Parse(Console.ReadLine());
        }
    }
}
