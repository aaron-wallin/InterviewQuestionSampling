using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateAStack
{
    public class MyStack<T>
    {
        private MyStackItem<T> _stackItem;

        public MyStack()
        {

        }

        public void Push(T data)
        {
            var stackItem = new MyStackItem<T>(data, _stackItem);
            _stackItem = stackItem;
        }

        public T Pop()
        {
            if (IsEmpty())
                throw new Exception("Stack is empty, nothing to pop.");

            var nextStackItem = _stackItem.NextItem;
            var valueToReturn = _stackItem.ObjectValue;
            _stackItem = nextStackItem;
            return valueToReturn;
        }

        public bool IsEmpty()
        {
            return _stackItem == null;
        }
    }
}
