using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    internal class Program
    {
        static void Main()
        {
            Vector v = new Vector(23);
            v.AddValue(24);
            Vector v1 = new Vector(-25);
            v1.AddValue(26);
            Vector result = v + v1;
            Vector r = new Vector();
            if(r == result);
            Console.WriteLine(string.Join(", ", r.ReturnValue()));
            r =r* 2;
            Console.WriteLine(string.Join(", ", r.ReturnValue()));
            r = Vector.Delete(r);
            Console.WriteLine(string.Join(", ", r.ReturnValue()));
        }
    }
}
