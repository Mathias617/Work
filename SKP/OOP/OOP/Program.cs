using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Bil nybil = new Bil { Mærke = "Honda", KM = 234234.32};

            Console.WriteLine("Her er en " + nybil.Mærke + " Og den har " + nybil.LiterBenzin);
            Console.ReadLine();


            
            
            


        }
    }
}
