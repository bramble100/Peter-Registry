using Peter_Registry.Controllers;
using System;
using System.Configuration;
using System.Linq;

namespace Peter_Registry
{
    class Program
    {
        static void Main(string[] args)
        {
            var reader = new AppSettingsReader();

            if (!args.Any())
            {
                Console.WriteLine("Help text comes here.");
            }
            else if (string.Equals(args[0].ToLower(), reader.GetValue("ShowFullRegistry", typeof(string))))
            {
                Console.WriteLine(new Controller().ShowAll());
            }
            Console.WriteLine("Press any key to continue ...");
            Console.ReadKey();
        }
    }
}
