﻿using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Onion.Entity.Setup;

namespace Onion.Entity.EntityMapping
{
    public class BookMap
    {
        public BookMap(EntityTypeBuilder<Book> entityBuilder)
        {
            entityBuilder.HasKey(t => t.Id);
            entityBuilder.Property(t => t.Name).IsRequired();
            entityBuilder.Property(t => t.ISBN).IsRequired();
            entityBuilder.Property(t => t.Publisher).IsRequired();
            entityBuilder.HasOne(e => e.Author).WithMany(e => e.Books).HasForeignKey(e => e.AuthorId);
        }
    }
}
