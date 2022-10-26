using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop.Books
{
    public class Author
    {
        private string _author { get; set; }

        public Author(string author)
        {
            _author = author;
        }

        public void set(string author)
        {
            _author = author;
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(_author);
            Console.ResetColor();
        }
    }
}
