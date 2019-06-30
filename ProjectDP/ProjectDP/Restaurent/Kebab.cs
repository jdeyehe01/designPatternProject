using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectDP.Restaurent
{
    public class Kebab : BurgerBuilder
    {
        public Kebab()
        {
            burger = new Burger("Kebab");
        }

        public override void AddBread()
        {
            burger[BurgerEnum.Bread] = (IExtra) new TurkeyBread(PortionSize.Medium);
        }

        public override void AddCheese()
        {
            burger[BurgerEnum.Cheese] = (IExtra)new Cheese(PortionSize.Medium);
        }

        public override void AddCondiments()
        {
            burger[BurgerEnum.Comdiment] = (IExtra) new Comdiment(PortionSize.Medium);
        }

        public override void AddMeats()
        {
            burger[BurgerEnum.Meats] = (IExtra) new Meat(PortionSize.Medium) ;
        }

        public override void AddVeggies()
        {

            List<IExtra> ing = new List<IExtra>();
            ing.Add((IExtra)new Salad());
            ing.Add((IExtra)new Tomato());
            ing.Add((IExtra)new Onion());

            burger[BurgerEnum.Veggies] = (IExtra) ing;

        }
    }
}
