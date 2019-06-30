using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectDP.Service
{
   public class ServiceAtTheTerminal
    {
        public void getManager()
        {
            Console.WriteLine("M.TOTO est en charge de votre commande");

        }

        public void confirmationTerminal()
        {
            Console.WriteLine("Votre commande à bien été prise en compte, veuillez vous rendre au comptoire svp.");
        }
    }
}
