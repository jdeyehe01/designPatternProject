using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectDP.Restaurent
{
    public abstract class BurgerBuilder
    {
        protected Burger burger;

        public Burger Burger
        {
            get { return burger; }
        }

        public abstract void AddBread();
        public abstract void AddMeats();
        public abstract void AddCheese();
        public abstract void AddVeggies();
        public abstract void AddCondiments();

    }
}
