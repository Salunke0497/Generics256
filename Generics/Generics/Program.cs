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
            int ans = genericClass.GenMaximum(5, 4, 6);
            Console.WriteLine("the maximum num are : " + ans);
            
            //for float method
            float value = genericClass.GenMaximum(7f,6f,9f);
            Console.WriteLine("the maximum float value are : " + value);

            //for string method
            string answer = genericClass.GenMaximum("Apple","Banana","Mango");
            Console.WriteLine("the maximum string value are : " + answer);
            Console.ReadLine();
        }
    }
}
