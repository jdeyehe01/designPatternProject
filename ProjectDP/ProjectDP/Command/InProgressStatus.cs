using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectDP.Command
{
    public class InProgressStatus : IStatus
    {

        public InProgressStatus()
        {
            Console.WriteLine("Commande en cours");
        }

        public void goNext(Order order)
        {
            ValidatedStatus status = new ValidatedStatus();
            order.setStatus(status);
        }
    }
}
