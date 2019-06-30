using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectDP.Service
{
    public class ServiceRestaurent : AbstractServiceRestaurent
    {
        private ServiceAtHome serviceHome;
        private ServiceAtTheTerminal serviceTerminal;
        private ServiceTable serviceTable;


        public ServiceRestaurent()
        {
            serviceHome = new ServiceAtHome();
            serviceTerminal = new ServiceAtTheTerminal();
            serviceTable = new ServiceTable();
        }


        public override void ServiceTable()
        {
            serviceTable.confirmationTable("Table Eiffel");
            serviceTerminal.getManager();
        }

        public override void ServiceHome(String nameClient, String addressClient)
        {
            Client c = new Client(nameClient, addressClient);
            serviceHome.getConfirmationAtHome(c);
            serviceHome.serviceHome();

        }

        public override void ServiceAtTheTerminal()
        {
            serviceTerminal.confirmationTerminal();
            serviceTerminal.getManager();

        }

    }
}
