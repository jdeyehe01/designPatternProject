using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectDP.Service
{

    public abstract class AbstractServiceRestaurent
    {
        public abstract void ServiceTable();
        public abstract void ServiceHome(String nameClient, String addressClient);

        public abstract void ServiceAtTheTerminal();
    }
}
