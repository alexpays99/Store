using System;
using System.Linq;

namespace Store.Memory
{
    public class BookRepository : IBookRepoository
    {
        private readonly Book[] books = new[]
        {
            new Book(1, "ISBN 12312-31231", "D. Knuth", "Art of Programming", 
                     "The bible of all fundamental algorithms and the work that taught many of today's software developers most of what they know about computer programming.",
                     7.19m),
            new Book(2, "ISBN 12312-31232", "M. Fowler", "Refactoring", 
                     "For more than twenty years, experienced programmers worldwide have relied on Martin Fowler’s Refactoring to improve the design of existing code and to enhance software maintainability, as well as to make existing code easier to understand.", 
                     12.45m),
            new Book(3, "ISBN 12312-31231", "B. Kernighan, D. Ritchie", 
                     "C Programming Language", "The authors present the complete guide to ANSI standard C language programming. Written by the developers of C, this new version helps readers keep up with the finalized ANSI standard for C while showing how to take advantage of C's rich set of operators, economy of expression, improved control flow, and data structures.",
                     14.98m)
        };

        public Book[] GetAllByIsbn(string isbn)
        {
            return books.Where(book => book.Isbn == isbn)
                        .ToArray();
        }

        public Book[] GetAllByTitleOrAuthor(string query)
        {
            return books.Where(book => book.Author.Contains(query) 
                                    || book.Title.Contains(query))
                        .ToArray();
        }

        public Book GetById(int id)
        {
            return books.Single(book => book.Id == id);
        }
    }
}
