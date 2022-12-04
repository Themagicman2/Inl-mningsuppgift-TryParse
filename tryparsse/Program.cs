using System;

namespace tryparsse
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] values = { null, "23145", "24155.6", "21,425",
                          "-244", "+46423", "(167);", "231FA" };
            foreach (string value in values)
            {
                int nummer;

                bool funkar = int.TryParse(value, out nummer);
                if (funkar)
                {
                    Console.WriteLine($"Converted '{value}' to {nummer}.");
                }
                else
                {
                    Console.WriteLine($"Attempted conversion of '{value ?? "<null>"}' failed.");
                }
            }
        }
    }
}
