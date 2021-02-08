using System;

namespace AIE_20_Needle
{
    class Program
    {
        static void Main(string[] args)
        {
            var strings = new string[] { "hay", "junk", "hay", "hay", "moreJunk", "needle", "randomJunk" };
            var needleLocation = FindNeedle(strings);
            if (needleLocation < 0)
            {
                Console.WriteLine("Did not find Needle");
            }
            else
            {
                Console.WriteLine("Found needle at location: " + needleLocation);
            }

        }
        static int FindNeedle(string[] words)

        {

            for (int a = 0; a < words.Length; a++)
            {
                if (words[a] == "needle")
                {
                    return a;
                }
            }
            return 0;
        }
    }
}
