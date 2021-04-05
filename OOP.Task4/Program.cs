using System;
using System.Text.RegularExpressions;

namespace OOP.Task4
{
    class Program
    {
        static string Inputt { get; set; }

           Program()
           {
               Inputt = Program.InputAndValidation();
           }
        static bool IsPalindrome(string s)
        {
            int i = 0, j = s.Length - 1;
            while (i < j)
            {
                if (char.ToLower(s[i++]) != char.ToLower(s[j--])) return false;
            }
            return true;
        }

        static string InputAndValidation()
        {
            Regex regex = new Regex("^[ -/:-@[-`|{-}0-9]");


            while (true)
            {

                Console.WriteLine("Введите слово");

                Inputt = Console.ReadLine();

                MatchCollection matches = regex.Matches(Inputt);

                if (matches.Count > 0)
                {
                    Console.WriteLine("Ввод спец символов и цифр запрещен!");
                }
                else
                {
                    Inputt.ToCharArray();

                    char temp = Inputt[0];
                    int count = 0;


                    for (int i = 0; i < Inputt.Length - 1; i++)
                    {
                        if (Inputt[i + 1] == temp)
                        {
                            count++;
                        }
                    }

                    if (Inputt.Length < 3)
                    {
                        Console.WriteLine("Введите слово состоящее из трех и более букв");
                    }
                    else if (count != Inputt.Length - 1)
                    {
                        if (IsPalindrome(Inputt) == true)
                        {
                            Console.WriteLine("Это полиндром");
                        }
                        else
                        {
                            Console.WriteLine("Это не полиндром");
                        }

                        break;
                    }
                    else
                    {
                        Console.WriteLine("Слово не может состоять из одинаковых букв");
                    }
                }
            }
            return Inputt;
        }

        static void Main(string[] args)
        {
             Program obj = new Program();
        }


    }
}

    



