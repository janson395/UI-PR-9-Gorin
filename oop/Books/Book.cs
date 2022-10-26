using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop.Books
{
    public class Book
    {
        private Title _title { get; set; }
        private Author _author { get; set; }
        private Content _content { get; set; }

        public Book(string title, string author, string content)
        {
            _title = new Title(title);
            _author = new Author(author);
            _content = new Content(content);
        }

        public void setTitle(string title)
        {
            _title.set(title);
        }
        public void setAuthor(string author)
        {
            _author.set(author);
        }
        public void setContent(string content)
        {
            _content.set(content);
        }

        public void showTitle()
        {
            _title.Show();
        }

        public void showAuthor()
        {
            _author.Show();
        }

        public void showContent()
        {
            _content.Show();
        }

        public void showAll()
        {
            showTitle();
            showAuthor();
            showContent();
        }
    }
}
