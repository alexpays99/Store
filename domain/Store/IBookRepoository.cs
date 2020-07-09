using System;
using System.Collections.Generic;
using System.Text;

namespace Store
{
    interface IBookRepoository
    {
        Book[] GetAllByTitle(string titlePart);
    }
}
