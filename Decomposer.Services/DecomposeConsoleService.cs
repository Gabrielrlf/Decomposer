using Decomposer.Domain.Creator;
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
        private readonly NumberFactoryMethod _numberFactory;
        private readonly IDecomposeService _decomposeService;
        public DecomposeConsoleService(NumberFactoryMethod numberFactory, IDecomposeService decomposeService)
        {
            _numberFactory = numberFactory;
            _decomposeService = decomposeService;
        }
        public void ExecuteDecomposeConsole()
        {
            Console.Clear();
            var numberToDecompose = _numberFactory.MakeDecomposeNumber(WriterConsoleAndReturnNumber());
            _decomposeService.DecompouseNumber(numberToDecompose);
            var resultNumber = _numberFactory.ReturnResult(numberToDecompose);
            _decomposeService.CalculatedCousinPrime(resultNumber);
            FinishApplication(resultNumber);
        }

        public void FinishApplication(ResultNumberDecomposed resultNumber)
        {
            Console.Clear();
            Console.WriteLine($"Número de entrada: {resultNumber.EntryNumber}");
            resultNumber.PrintDividingNumbers();
            resultNumber.PrintPrimeDivisers();
            Console.WriteLine("Continuar? Aperte ENTER");
            if (Console.ReadKey().Key == ConsoleKey.Enter)
                ExecuteDecomposeConsole();
        }

        public int WriterConsoleAndReturnNumber()
        {
            System.Console.WriteLine("Inicializando a aplicação...");
            Console.Write("Digite seu número de entrada: ");
            return int.Parse(Console.ReadLine());
        }
    }
}
