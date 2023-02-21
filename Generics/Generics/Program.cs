using Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GenericMaximum genericClass = new GenericMaximum();

            //for integer method 
            //UC1
            int ans = genericClass.GenMaximum(5, 4, 6);
            Console.WriteLine("the maximum num are : " + ans);
        }
    }
}