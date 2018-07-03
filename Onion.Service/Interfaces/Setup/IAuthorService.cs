using Onion.Entity.Setup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onion.Service.Interfaces.Setup
{
    public interface IAuthorService
    {
        List<Author> GetAllAuthors();
        void AddAuthor(Author author);
        Author GetAuthor(long id);
        void UpdateAuthor(Author author);
        List<Author> GetAuthors();
    }
}
