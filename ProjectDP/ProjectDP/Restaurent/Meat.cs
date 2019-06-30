using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectDP.Restaurent
{
    public class Meat : IExtra
    {
        private PortionSize size;
        public Meat(PortionSize size)
        {
            this.size = size;
        }
    }
}
