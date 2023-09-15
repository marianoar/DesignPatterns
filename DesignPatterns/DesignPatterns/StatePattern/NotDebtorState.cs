using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StatePattern
{
    // debtor : deudor
    internal class NotDebtorState : IState
    {
        public void Handler(CustomerContext customerContext, decimal amount)
        {
            if(amount <= customerContext.Residue)
            {
                Console.WriteLine($"Proceso autorizado: Gasto {amount} y saldo: {customerContext.Residue}");

                customerContext.Discount(amount);

                if(customerContext.Residue < 0)
                {
                    customerContext.SetState (new DebtorState());
                }

                Console.WriteLine($"operacion realizada, saldo: {customerContext.Residue}");

            }
            else
            {
                Console.WriteLine($"Operacion no posible: {amount} es mayor que {customerContext.Residue}");
            }

        }
    }
}
