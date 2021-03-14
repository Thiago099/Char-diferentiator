using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace McGyver
{
    class Element:IComparable<Element>
    {
        public Element(char a, char b, char representant)
        {
            this.a = a;
            this.b = b;
            this.representant = representant;
        }
        public char a;
        public char b;
        public char representant;

        public int CompareTo([AllowNull] Element other)
            =>this.a.CompareTo(other.a);
    }
   
}
