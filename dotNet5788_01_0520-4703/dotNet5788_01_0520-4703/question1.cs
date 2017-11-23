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
        const int PARAM = 3; // the number of the parameters in case 3

        public question1() // set the array with 100 randome numbers.
        {
            arr = new int[100];
            for (int i = 0; i < 100; i++)
                arr[i] = Program.rand.Next(0, 1001);
        }

        public void play() // calles from the main
        {
            bool stop = false;
            while (!stop)
            {
                Console.WriteLine("Please pick a Choise: \n 1 - one num in Array \n 2 - Amount in Range \n 3 - Exit\n");
                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case (1):

                        GuessOneNumber();

                        break;
                    case (2):
                        Console.WriteLine("Please guess an amount and a range 0 to 1000\n");
                        int[] input = getNumbers();

                        CheckGuess(input[0], min(input[1], input[2]), max(input[1], input[2]));
                        break;
                    default:
                        stop = true;
                        break;
                }
            }
        }

        private int min(int v1, int v2) // return the min of two given #.
        {
            return (v1 < v2 ? v1 : v2);
        }
        private int max(int v1, int v2) // return the max of two given #.
        {
            return (v1 > v2 ? v1 : v2);
        }

        private int[] getNumbers() // sets int array from string array
        {
            int[] arr = new int[PARAM];
            string[] str = setString(); // set a string array (length =3) with the input numbers splitted.
            foreach (int j in arr)
                arr[j] = Convert.ToInt32(str[j]);
            return arr;
        }

        private static string[] setString() // sets string array from the user  // needs a final check
        {
            char[] ommitChars = { ',', '-', '.', ' ', '\t' };
            string[] str = new string[PARAM];
            string temp;
            int i = 0;
            while (i != PARAM)
            {
                temp = Console.ReadLine();
                combine(ref i,ref str, temp.Split(ommitChars));
            }
            return str;
        }

        private static void combine(ref int i,ref string[] str, string[] v)
        {
            for (int j = 0; j < v.Length; j++)
                if (i < PARAM)
                    str[i++] = v[j];
        }

        private void GuessOneNumber()
        {
            Console.WriteLine("Please guess a number between 0 to 1000\n (enter 1001 to end)");
            int num = Convert.ToInt32(Console.ReadLine());
            while ((num >= 0 && num <= 1000))
            {
                bool exist = false;
                for (int i = 0; i < arr.Length; i++)
                    if (arr[i] == num)
                        exist = true;
                Print(exist);
                Console.WriteLine("Please guess a number between 0 to 1000\n (enter 1001 to end)");
                num = Convert.ToInt32(Console.ReadLine());
            }
            return;

        }

        private void CheckGuess(int v1, int v2, int v3)
        {
            int counter = 0;
            for (int item = 0; item < arr.Length; item++)
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
