using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectDP.Command
{
    public interface IStatus 
    {
        void goNext(Order order);

    }
}
