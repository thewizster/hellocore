using System;

namespace hellocore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Looking up Google.com...");
            var addresses = System.Net.Dns.GetHostEntry("google.com").AddressList;
            Console.WriteLine("The following addresses were found:");
            foreach (var item in addresses)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine($"Local Host Name: {System.Net.Dns.GetHostName()}");
            Console.ReadLine();
        }
    }
}
