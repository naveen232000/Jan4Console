using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jan4Console
{
    public class UnSafeCode
    {
        static void Main(string[] args)
        {
            unsafe {
            int num = 20;
            int* pointer = &num;
                double num2 = 40;
                int* pointer2 = &num;
                Console.WriteLine("Value : {0} & Address : {1}",num,(int)pointer);
                Console.WriteLine("Value : {0} & Address : {1}", num2, (int)pointer2);
            }
            Console.ReadLine();
        }
    }
}
