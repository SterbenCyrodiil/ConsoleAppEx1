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


           List<int> numbers = readList();
            /*Console.WriteLine(ToCommaString(even(numbers)));
            Console.WriteLine(ToCommaString(odd(numbers)));
            Console.WriteLine(ToCommaString(firstNumbers(numbers)));
            Console.WriteLine(maxValue(numbers));
            Console.WriteLine(ToCommaString(reverseList(numbers)));
            Console.WriteLine(ToCommaString(orderAsc(numbers))); */
            menu(numbers);
        } 

        public static List<int> readList()
        {
            List<int> numbers = new List<int>();
            int number;
            int i = 0;
            bool used;
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
            Console.WriteLine("Numbers read! Available queries: \n \n"); 
            return numbers; 
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

        public static void menu(List<int> numbers)
        {
            int number;
            bool exit = false;
            do
            {

                Console.WriteLine("Insira a sua opção, qualquer outra além destas sai do programa: \n" +
                    "1 - Pares;\n" +
                    "2 - Ímpares\n" +
                    "3 - Primeiros 3 números\n" +
                    "4 - Maior Valor\n" +
                    "5 - Lista Invertida\n" +
                    "6 - Ordem Ascendente\n");
                while (!int.TryParse(Console.ReadLine(), out number))
                {
                    Console.WriteLine("Write an appropriate number!");
                }
                switch (number)
                {
                    case 1:
                        Console.WriteLine(ToCommaString(even(numbers)));
                        break;
                    case 2:
                        Console.WriteLine(ToCommaString(odd(numbers)));
                        break;
                    case 3:
                        Console.WriteLine(ToCommaString(firstNumbers(numbers)));
                        break;
                    case 4:
                        Console.WriteLine(maxValue(numbers));
                        break;
                    case 5:
                        Console.WriteLine(ToCommaString(reverseList(numbers)));
                        break;
                    case 6:
                        Console.WriteLine(ToCommaString(orderAsc(numbers)));
                        break;
                    default:
                        exit = true;
                        break;
                }
                
                
               
               
                
                



            } while (exit == false);
        }

    }
}
