using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04___2_DynamicR
{
    class DynamicRealisationProgram
    {
        static void Main(string[] args)
        {
            DynamicList dL = new DynamicList();

            dL.Add(5);
            dL.Add(65);
            dL.Add("SoftUni");
            dL.Add('%');
            dL.Add(12.57);

            dL.RemoveAt(4);
            dL.Add(-999);

            dL.Remove('%');

            Console.WriteLine(dL.Contains("SoftUni"));
            Console.WriteLine(dL.IndexOf("SoftUni"));
            Console.WriteLine(dL.Contains("Uni"));

            dL[0] = '*';

            Console.WriteLine(dL.Count);
        }
    }
}
