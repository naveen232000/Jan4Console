using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jan4Console
{
    //Predicate -Delegate -Lambda  -anonymous
    public class Predicate
    {
        public static bool IsEven(int num) {
            if (num % 2 == 0) { return true; }
            return false;
        }
        static void Main(string[] args)
        {

            Console.WriteLine("Enter a Number :");
            int num = Convert.ToInt16(Console.ReadLine());

            //generic 
            Predicate<int> predicate = IsEven;
            bool result=predicate.Invoke(num);
            Console.WriteLine("Generic result {0} is even ? {1}",num,result);

            //anonymous
            Predicate<int> predicate2 = delegate (int num1) {
                if (num % 2 == 0) { return true; }
                return false;
            };
           bool result2= predicate2.Invoke(num);
            Console.WriteLine("Anonymous result {0} is even ? {1}", num, result2);

            //Lambda
            Predicate<int> lamPred=(num2)=> {
                if (num % 2 == 0) { return true; }
                return false;
            };
            bool result3= lamPred.Invoke(num);
            Console.WriteLine("Lambda result {0} is even ? {1}", num, result3);
            Console.ReadLine();
        }
    }
}
