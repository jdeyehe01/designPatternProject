using System;
using ProjectDP.Service;
using ProjectDP.Restaurent;
using ProjectDP.Command;



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
                   

            // ORDER
            Order order = new Order();
            order.setBurger(kebab.Burger);
            ValidatedStatus validatedStatus = new ValidatedStatus();
            order.setStatus(validatedStatus);
            validatedStatus.goNext(order);
        }
    }
}
