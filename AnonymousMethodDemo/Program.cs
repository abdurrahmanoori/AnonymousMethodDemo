using System;

namespace AnonymousMethodDemo
{
    public delegate void GreetingDel(string name);
    class Program
    {
        static void Main(string[] args)
        {
            GreetingDel GreetingDel = delegate (string name)
            {
                Console.Write("Hello " + name);
            };

            GreetingDel.Invoke("Maryam");
            //this is some chaged.
        }
    }
}
