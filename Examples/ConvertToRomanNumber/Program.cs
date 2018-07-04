using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertToRomanNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var v = ReadFromKeyboards();
            Console.WriteLine(ConvertToRoman(v));
            Console.ReadLine();
        }
        static string ConvertToRoman(int n)
        {
            var array = ConvertToDigits(n);
            var result = ConvertThousands(array[0]) + ConvertToHundreds(array[1]) + ConvertTens(array[2]) + ConvertToUnits(array[3]);
            return result;
        }
        static int ReadFromKeyboards()
        {
            Console.WriteLine(" Input number between 0 and 3888: ");
            int number = int.Parse(Console.ReadLine());
            while (number < 0 || number > 3888)
            {
                Console.WriteLine("Number outside interval. Write a number between 0 and 3888: ");
                number = int.Parse(Console.ReadLine());
            }
            return number;
        }
        static int[] ConvertToDigits(int a)
        {
            int[] x = new int[4];
            for (int i = 3; i >= 0; i--)
            {
                x[i] = a % 10;
                a = a / 10;
            }
            return x;
        }

        static String ConvertThousands(int a)
        {
            string x = "";
            switch (a)
            {
                case 1:
                    x = x + "M";
                    break;
                case 2:
                    x = x + "MM";
                    break;
                case 3:
                    x = x + "MMM";
                    break;
                default:
                    break;
            }
            return x;
        }
        static string ConvertToHundreds(int hundredsdigit)
        {
            string result = "";
            switch (hundredsdigit)
            {
                case 0:
                    result = "";
                    break;
                case 1:
                    result = "C";
                    break;
                case 2:
                    result = "CC";
                    break;
                case 3:
                    result = "CCC";
                    break;
                case 4:
                    result = "CD";
                    break;
                case 5:
                    result = "D";
                    break;
                case 6:
                    result = "DC";
                    break;
                case 7:
                    result = "DCC";
                    break;
                case 8:
                    result = "DCCC";
                    break;
                case 9:
                    result = "CM";
                    break;
            }
            return result;
        }
        static String ConvertTens(int a)
        {
            string x = "";
            switch (a)
            {
                case 1:
                    x = x + "I";
                    break;

                case 2:
                    x = x + "II";
                    break;

                case 3:
                    x = x + "III";
                    break;

                case 4:
                    x = x + "IV";
                    break;

                case 5:
                    x = x + "V";
                    break;

                case 6:
                    x = x + "VI";
                    break;

                case 7:
                    x = x + "VII";
                    break;

                case 8:
                    x = x + "VIII";
                    break;

                case 9:
                    x = x + "IX";
                    break;


                default:
                    break;

            }
            return x;
        }
        static string ConvertToUnits(int i)
        {
            var v = new string[] { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };
            return v[i];
        }
    }
}
