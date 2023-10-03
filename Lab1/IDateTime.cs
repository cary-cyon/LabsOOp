using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    /// <summary>
    /// интерфейс с операциями печати и создлания строки даты времени опр.формата
    /// </summary>
    internal interface IDateTime
    {
        void PrintDateTime();
        string GetDateTime();

    }
}
