using System;

namespace TutoringWithHemory
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //problem #1
            Console.WriteLine("Problem #1");
            Console.Write("Enter your name: ");
            Console.WriteLine($"Hello: {Console.ReadLine()}");
            Console.WriteLine();

            //problem #2
            Console.WriteLine("Problem #2");
            Console.Write("enter a number: ");
            int num01 = Convert.ToInt32(Console.ReadLine());
            Console.Write("enter another number: ");
            int num02 = Convert.ToInt32(Console.ReadLine()); 
            Console.WriteLine($"The sum of: {num01} + {num02} is: " + (num01 + num02));
            Console.WriteLine();

            //problem #3
            Console.WriteLine("Problem #3");
            Console.Write("enter a number: ");
            int num03 = Convert.ToInt32(Console.ReadLine());
            Console.Write("enter another number: ");
            int num04 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"The quotient of: {num03} / {num04} is: " + (num03 / num04));
            Console.WriteLine();

            //problem #4 (hard coded as per example)
            Console.WriteLine("Problem #4");
            Console.Write("-1 + 4 * 6 = ");
            int num05 = -1;
            int num06 = 4;
            int num07 = 6;
            Console.WriteLine(num05 + (num06 * num07));
            Console.Write("(35 + 5) % 7) = ");
            int num09 = 35;
            int num10 = 5;
            int num11 = 7;
            Console.WriteLine((num09 + num10) % num11);
            Console.Write("14 + -4 * 6 / 11 = ");
            int num12 = 14;
            int num13 = -4;
            int num14 = 6;
            int num15 = 11;
            Console.WriteLine(num12 + num13 * num14 / num15);
            Console.Write("2 + 15 / 6 * 1 - 7 % 2 = ");
            int num16 = 2;
            int num17 = 15;
            int num18 = 6;
            int num19 = 1;
            int num20 = 7;
            int num21 = 2;
            Console.WriteLine(num16 + num17 / num18 * num19 - num20 % num21);
            Console.WriteLine();

            //problem #5
            Console.WriteLine("Problem #5");
            Console.Write("enter a number: ");
            int num22 = Convert.ToInt32(Console.ReadLine());
            Console.Write("enter a different number: ");
            int num23 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(num22);
            Console.WriteLine(num23);
            Console.WriteLine("Let's swap the order.");
            int num00 = num22;
            num22 = num23;
            num23 = num00;
            Console.WriteLine(num22);
            Console.WriteLine(num23);
            Console.WriteLine();

            //problem #6
            Console.WriteLine("Problem #6");
            Console.Write("enter a number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("enter a number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("enter a number: ");
            int num3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{num1} * {num2} * {num3} = " + num1 * num2 * num3);
            Console.WriteLine();

            //problem #7 example uses 25 & 4
            Console.WriteLine("Problem #7");
            Console.Write("Enter a number: ");
            int num24 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter another number: ");
            int num25 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{num24} + {num25} = " + (num24 + num25));
            Console.WriteLine($"{num24} - {num25} = " + (num24 - num25));
            Console.WriteLine($"{num24} * {num25} = " + (num24 * num25));
            Console.WriteLine($"{num24} / {num25} = " + (num24 / num25));
            Console.WriteLine($"{num24} % {num25} = " + (num24 % num25));
            Console.WriteLine();

            //problem #8
            Console.WriteLine("Problem #8");
            Console.Write("Enter a number: ");
            int num26 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{num26} *  0 = " + (num26 * 0));
            Console.WriteLine($"{num26} *  1 = " + (num26 * 1));
            Console.WriteLine($"{num26} *  2 = " + (num26 * 2));
            Console.WriteLine($"{num26} *  3 = " + (num26 * 3));
            Console.WriteLine($"{num26} *  4 = " + (num26 * 4));
            Console.WriteLine($"{num26} *  5 = " + (num26 * 5));
            Console.WriteLine($"{num26} *  6 = " + (num26 * 6));
            Console.WriteLine($"{num26} *  7 = " + (num26 * 7));
            Console.WriteLine($"{num26} *  8 = " + (num26 * 8));
            Console.WriteLine($"{num26} *  9 = " + (num26 * 9));
            Console.WriteLine($"{num26} * 10 = " + (num26 * 10));
            Console.WriteLine();

            //problem #9
            Console.WriteLine("Problem #9");
            Console.Write("enter a number: ");
            int num27 = Convert.ToInt32(Console.ReadLine());
            Console.Write("enter a number: ");
            int num28 = Convert.ToInt32(Console.ReadLine());
            Console.Write("enter a number: ");
            int num29 = Convert.ToInt32(Console.ReadLine());
            Console.Write("enter a number: ");
            int num30 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"The average of {num27},{num28},{num29} & {num30} is: " + (num27 + num28 + num29 + num30) / 4);
            Console.WriteLine();

            //problem #10 (example uses 5, 6, 7)
            Console.WriteLine("Problem #10");
            Console.Write("enter a number: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("enter a number: ");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.Write("enter a number: ");
            int z = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{x} + {y} * {z} = " + (x + y) * z);
            Console.WriteLine($"{x} * {y} + {y} * {z} = " + (x * y + y * z));
            Console.WriteLine();
           
            //problem #11
            Console.Write("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"No way you are {age}, you look amazing!");
            Console.WriteLine();
             
            //problem #12 ... why does {0} work here?
            Console.Write("enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.Write(num);
            Console.Write(" ");
            Console.Write(num);
            Console.Write(" ");
            Console.Write(num);
            Console.Write(" ");
            Console.Write(num);
            Console.WriteLine();

            Console.Write(num);
            Console.Write(num);
            Console.Write(num);
            Console.Write(num);
            Console.WriteLine();

            Console.WriteLine("{0} {0} {0} {0}", num);

            Console.WriteLine("{0}{0}{0}{0}", num);
            Console.WriteLine();
            
            //problem #13
            Console.Write("enter a number: ");
            int nums = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0}{0}{0}", nums);
            Console.WriteLine("{0} {0}", nums);
            Console.WriteLine("{0} {0}", nums);
            Console.WriteLine("{0} {0}", nums);
            Console.WriteLine("{0}{0}{0}", nums);
            Console.WriteLine();
            
            //problem #14
            Console.Write("Enter a temperature in celsius: ");
            int temp = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{temp} degrees celsius is " + (1.8 * temp + 32) + " degrees fahrenheit.");
            Console.WriteLine($"{temp} degrees celsius is " + (+273.15) + " degrees kelvin.");
            Console.WriteLine();
            
            //problem #15 WHAT??!!! is this a key value pair thing?




        }
    }
}
