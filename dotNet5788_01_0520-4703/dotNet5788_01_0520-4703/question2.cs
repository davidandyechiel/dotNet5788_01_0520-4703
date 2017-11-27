using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNet5788_01_0520_4703
{
    class question2
    {
        private int[,] arr;

        public question2()
        {
            arr = new int[5, 5];
        }
        public void play()
        {
            int sum1 = 0;
            int[,] matrix = new int[5, 5];
            Console.WriteLine("enter table");
            for (int i = 0; i < 5; i++)
                for (int j = 0; j < 5; j++)
                    matrix[i, j] = Convert.ToInt32(Console.ReadLine());//recieve all numbers in int form

            for (int i = 0; i < 5; i++)//calculate first row
                sum1 += matrix[i, 0];

            int sum = 0;
            bool flag = true;//create flag to let us know if a row or column doesnt equal the first row
            for (int i = 0; i < 5; i++)
            {
                sum = 0;
                for (int j = 0; j < 5; j++)
                {
                    sum += matrix[i, j];

                }
                if (sum != sum1)
                    flag = false;
            }

            for (int j = 0; j < 5; j++)//calculate columns
            {
                sum = 0;
                for (int i = 0; i < 5; i++)
                {
                    sum += matrix[i, j];

                }
                if (sum != sum1)
                    flag = false;
            }
            sum = 0;
            for (int i = 0, j = 4; i < 5; i++, j--) //calculate diagnals
            {
                sum += matrix[i, j];

            }
            if (sum != sum1)
                flag = false;
            sum = 0;
            for (int i = 0; i < 5; i++) //calculate diagnals
            {


                sum += matrix[i, i];

            }
            if (sum != sum1)
                flag = false;
            if (flag == true)

                Console.WriteLine("congrats its a magical table");
            else
                Console.WriteLine("sorry charlie");
        }
    }
}
