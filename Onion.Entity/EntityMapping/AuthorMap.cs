using Onion.Entity.Setup;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Onion.Entity.EntityMapping
{
    public class AuthorMap
    {
        public AuthorMap(EntityTypeBuilder<Author> entityBuilder)
        {
            entityBuilder.HasKey(t => t.Id);
            entityBuilder.Property(t => t.FirstName).IsRequired();
            entityBuilder.Property(t => t.LastName).IsRequired();
            entityBuilder.Property(t => t.Email).IsRequired();
        }
    }
}
