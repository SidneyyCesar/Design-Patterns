using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor
{
    abstract class Element
    {
        public abstract void Accept(Visitor visitor);
    }
}
