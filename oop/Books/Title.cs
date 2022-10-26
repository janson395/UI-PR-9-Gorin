using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop.Books
{
    public class Title
    {
        private string _title { get; set; }

        public Title(string title)
        {
            _title = title;
        }

        public void set(string title)
        {
            _title = title;
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(_title);
            Console.ResetColor();
        }
    }
}
