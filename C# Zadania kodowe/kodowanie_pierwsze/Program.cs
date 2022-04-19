using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kodowanie_pierwsze
{
    class Program
    {
        static void Main(string[] args)
        {
            // https://www.w3resource.com/csharp-exercises/basic/index.php


            // Zadanie_1();
            // Zadanie_2();
            // Zadanie_3();
            // Zadanie_4();
            // Zadanie_5();
            // Zadanie_6();
            // Zadanie_7();
            // Zadanie_8();
            // Zadanie_9();
            // Zadanie_10();
            // Zadanie_11();
            // Zadanie_12();
            // Zadanie_13();
            // Zadanie_14();
            // Zadanie_15();
            // Zadanie_16();
            // Exercise_17();
            // Exercise_18();
            // Exercise_19();
            // Exercise_20();
            // Exercise_21();
            // Exercise_22();
            // Exercise_23();
            // Exercise_24();
            Exercise_25();



            Console.ReadKey();
        }

        public static void Zadanie_1()
        {
            Console.WriteLine("Hello");
            Console.WriteLine("David Bakalarczyk");
        }

        public static void Zadanie_2()
        {
            int a = 10;
            int b = 5;
            Console.WriteLine(a + b);
        }

        public static void Zadanie_3()
        {
            double a = 10;
            double b = 17;
            Console.WriteLine((double)a/b);
        }

        public static void Zadanie_4()
        {
            Console.WriteLine(-1 + (4 * 6)); // Pierwsze działanie
            Console.WriteLine((35 + 5) % 7); // Drugie działanie
            Console.WriteLine(14 + (-4 * 6 / 11)); // Trzecie działanie
            Console.WriteLine(2+(15/6)*1-(7%2)); // Czwarte działanie
        }

        public static void Zadanie_5()
        {
            int liczba1;
            int liczba2;
            int temp;

            Console.WriteLine("Podaj pierwszą liczbę");
            liczba1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Podaj drugą liczbę");
            liczba2 = int.Parse(Console.ReadLine());

            temp = liczba1;
            liczba1 = liczba2;
            liczba2 = temp;

            Console.WriteLine("Liczba pierwsza:" + liczba1);
            Console.WriteLine("Liczba druga: " + liczba2);

        }

        public static void Zadanie_6()
        {
            int a, b, c;

            Console.WriteLine("Podaj pierwszą liczbę: ");
            a = int.Parse(Console.ReadLine()); // from string to int convert

            Console.WriteLine("Podaj drugą liczbę: ");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("Podaj trzecią liczbę: ");
            c = int.Parse(Console.ReadLine());

            int iloczyn = a * b * c;
            Console.WriteLine("Wynik twojego mnożenia to: " + iloczyn);
        }

        public static void Zadanie_7()
        {
            int liczba1, liczba2;
            int sol_add, sol_sub, sol_mul, sol_div, sol_mod;

            Console.WriteLine("Declarate first number: ");
            liczba1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Declarate second number: ");
            liczba2 = int.Parse(Console.ReadLine());

            sol_add = liczba1 + liczba2;
            sol_sub = liczba1 - liczba2;
            sol_mul = liczba1 * liczba2;
            sol_div = liczba1 / liczba2;
            sol_mod = liczba1 % liczba2;

            Console.WriteLine("Your basic math solutions: ");
            Console.WriteLine("Adding: " + sol_add);
            Console.WriteLine("Substracting: " + sol_sub);
            Console.WriteLine("Multiplying: " + sol_mul);
            Console.WriteLine("Dividing: " + sol_div);
            Console.WriteLine("Modulo: " + sol_mod);
        }

        public static void Zadanie_8()
        {
            Console.WriteLine("Declarate the number to create a multiply table");
            int a = int.Parse(Console.ReadLine());

            for(int i = 0; i < 11; i++)
            {
                Console.WriteLine("{0} + {1} = {2}", a, i, a*i);
            }
        }

        public static void Zadanie_9()
        {
            double a, b, c, d, sum;

            Console.WriteLine("Declarate first number: ");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Declarate second number: ");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Declarate third number: ");
            c = double.Parse(Console.ReadLine());
            Console.WriteLine("Declarate fourth number: ");
            d = double.Parse(Console.ReadLine());

            sum = a + b + c + d;

            Console.WriteLine("The average number of {0}, {1}, {2}, {3}, is:   {4}", a, b, c, d, (sum / 4));
        }

        public static void Zadanie_10()
        {
            int[] num = new int[3];
            Console.WriteLine("Enter three numbers: ");
            for(int i = 0; i < num.Length; i++)
            {
                num[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Your numbers {0} {1} {2} have a specified solution:\n " +
                "(x+y)*z = {3} and\n" +
                "(x*y) + (y*z) = {4}",
                num[0], num[1], num[2], 
                (num[0] + num[1]) * num[2], 
                (num[0] * num[1]) + (num[1] * num[2]));
        }
        
        public static void Zadanie_11()
        {
            Console.WriteLine("Declarate your age: ");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("You look older than {0}", age);
        }

        public static void Zadanie_12()
        {
            Console.WriteLine("Enter your number to multiplycation: ");
            int num = int.Parse(Console.ReadLine());
            
            for(int i = 0; i<2; i++)
            {
                Console.WriteLine("{0} {0} {0} {0}", num);
                Console.WriteLine("{0}{0}{0}{0}", num);
            }
        }
        public static void Zadanie_13()
        {
            Console.WriteLine("Enter your number: ");
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < 1; i++)
            {
                Console.WriteLine("{0}{0}{0}", num);
                for(int j = 0; j < 2; j++)
                {
                    Console.WriteLine("{0} {0}", num);
                }
                Console.WriteLine("{0}{0}{0}", num);
            }
        }

        public static void Zadanie_14()
        {
            double Kelvin = 274.15;

            Console.WriteLine("Enter the Celsius value: ");
            double Celsius = double.Parse(Console.ReadLine());

            Console.WriteLine("The Fahrenheit value is: {0}", Celsius * 1.8 + 32);
            Console.WriteLine("The Kelvin value is: {0}", Kelvin + Celsius);
        }

        public static void Zadanie_15()
        {
            Console.WriteLine("String Before was: w3resource");
            Console.WriteLine("After cleaning string is:" + remove_char("w3resource", 1));
            Console.WriteLine("Or: " + remove_char("w3resource", 9));
            Console.WriteLine("Or finally" + remove_char("w3resource", 3));
        }

        public static string remove_char(string str, int n) // extra method to Zadanie_15();
        {
           return str.Remove(n, 1);
        }


        public static void Zadanie_16()
        {
            string example = "Fenix Aligowski";
            Console.WriteLine("Example: {0} ----> {1}\n", example, first_last(example));
            Console.WriteLine("Declarate your text: ");
            string str = Console.ReadLine();
            Console.WriteLine("Posivite change letters: " + first_last(str));
            
        }

        public static string first_last(string str) //method to exercise 16
        {
            return str.Length > 1 ?  str.Substring(str.Length - 1) + str.Substring(1,str.Length - 2) + str.Substring(0, 1) : str;
        }

        public static void Exercise_17()
        {
            string example = "God Save the Queen!";
            Console.WriteLine("Example: {0} ----> {1}\n", example, double_letters(example));
            Console.WriteLine("Declarate your text: ");
            string str = Console.ReadLine();
            Console.WriteLine("Double letters are: {0}", double_letters(str));
        }

        public static string double_letters(string str) // method to exercise 17
        {
            return str.Length > 1 ? str.Substring(0, 1) + str.Substring(0, str.Length) + str.Substring(0, 1) : str;
        }

        public static void Exercise_18()
        {
            Console.WriteLine("Declarate first Integer");
            double firstInt = double.Parse(Console.ReadLine());
            Console.WriteLine("Declarate second Integer");
            double secondInt = double.Parse(Console.ReadLine());

            if (firstInt > 0 && secondInt < 0)
                Console.WriteLine(true);
            else
                Console.WriteLine(false);
        }

        public static void Exercise_19()
        {
            Console.WriteLine("Declarate first Integer");
            double firstInt = double.Parse(Console.ReadLine());
            Console.WriteLine("Declarate second Integer");
            double secondInt = double.Parse(Console.ReadLine());

            if (firstInt == secondInt)
                Console.WriteLine("It's a tripple sum! This is: {0}", (firstInt + secondInt) * 3);
            else
                Console.WriteLine("Your sum is: {0}", firstInt + secondInt);
        }

        public static void Exercise_20()
        {
            Console.WriteLine("Declarate first number: ");
            double firstNum = double.Parse(Console.ReadLine());
            Console.WriteLine("Declarate second number: ");
            double secondNum = double.Parse(Console.ReadLine());

            if(firstNum < secondNum)
                 Console.WriteLine("The difference between the numbers is: {0}", Math.Abs(firstNum - secondNum));
            else
                Console.WriteLine("First number is greater than second! " +
                    "Then you will get double difference between the numbers: {0}", Math.Abs(firstNum - secondNum)*2);
        }

        public static void Exercise_21()
        {
            Console.WriteLine("Declarate first number: ");
            double firstNum = double.Parse(Console.ReadLine());
            Console.WriteLine("Declarate second number: ");
            double secondNum = double.Parse(Console.ReadLine());
            double sumNum = firstNum + secondNum;

            if (sumNum == 20 || firstNum == 20 || secondNum == 20)
                Console.WriteLine("It has 20 value so this is: " + true);
            else
                Console.WriteLine("The sum of your numbers is: {0}", sumNum);

        }

        public static void Exercise_22()
        {
            Console.WriteLine("Declarate your number: ");
            double num = double.Parse(Console.ReadLine());

            if (Math.Abs(num - 100) <= 20 || Math.Abs(num - 200) <= 20)
                Console.WriteLine(true);
            else
                Console.WriteLine(false);
        }

        public static void Exercise_23()
        {
            Console.WriteLine("Declarate your upper text: ");
            string txt = Console.ReadLine();
            Console.WriteLine("This is your small text:\n{0}", txt.ToLower());
        }

        public static void Exercise_24()
        {
            Console.WriteLine("Declarate your text to find the longest word!");
            string txt = Console.ReadLine();
            int controlNum = 0;
            string word = "";
            string[] words = txt.Split(new[] {" "}, StringSplitOptions.None);

            foreach(String s in words)
            {
                if(s.Length > controlNum)
                {
                    word = s;
                    controlNum = s.Length;
                }
            }
            Console.WriteLine("The longest word is: {0}", word);
        }

        public static void Exercise_25()
        {
            Console.WriteLine("The odd numbers to 100!");
            int x = 0;

            while (x < 100)
            {
                if (x % 2 != 0)
                    Console.WriteLine(x);
                x++;
            }          
        }




    }
}
