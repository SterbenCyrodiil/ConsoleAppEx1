using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleAppEx1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int total = 0;
            Console.WriteLine("How many numers do you wish to add?");
            try
            {
                do
                {
                    total = Int32.Parse(Console.ReadLine());
                } while (total <= 0);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Insira um número inteiro\n" + ex); ;
            }

            int[] numberArr = new int[total];

            for (int i = 0; i < total; i++)
            {
                try
                {
                    Console.WriteLine("Insira o número "+(i+1));
                    numberArr[i] = Int32.Parse(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Insira um número inteiro\n" + ex); ;
                }
            } */

            List<int> numbers = new List<int>();
            int number = 0;
            int i = 0;
            bool used = false;
            do
            {
                used = true;
                i++;
                Console.WriteLine("Iteração" + i + "; Insira o número (para sair coloque número inteiro negativo ou 0");
                while (!int.TryParse(Console.ReadLine(), out number))
                {
                    Console.WriteLine("You entered an invalid number");
                    used = false; 
                }               
                numbers.Add(number);
            } while (number > 0 || used == false);

           Console.WriteLine(ToCommaString(even(numbers)));
           Console.WriteLine(ToCommaString(odd(numbers)));
           Console.WriteLine(ToCommaString(firstNumbers(numbers)));
           Console.WriteLine(maxValue(numbers));
           Console.WriteLine(ToCommaString(reverseList(numbers)));
           Console.WriteLine(ToCommaString(orderAsc(numbers))); 

        } 

        public static List<int> even(List<int> list)
        {
            List<int> evenNumbers = list.Where(i => i % 2 == 0).ToList();
            return evenNumbers; 
        }

        public static List<int> odd(List<int> list)
        {
            List<int> oddNumbers = list.Where(i => i % 2 != 0).ToList();
            return oddNumbers;
        }
        public static List<int> firstNumbers(List<int> list)
        {
            List<int> numbers = list.Take<int>(3).ToList();
            return numbers;
        }

        public static int maxValue(List<int> list)
        {
            int number = list.Max();
            return number; 
        }

        public static List<int> reverseList(List<int> list)
        {
            List<int> numbers = list;
            numbers.Reverse();
            return numbers; 
        }

        public static List<int> orderAsc(List<int> list)
        {
            List<int> oddNumbers = list.OrderBy(i => i).ToList();
            return oddNumbers;
        }

        public static string ToCommaString(List<int> list)
        {
            if (list.Count <= 0)
                return ("");
            if (list.Count == 1)
                return (list[0].ToString());
            System.Text.StringBuilder sb = new System.Text.StringBuilder(list[0].ToString());
            for (int x = 1; x < list.Count; x++)
                sb.Append("," + list[x].ToString());
            return (sb.ToString());
        }

    }
}
