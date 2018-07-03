using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Onion.Entity.Setup;

namespace Onion.Service.Interfaces.Setup
{
    public interface IBookService
    {
        void AddBook(Book book);
        List<Book> GetAllBooks();
        Book GetBook(long id);
        void UpdateBook(Book book);
        void DeleteBook(Book book);
    }
}
