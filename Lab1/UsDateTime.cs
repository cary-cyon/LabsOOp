using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    /// <summary>
    /// Реализация с американсикм форматом
    /// </summary>
    internal class UsDateTime : IDateTime
    {
        public string GetDateTime()
        {
            return DateTime.Now.ToString(new CultureInfo("en-Us"));
        }

        public void PrintDateTime()
        {
            Console.WriteLine(GetDateTime());
        }
    }
}
