using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    class Child1 : Parent
    {
        public Child1()
        {
            this.protectedField = "protected";
            this.PublicField = "public";
        }
    }
}