using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace library_backend.Models
{
    public class Author
    {
        private int id;
        private string name;
        private List<Book> books;

        public Author()
        {
        }

        public Author(int id, string name, List<Book> books)
        {
            this.id = id;
            this.name = name;
            this.books = books;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public List<Book> Books { get => books; set => books = value; }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}