using System;
using System.Collections.Generic;
using System.Text;
using ProjectDP.Restaurent;

namespace ProjectDP.Command
{
    public class Order
    {
        private IStatus status;

        private Burger burger;
        public Burger getBurger() { 
            return this.burger;
        }
        public void setBurger(Burger value)
        {
            this.burger = value; 

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
