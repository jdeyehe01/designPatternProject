using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectDP.Order
{
   public class Memento
    {
        private IStatus status;

        public Memento(IStatus status)
        {
            this.status = status;
        }

        public IStatus getStatus()
        {
            return this.status;
        }
    }
}
