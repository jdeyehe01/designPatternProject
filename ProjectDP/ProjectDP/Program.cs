using System;
using ProjectDP.Service;
using ProjectDP.Restaurent;
using ProjectDP.Order;



namespace ProjectDP
{
    class Program
    {
        static void Main(string[] args)
        {
            // SERVICE LIVRAISON
            AbstractServiceRestaurent service = new ServiceRestaurent();
            service.ServiceHome("Toto","15 rue Dupond 75001 Paris");

            // KEBAB BUILDER
            Kebab kebab = new Kebab();
            kebab.AddBread();
            kebab.AddMeats();

            // BURGER
            Burger burger = Kebab.getBurger();

            // ORDER
            Order order = new Order();
            order.setBurger();
            ValidatedStatus validatedStatus = new ValidatedStatus();
            order.setStatus(validatedStatus);
            validatedStatus.goNext(order);
        }
    }
}
