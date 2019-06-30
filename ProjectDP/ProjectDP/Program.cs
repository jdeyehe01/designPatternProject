using System;
using ProjectDP.Service;
using ProjectDP.Restaurent;



namespace ProjectDP
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractServiceRestaurent service = new ServiceRestaurent();

            Kebab kebab = new Kebab();
            
            service.ServiceHome("Toto","15 rue Dupond 75001 Paris");

        }
    }
}
