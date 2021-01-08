using library_backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;


namespace library_backend.Controllers
{
    [RoutePrefix("api/author")]
    public class AuthorController : ApiController
    {
        // GET: api/Author
        public Author Get()
        {
            Book book1 = new Book(1, "Libro1", true, new DateTime(2020, 08, 25));
            Book book2 = new Book(1, "Libro2", false, new DateTime(2020, 10, 20));
            Author author = new Author(1, "Author1", new List<Book>() { book1, book2 });
            return author;
        }

        // GET: api/Author/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Author
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Author/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Author/5
        public void Delete(int id)
        {
        }
    }
}
