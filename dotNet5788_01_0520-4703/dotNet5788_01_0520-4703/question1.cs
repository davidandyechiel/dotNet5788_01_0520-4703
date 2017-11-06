using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNet5788_01_0520_4703
{

    class question1
    {
        private int[] arr;

        #region Properties
        public int[] Arr
        {
            set
            {
                arr = new int[100];
                foreach (int item in arr)
                    arr[item] = Program.rand.Next(0, 1001);
            }
        }
        #endregion

        public void play()
        {
            bool stop = false;
            while (!stop)
            {
                Console.WriteLine("Please pick a Choise: \n 1 - one num in Array \n 2 - Amount in Range \n 3 - Exit\n");
                switch ((Console.Read()))
                {
                    case (1):
                        Console.WriteLine("Please guess a number between 0 to 1000\n");
                        CheckGuess(Console.Read());
                        break;
                    case (2):
                        Console.WriteLine("Please guess an amount and a range 0 to 1000\n");
                        int amount = Console.Read();
                        Console.Read();
                        int range1 = Console.Read();
                        Console.Read();
                        int range2 = Console.Read();
                        if (range1 < range2)
                            CheckGuess(amount, range1, range2);
                        else CheckGuess(amount, range2, range1);

                        break;
                    default:
                        stop = true;
                        break;
                }
            }
        }

        private void CheckGuess(int v)
        {
            bool exist = false;
            foreach (int item in arr)
                if (arr[item] == v)
                    exist = true;
            Print(exist);
            return;
        }

        private void CheckGuess(int v1, int v2, int v3)
        {
            int counter = 0;
            foreach (int item in arr)
                if ((arr[item] >= v2) && (arr[item] <= v3))
                    counter++;
            Print((counter == v1) ? true : false);
            return;
        }

        private void Print(bool v)
        {
            Console.WriteLine("you" + (v ? " " : " didn't ") + "guess right" + (v ? " :)\n" : " :(\n"));
        }

    }
}
