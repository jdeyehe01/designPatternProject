using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectDP.Order
{
    public class Order
    {
        private IStatus status;
        private Burger burger {
            get { return this.burger;}
            set { this.burger = value;}
        }

        public IStatus getStatus()
        {
            return this.status;
        }

        public void setStatus(IStatus status)
        {
            this.status = status;
        }

        public void goNext()
        {
            status.goNext(this);
        }

        public void SetMemento(Memento memento)
        {
            this.status = memento.getStatus();
        }

        public Memento createMemento()
        {
            return new Memento(this.status);
        }
    }
}
