using System;
using System.Collections.Generic;
using System.Text;

namespace Store
{
    public class BookService
    {
        private readonly IBookRepoository bookRepoository;
        public BookService(IBookRepoository bookRepoository)
        {
            this.bookRepoository = bookRepoository;
        }
        public Book[] GetAllByQuery(string query)
        {
            if (Book.IsIsbn(query))
            {
                return bookRepoository.GetAllByIsbn(query);
            }

            return bookRepoository.GetAllByTitleOrAuthor(query);
        }
    }
}
