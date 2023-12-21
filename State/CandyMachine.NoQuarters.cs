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
        protected class NoQuarters : IState
        {
            private CandyMachine _machine;
            public NoQuarters(CandyMachine candy)
            {
                if (candy == null) { throw new ArgumentNullException(nameof(candy), "Пустое значение конфет!"); }
                _machine = candy;
            }
            public void EjectQuarter()
            {
                Console.WriteLine("Нет монет в наличии!");
            }
            public void InsertQuarter()
            {
                Console.WriteLine("Вы вставили монетку!");
                _machine.SetState(new HasQuarters(_machine));
            }
            public void TurnCrank()
            {
                Console.WriteLine("Так как монетка не вставлена - конфетка не выдана!");
            }
            public void DispenseCandy()
            {
                Console.WriteLine("Ничего не произошло!");
            }
        }
    }
}