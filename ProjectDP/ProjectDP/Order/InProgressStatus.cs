using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectDP.Order
{
    public class InProgressStatus : IStatus
    {
        public void goNext(Order order)
        {
            ValidatedStatus status = new ValidatedStatus();
            order.setStatus(status);
        }
    }
}
