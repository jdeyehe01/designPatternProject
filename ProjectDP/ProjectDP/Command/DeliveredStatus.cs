using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectDP.Command
{
    public class DeliveredStatus : IStatus
    {
        public DeliveredStatus()
        {
            Console.WriteLine("Commande livrée !");
        }
        
        public void goNext(Order order)
        {
            System.Console.WriteLine("Go next");
        }
    }
}
