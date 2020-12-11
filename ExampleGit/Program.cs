using System;

namespace ExampleGit
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            Console.WriteLine($"{person.name}, ID {person.id} says: Hello World!");
        }
    }
}
