using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNet5788_01_0520_4703
{
    class Program
    {
        public static Random rand = new Random();
        static void Main(string[] args)
        {            
             question1 q1 = new question1();
         //    question2 q2 = new question1();
             bool stop = false;
            while (!stop)
            {
                Console.WriteLine("Please pick a Question: ");
          
               int  num = Console.ReadLine();
                Console.Read.num;
                switch (num)
                {
                    case (1):
                        q1.play();
                        break;
                    case (2):
 //                       q2.play();
                        break;
                    default:
                        stop = true;
                        break;
                }
}

        }
    }
}
