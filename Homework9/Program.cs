using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.IO;

namespace HomeWork
{
    class RegexHomeWork
    {
        static void Main(string[] args)
        {
            static void RegexMethod()
            {
                var PhoneBook = new string[]
                {
                "Рик Граймс 300897115072",
                "Уолтер Уайт 3507906510",
                "Джесси Пинкман 34840280260",
                "Джон Баратеон 342997232249",
                "Джон Сноу 3456500459",
                "Арья Старк 37754688978"
                };

                int str1;
                List<string> str2 = new List<string>();
                Console.WriteLine("Enter name or phone number to search:");

                string Matches = Console.ReadLine();
                Regex regex = new Regex(Matches);

                foreach (var contact in PhoneBook)
                {
                    MatchCollection MatchesCollection = regex.Matches(contact);
                    str1 = MatchesCollection.Count;
                    if (MatchesCollection.Count > 0)
                    {
                        str2.Add(contact);
                    }
                }
                if (str2.Count > 0)
                {
                    Console.WriteLine("Search Result:");
                    foreach (var person in str2)
                    {
                        Console.WriteLine(person);
                    }
                }
                else
                {
                    Console.WriteLine("Sorry, nothing is matches :(");
                }
            }
            try
            {
                RegexMethod();
            }
            catch (Exception WrongInput)
            {
                Console.WriteLine($"Error: {WrongInput.Message}");
                Console.WriteLine("You can use A-Z, a-z, 0-9");
                Console.WriteLine("Try again...");
                RegexMethod();
            }
        }
    }
}