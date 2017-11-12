using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace dotNet5788_01_0520_4703
{
    class Program
    {
        static void Main(string[] args)
        {
            pickAnum();
        }



        static void pickAnum()
        {
            Console.WriteLine("Please choose question");
            switch ((Console.Read()))
            {
                case 1:
                    { }
                    break;
                case 2:

                    break;
                 defulte;
                    pickAnum();
            }
        }
    }
}
