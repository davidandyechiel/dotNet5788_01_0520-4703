using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNet5788_01_0520_4703
{
    class question2
    {
        public void play()
        {
            int sum1 = 0;
            int[,] matrix = new int[5, 5];
            Console.WriteLine("enter table");
            for (int i = 0; i < 5; i++)
                for (int j = 0; j < 5; j++)
                    matrix[i, j] = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < 5; i++)//calculate first row
                sum1 += matrix[i, 0];

            int sum = 0;
            bool flag = true;
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


            for (int i = 0, j = 4; i < 5; i++, j--) //calculate diagnals
            {
                sum = 0;
                // for (int j = 0; j < 5; j++)
                {
                    sum += matrix[i, j];

                }
                if (sum != sum1)
                    flag = false;
            }
            for (int i = 0; i < 5; i++,) //calculate diagnals
            {
                sum = 0;
                // for (int j = 0; j < 5; j++)
                {
                    sum += matrix[i, i];

                }
                if (sum != sum1)
                    flag = false;
            }
            if (flag == true)
                Console.WriteLine("congrats its a magical table");
            else
                Console.WriteLine("sorry");
        }
    }
}
