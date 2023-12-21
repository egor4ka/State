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
        protected class SoldOut : IState
        {
            private CandyMachine _machine;
            public SoldOut(CandyMachine candy)
            {
                if (candy == null) { throw new ArgumentNullException(nameof(candy), "Пустое значение конфет!"); }
                _machine = candy;
            }
            public void EjectQuarter()
            {
                Console.WriteLine("Возвращаем монетку!");
            }
            public void InsertQuarter()
            {
                EjectQuarter();
            }
            public void TurnCrank()
            {
                Console.WriteLine("Ничего не произошло!");
            }
            public void DispenseCandy()
            {
                Console.WriteLine("Ничего не произошло!");
            }
        }
    }
}