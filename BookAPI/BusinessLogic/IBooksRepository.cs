using BookAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookAPI.BusinessLogic
{
    interface IBooksRepository
    {
        IEnumerable<BookDTO> getBooks();
        BookDTO getBookByID(int id);
        bool deleteBook(int id);
        bool putBook(BookDTO obj);
    }
}
