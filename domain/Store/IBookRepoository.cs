using System;
using System.Collections.Generic;
using System.Text;

namespace Store
{
    public interface IBookRepoository
    {
        Book[] GetAllByTitle(string titlePart);
    }
}
