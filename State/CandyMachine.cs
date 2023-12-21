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
        public int candyLeft { get; private set; }
        private IState _state;
        public CandyMachine(int сandyCount)
        {
            candyLeft = сandyCount;
            _state = candyLeft > 0 ? new NoQuarters(this) : (IState)new SoldOut(this);
        }
        protected void SetState(IState state)
        {
            if (state == null)
            {
                throw new ArgumentNullException(nameof(state), "Состояние не может быть null");
            }
            _state = state;
        }
        public void EjectQuarter()
        {
            _state.EjectQuarter();
        }
        public void InsertQuarter()
        {
            _state.InsertQuarter();
        }
        public void TurnCrank()
        {
            _state.TurnCrank();
            DispenseCandy();
        }
        private void DispenseCandy()
        {
            _state.DispenseCandy();
        }
    }
}