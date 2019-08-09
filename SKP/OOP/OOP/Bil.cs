using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Bil
    {
        public string Mærke { get; internal set; }
        public double KM { get; internal set; }
        public string LiterBenzin { get; set; }
        
        public class BilBenzin
        {
            public double LiterBenzin = 22.5;
            public string Mærke = "Honda";
            public double KM;
           
            
        }
    }
}
