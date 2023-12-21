using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CandyMachine candyMachine = new CandyMachine(5);
            candyMachine.InsertQuarter();
            candyMachine.TurnCrank();

            candyMachine.InsertQuarter();
            candyMachine.TurnCrank();

            candyMachine.InsertQuarter();

            Console.WriteLine($"Осталось конфет: {candyMachine.candyLeft}");
            Console.ReadLine();
        }
    }
}
