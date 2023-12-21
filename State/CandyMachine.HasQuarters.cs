using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public partial class CandyMachine
    {
        protected class HasQuarters : IState
        {
            private CandyMachine _machine;
            public HasQuarters(CandyMachine candy)
            {
                if (candy == null)
                {
                    throw new ArgumentNullException(nameof(candy), "Объект не может быть null");
                }
                _machine = candy;
            }
            public void EjectQuarter()
            {
                Console.WriteLine("Возвращаем монетку!");
                _machine.SetState(new NoQuarters(_machine));
            }
            public void InsertQuarter()
            {
                Console.WriteLine("Вы уже вставили монетку!");
                _machine.SetState(new Sold(_machine));
            }
            public void TurnCrank()
            {
                _machine.DispenseCandy();
                _machine.SetState(new Sold(_machine));
            }
            public void DispenseCandy()
            {
                Console.WriteLine("Ничего не произошло!");
            }
        }
    }
}