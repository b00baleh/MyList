using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyList
{
    public class MyList<T>
    {
        Element<T> _first;

        public void Add(T val)
        {
            var newElement = new Element<T>(val, null);

            if (_first == null)
                _first = newElement;
            else
            {
                var current = _first;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newElement;
            }
        }

        public void Delete(T val)
        {
            var current = _first;
            var prev = current;

            if (current.Value.Equals(val))
                _first = current.Next;
            else
            {
                while (current.Next != null)
                {
                    prev = current;
                    current = current.Next;
                    if (current.Value.Equals(val))
                    {
                        prev.Next = current.Next;
                        return;
                    }
                }
            }
        }

        public T[] ToList()
        {
            var list = new List<T>();
            var current = _first;
            while (current != null)
            {
                list.Add(current.Value);
                current = current.Next;
            }
            return list.ToArray();
        }

        public void Reverse()
        {
            var prev = _first;

            if (prev.Next == null)
                return;

            var current = prev.Next;

            if (current.Next == null)
            {
                prev.Next = null;
                current.Next = prev;
                _first = current;
                return;
            }

            var next = current.Next;
            while (true)
            {
                if (prev == _first)
                    prev.Next = null;

                current.Next = prev;
                prev = current;
                current = next;
                if (next.Next == null)
                {
                    next.Next = prev;
                    _first = next;
                    return;
                }
                else
                    next = next.Next;
            }
        }
    }
}