using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students
{
    class Program
    {
 
        static void Main(string[] args)
        {

            Students student1 = new Students
            {
                FirstName = "Andre",
                LastName = "Andersson",
                Age = 266,
                College = "Alberquerque"
            };

            Students student2 = new Students
            {
                FirstName = "Anders",
                LastName = "Matthesen",
                Age = 25,
                College = "MyAss",
            };

            Console.WriteLine(student1.FirstName);
            Console.Write(student1.LastName + " " + student1.College);

        }
    }
}
