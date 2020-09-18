using BookAPI.BusinessLogic;
using BookAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BookAPI.Controllers
{
    public class BookController : ApiController
    {
        // GET api/values
        /// <summary>
        /// Get Books
        /// </summary>
        /// <returns></returns>
        public IEnumerable<BookDTO> Get()
        {
            var _bookRepo = new BooksRepository();
            return _bookRepo.getBooks();
        }

        // GET api/values/5

        /// <summary>
        /// getByID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>

        public BookDTO Get(int id)
        {
            var _bookRepo = new BooksRepository();
            return _bookRepo.getBookByID(id);
        }

        // POST api/values
        /// <summary>
        /// Post Book
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public bool Post(BookDTO obj)
        {
            var _bookRepo = new BooksRepository();
            var issuccess = _bookRepo.putBook(obj);
            return issuccess;
        }

        /// <summary>
        /// Delete Book
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>

        // DELETE api/values/5
        public bool Delete(int id)
        {
            var _bookRepo = new BooksRepository();
            var issuccess = _bookRepo.deleteBook(id);
            return issuccess;
        }
    }
}
