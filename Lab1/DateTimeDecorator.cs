using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    /// <summary>
    /// Класс декоратор который добавляет в начало и конец формата даты и времени произвольное количество произвольных символов
    /// </summary>
    internal class DateTimeDecorator : IDateTime
    {
        public IDateTime DateTime { get; set; }
        public char FirstChar { get; set; }
        public int FirstCharCol { get; set; }
        public char SecondChar { get; set; }
        public int SecondCharCol { get; set; }

        public DateTimeDecorator(IDateTime dateTime, char fCahr, int fCahrCol, char sChar, int sCahrCol)
        {
            DateTime = dateTime;
            FirstChar = fCahr;
            FirstCharCol = fCahrCol;
            SecondChar = sChar;
            SecondCharCol = sCahrCol;
        }

        public string GetDateTime()
        {
            var now = DateTime.GetDateTime();
            StringBuilder sb = new StringBuilder();
            for(int i = 0; i < FirstCharCol; i++)
                sb.Append(FirstChar);
            sb.Append(DateTime.GetDateTime());
            for(int i = 0; i < SecondCharCol; i++)
                sb.Append(SecondChar);
            return sb.ToString();
        }

        public void PrintDateTime()
        {
            Console.WriteLine(GetDateTime());
        }
    }
}
