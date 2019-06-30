using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectDP.Order
{
    public class CareTaker
    {
        private List<Memento> mementoList = new List<Memento>();

        public void add(Memento memento)
        {
            mementoList.Add(memento);
        }

        public Memento get(int index)
        {
            //  return mementoList.Get(index);

            return mementoList[index];
        }
    }
}

