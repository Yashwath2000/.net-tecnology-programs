using System;

namespace frequency
{
    class FrequencyIS
    {
        static void Main(string[] args)
        {
            int count = 0;
            string inputstring;
            Console.WriteLine("\n ---frequency of word 'is'---");
            Console.Write("\n enter tht input string:");
            inputstring = Console.ReadLine();
            char[] separator = { ',', ' ', '.', '!', '\n' };
            string teststring = inputstring.ToLower();
            String[] outcomes = teststring.Split(separator);
            foreach(String s in outcomes)
            {
                Console.WriteLine(s);
                if (s == "is")
                    count++;
            }
            Console.WriteLine("\n number of 'is' in " + inputstring + " is:" + count);
        }
    }
}
        