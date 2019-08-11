using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encryption
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Insert Data To Encrypt:");
            var val = Console.ReadLine();
            var enc = Encryption.Encrypt(val,true);
            Console.WriteLine($"Encrypted: {enc}");
          
        }
    }
}
