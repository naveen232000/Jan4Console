using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jan4Console
{
    public class Events
    {
        public delegate string MyDel(string txt);//step1 declear delegate
        event MyDel Test;//Assign event to deligate step2
        public string CallMe(string name)//step3
        {
            return "Hello "+ name;
        }
        //step4
        public Events()
        {
            this.Test = new MyDel(this.CallMe);
        }
        //step5
        static void Main(string[] args)
        {
            Events events = new Events();
            string res=events.Test("Naveen");
            Console.WriteLine(res);
            Console.ReadLine();

        }
    }
}
