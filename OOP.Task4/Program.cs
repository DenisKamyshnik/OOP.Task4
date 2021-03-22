using System;
using System.Text.RegularExpressions;

namespace OOP.Task4
{
    class Program
    {
        static string Input { get; set; }

           Program()
           {
               Input = Program.InputAndValidation();
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

                Input = Console.ReadLine();

                MatchCollection matches = regex.Matches(Input);

                if (matches.Count > 0)
                {
                    Console.WriteLine("Ввод спец символов и цифр запрещен!");
                }
                else
                {
                    Input.ToCharArray();

                    char temp = Input[0];
                    int counter = 0;


                    for (int i = 0; i < Input.Length - 1; i++)
                    {
                        if (Input[i + 1] == temp)
                        {
                            counter++;
                        }
                    }

                    if (Input.Length < 3)
                    {
                        Console.WriteLine("Введите слово состоящее из трех и более букв");
                    }
                    else if (counter != Input.Length - 1)
                    {
                        if (IsPalindrome(Input) == true)
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
            return Input;
        }

        static void Main(string[] args)
        {
             Program obj = new Program();
        }


    }
}

    



