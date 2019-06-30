using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectDP.Order
{
    public class ValidatedStatus : IStatus
    {
        
        public ValidatedStatus()
        {
            Console.WriteLine("Validation de la commande ...");
        }
        public void goNext(Order order)
        {
            DeliveredStatus status = new DeliveredStatus();
            order.setStatus(status);
        }
    }
}
