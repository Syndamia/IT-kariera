using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04___1_StaticRe
{
    class StaticRealizationProgram
    {
        static void Main(string[] args)
        {
            CustomArrayList cal = new CustomArrayList();

            cal.Add(5);
            cal.Add(-29);
            cal.Add(3.14);
            cal.Add("SoftUni");
            cal.Add('b');
            cal.Add("^");

            cal.Insert(2, 2.71);
            cal.Insert(5, "Nice");

            Console.WriteLine(cal.IndexOf('b'));

            Console.WriteLine(cal.Contains("Nice"));
            Console.WriteLine(cal.Contains("C#"));

            Console.WriteLine(cal[3]);

            Console.WriteLine(cal.RemoveAt(4));
            Console.WriteLine(cal.Remove(-29));

            cal.Clear();
        }
    }
}
