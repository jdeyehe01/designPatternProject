using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectDP.Order
{
    public class ValidatedStatus : IStatus
    {
        public void goNext(Order order)
        {
            DeliveredStatus status = new DeliveredStatus();
            order.setStatus(status);
        }
    }
}
