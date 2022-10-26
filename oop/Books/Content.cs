using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop.Books
{
    public class Content
    {
        private string _content { get; set; }

        public Content(string content)
        {
            _content = content;
        }

        public void set(string content)
        {
            _content = content;
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(_content);
            Console.ResetColor();
        }
    }
}
