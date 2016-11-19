using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyList
{
    public class Element<T> 
    {
        T _value;
        Element<T> _next;

        public Element(T value, Element<T> next)
        {
            this.Value = value;
            Next = next;
        }

        public T Value
        {
            get { return _value; }
            set { _value = value; }
        }

        public Element<T> Next
        {
            get { return _next; }
            set { _next = value; }
        }
    }

}