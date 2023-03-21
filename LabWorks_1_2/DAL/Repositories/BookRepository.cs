using Core.Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class BookRepository : IBookRepository
    {
        public Book Create(Book book)
        {
            throw new NotImplementedException();
        }

        public void Delete(string bookId)
        {
            throw new NotImplementedException();
        }

        public List<Book> GetAll()
        {
            throw new NotImplementedException();
        }

        public Book GetById(string bookId)
        {
            throw new NotImplementedException();
        }

        public void Update(string bookId, Book book)
        {
            throw new NotImplementedException();
        }
    }
}
