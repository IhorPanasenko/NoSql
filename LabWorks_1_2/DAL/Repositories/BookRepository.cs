using Core;
using Core.Models;
using DAL.Interfaces;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class BookRepository : IBookRepository
    {
        private readonly IMongoCollection<Book> books;
        public BookRepository(ILibraryDatabaseSettings settings, IMongoClient mongoClient)
        {
            var database = mongoClient.GetDatabase(settings.DatabaseName);
            books = database.GetCollection<Book>(settings.BooksCollectionName);
        }
        public Book Create(Book book)
        {
            books.InsertOne(book);
            return book;
        }

        public void Delete(string bookId)
        {
            books.DeleteOne(b=> b.Id == bookId);
        }

        public async Task<List<Book>> GetAllAsync()
        {
            return await books.Find(b=>true).ToListAsync();
        }

        public async Task<Book> GetByIdAsync(string bookId)
        {
            return  await books.Find(b => true).FirstOrDefaultAsync();
        }

        public void Update(string bookId, Book book)
        {
            books.ReplaceOneAsync(b=>b.Id == bookId, book);
        }
    }
}
