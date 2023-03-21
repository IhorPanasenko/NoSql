using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IBookRepository
    {
        public Book Create(Book book);
        public Task<List<Book>> GetAllAsync();
        public Task<Book> GetByIdAsync(string bookId);
        public void Delete(string bookId);

        public void Update (string bookId, Book book);
    }
}
