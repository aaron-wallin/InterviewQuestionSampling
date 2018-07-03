using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateAStack
{
    public class MyStackItem<T>
    {
        public T ObjectValue { get; private set; }
        public MyStackItem<T> NextItem { get; private set; }
        public MyStackItem(T value, MyStackItem<T> nextStackItem)
        {
            ObjectValue = value;
            NextItem = nextStackItem;
        }
    }
}
