using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HvaGjørKoden
{
    internal class Class1
    {
        public void RarKode()
        {
            var range = 250;
            var counts = new int[range];
            string text = "something";
            while (!string.IsNullOrWhiteSpace(text))
            {
                text = Console.ReadLine();
                foreach (var character in text ?? string.Empty)
                {
                    counts[(int)character]++;
                }
                for (var i = 0; i < range; i++)
                {
                    if (counts[i] > 0)
                    {
                        var character = (char)i;
                        Console.WriteLine(character + " - " + counts[i]);
                    }
                }
            }
        }
    }
}
// den teller antall tall av hvert enkelttall du skriver i consol 