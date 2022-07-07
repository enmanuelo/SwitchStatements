using System;

namespace SelectionStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite school subject?");
            var favSubject = Console.ReadLine().ToLower();

            switch (favSubject)
            {
                case "english":
                    Console.WriteLine("English is boring.");
                    break;
                case "math":
                    Console.WriteLine("Math is essential!");
                    break;
                case "science":
                    Console.WriteLine("Science is everywhere!");
                    break;
                case "social studies":
                    Console.WriteLine("Social Studies is alright.");
                    break;
                case "art":
                    Console.WriteLine("Art is creative!");
                    break;
                default:
                    Console.WriteLine("Hmm.. I don't recognize that subject.");
                    break;
            }
        }
    }
}
