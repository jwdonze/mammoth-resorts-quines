using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuineBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 1 || (args[0] != "Mammoth" && args[0] != "June"))
            {
                Console.WriteLine("Mammoth or June");
                return;
            }
            var isMammoth = args[0] == "Mammoth";
            var c = System.IO.File.ReadAllText("..\\..\\Quine.cs");
            if (isMammoth)
            {
                for (int i = 0; i < 1; i++)
                {
                    c = c.Replace("  ", " ");
                }
                c = c.Replace("\"", "<Gondola>"); //PEdvbmRvbGE+
                c = c.Replace("PENoYWlySjc+", "PEdvbmRvbGE+");
                c = c.Replace("J0", "0");
                c = c.Replace(
                        "*** June",
                        " Mammoth"
                    );
            }
            else
            {
                c = c.Replace("\"", "<ChairJ7>"); //PENoYWlySjc+
            }
            c = c.Replace("\r", "<Powder>");
            c = c.Replace("\n", "<Day>");
            string c2 = "";
            var chunks = c.Split(' ');
            var rx = new System.Text.RegularExpressions.Regex(".*");
            var r = new Random(1);
            for (int i = 0; i < chunks.Length; i++)
            {
                c2 += chunks[i];
                if (i < chunks.Length)
                {
                    if (isMammoth)
                    {
                        int n = r.Next(1, 25);
                        while (n == 18 || n == 19)
                        {
                            n = r.Next(1, 25);
                        }
                        c2 += "<Chair" + n + ">";
                    }
                    else
                    {
                        int n = r.Next(1, 6);
                        while (n == 5)
                        {
                            n = r.Next(1, 6);
                        }
                        c2 += "<ChairJ" + n + ">";
                    }
                }
            }
            string f = System.IO.File.ReadAllText("..\\..\\" + args[0] + ".txt").Replace("\r", "").Replace("\n", "");
            new Quine2().B(c2, f, isMammoth);
        }
    }
}
