using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Onion.DAL.Interfaces.Base;
using Onion.Entity.Setup;
using Onion.Service.Interfaces.Setup;

namespace Onion.Service.Implements.Setup
{
    public class BookService:IBookService
    {
        private IRepository<Book> bookRepository;

        public BookService(IRepository<Book> bookRepository)
        {
            this.bookRepository = bookRepository;
        }

        public List<Book> GetAllBooks()
        {
            return bookRepository.GetQueryable().Include(b => b.Author).ToList();
        }

        public void AddBook(Book book)
        {
            bookRepository.Insert(book);
        }

        public Book GetBook(long id)
        {
            return bookRepository.Get(id);
        }

        public void UpdateBook(Book book)
        {
            bookRepository.Update(book);
        }

        public void DeleteBook(Book book)
        {
            bookRepository.Delete(book);
        }
    }
}
