using System;
using System.Collections.Generic;
using System.Text;

namespace Store
{
    public interface IBookRepoository
    {
        Book[] GetAllByIsbn(string isbn);

        Book[] GetAllByTitleOrAuthor(string titleOrAuthor);
    }
}
