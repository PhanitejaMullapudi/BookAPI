using BookAPI.DBRepo;
using BookAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookAPI.BusinessLogic
{
    public class BooksRepository : IBooksRepository
    {
        public bool deleteBook(int id)
        {
            using (var _context = new BookDB())
            {
                var booktodelete = _context.BOOKs.Where(a => a.ID == id).FirstOrDefault();
                _context.BOOKs.Remove(booktodelete);
                _context.SaveChanges();
            }
            return true;
        }

        public BookDTO getBookByID(int id)
        {
            BookDTO book;
            using (var _context = new BookDB())
            {
                var books = _context.BOOKs.Where(a => a.ID == id).ToList();
                book = books.Select(a => new BookDTO()
                {
                    ID = a.ID,
                    Title = a.Title,
                    Author = a.Author
                }).FirstOrDefault();
            }
            return book;
        }

        public IEnumerable<BookDTO> getBooks()
        {
            List<BookDTO> booksDTo;
            using (var _context = new BookDB())
            {
                var books = _context.BOOKs.ToList();
                booksDTo = books.Select(a => new BookDTO()
                {
                    ID = a.ID,
                    Title = a.Title,
                    Author = a.Author
                }).ToList();
            }
            return booksDTo;
        }

        public bool putBook(BookDTO obj)
        {
            BOOK bok = getBookFromDTO(obj);

            using (var _context = new BookDB())
            {
                var books = _context.BOOKs.Add(bok);
                _context.SaveChanges();
            }
            return true;
        }

        private BOOK getBookFromDTO(BookDTO obj)
        {
            return new BOOK()
            {
                ID = obj.ID,
                Author = obj.Author,
                Title = obj.Title
            };
        }
    }
}