using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    /// <summary>
    /// Реализация с европейсикм форматом (с британским)
    /// </summary>
    internal class EuroDateTime : IDateTime
    {
        public string GetDateTime()
        {
            CultureInfo uk = new CultureInfo("en-GB");
            return DateTime.Now.ToString(uk);
        }

        public void PrintDateTime()
        {
            Console.WriteLine(GetDateTime());
        }
    }
}
