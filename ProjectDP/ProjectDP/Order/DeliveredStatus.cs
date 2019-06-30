using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectDP.Order
{
    public class DeliveredStatus : IStatus
    {
        public void goNext(Order order)
        {
            System.Console.WriteLine("Go next");
        }
    }
}
