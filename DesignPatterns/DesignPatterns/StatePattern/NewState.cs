using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StatePattern
{
    public class NewState : IState
    {

        public void Handler(CustomerContext customerContext, decimal amount)
        {
            Console.WriteLine($"Ingreso saldo {amount}");

            customerContext.Residue = amount;

            customerContext.SetState(new NotDebtorState());
        }
    }
}
