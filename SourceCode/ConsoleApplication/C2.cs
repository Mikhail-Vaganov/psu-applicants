using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleApplication
{
    class Child2 : Parent, IChildish
    {
        public Child2()
        {
            this.protectedField = "protected";
            this.PublicField = "public";
        }

        public void TakeCandyAway()
        {
            MessageBox.Show("Конфета отобрана!");
        }
    }
}
