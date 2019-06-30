using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectDP.Restaurent
{
    public class Burger
    {
        private String type;
        private Dictionary<BurgerEnum, IExtra> ingredients = new Dictionary<BurgerEnum, IExtra>();


        public Burger(String type)
        {
            this.type = type;
        }
    

        public IExtra this[BurgerEnum key]
        {
            get { return ingredients[key]; }
            set { ingredients[key] = value; }
        }


        public void Show()
        {
            foreach(var item in ingredients)
            {
                Console.WriteLine(item.Key);
                Console.WriteLine(item.Value);
            }
        }
    }
}
