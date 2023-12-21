using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public partial class CandyMachine
    {
        protected class Sold : IState
        {
            private CandyMachine _machine;
            public Sold(CandyMachine candy)
            {
                if (candy == null) { throw new ArgumentNullException(nameof(candy), "Пустое значение конфет!"); }
                _machine = candy;
            }
            public void EjectQuarter()
            {
                Console.WriteLine("Ничего не произошло!");
            }
            public void InsertQuarter()
            {
                Console.WriteLine("Ничего не произошло!");
            }
            public void TurnCrank()
            {
                Console.WriteLine("Ничего не произошло!");
            }
            public void DispenseCandy()
            {
                Console.WriteLine("Выдаем конфету!");
                _machine.SetState(_machine.candyLeft > 0 ? new NoQuarters(_machine) : new SoldOut(_machine));
            }
        }
    }
}