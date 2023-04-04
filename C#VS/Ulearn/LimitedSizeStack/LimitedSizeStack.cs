using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoApplication
{
    public class LimitedSizeStack<T>
    {
        private readonly int size;
        LinkedList<T> list = new LinkedList<T>();
        public LimitedSizeStack(int limit)
        {
            size = limit;

        }

        public void Push(T item)
        {

            if (list.Count == size && size != 0)
            {
                list.RemoveFirst();
            }
            list.AddLast(item);
        }

        public T Pop()
        {
            if (list.Count == 0)
                throw new InvalidOperationException();
            T result = list.Last.Value;
            list.RemoveLast();
            return result;
        }

        public int Count
        {
            get
            {
                if (size == 0)
                    return 0;
                var result = list.Count;
                return result;
            }
        }
    }
}
