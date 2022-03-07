using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetotOverloading
{
    
    internal class Program
    {
        public static int Toplam(int a, int b, out int toplam)
        {
            toplam = a + b;
            return toplam;
        }
        static void Main(string[] args)
        {
            Toplam(4, 8, out int toplam);
            Console.WriteLine(toplam);

            
        }
    }
}
