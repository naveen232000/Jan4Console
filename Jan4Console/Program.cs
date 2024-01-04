using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jan4Console
{
    public class Program
    {//Action -Delegate -Lambda  -anonymous 
        public static void ActName(string name)
        {
            Console.WriteLine("Name is " + name);
        }
        public static void ActName() { Console.WriteLine("Hello World"); }
        public static void AddNum(double num1, double num2)
        {
            Console.WriteLine("Sum : "+(num1+num2));
        }

        static void Main(string[] args)
        {
            //Generic action
            Action<double, double> AddAction = AddNum;
            AddAction.Invoke(1.4, 2.6);
            Action<string> action = ActName;
            action.Invoke("Naveen");
            //non generic 
            Action action1 = ActName;
            action1();
            //anonymous
            Action<int, int> action2 = delegate (int x, int y) { Console.WriteLine("Sum Anonymous : "+(x+y)); };
            action2.Invoke(2, 3);
            //lambda
            Action<int , int > action3=(x,y)=> { Console.WriteLine("Multiple lamda method : "+(x*y)); };
            action3.Invoke(3, 4);
            Console.ReadLine();
        }
    }
}
