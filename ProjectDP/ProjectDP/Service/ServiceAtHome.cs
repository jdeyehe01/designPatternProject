using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectDP.Service
{
    public class ServiceAtHome
    {

        public void serviceHome()
        {
            Console.WriteLine("Le service à domicile a été choisi par le client");
        }

        public void getConfirmationAtHome(Client client)
        {
            if (client == null)
            {
                Console.WriteLine("Le client doit être initialisé !");
                return;
            }
            Console.WriteLine("Merci d'avoir choisi notre restaurent, vous serez livrez dans 30mn à l'adresse suivante :");
            Console.WriteLine(client.address);
        }
    }
}
