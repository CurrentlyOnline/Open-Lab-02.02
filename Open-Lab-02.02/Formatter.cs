using System;

namespace Open_Lab_02._02
{
    public class Formatter
    {
        public void Format(double[] numbers)
        {
            var output = "";
            foreach (var number in numbers)
            {
                var rounded = Math.Round(number, 2).ToString().Replace(',', '.');
                output += rounded + " ";
            }
            var vysledok = output.Remove(output.LastIndexOf(" "));
            Console.Write(vysledok);
        }
    }
}
