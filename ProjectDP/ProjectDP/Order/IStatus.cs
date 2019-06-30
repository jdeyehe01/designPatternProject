using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectDP.Order
{
    public interface IStatus 
    {
        void goNext(Order order);

    }
}
