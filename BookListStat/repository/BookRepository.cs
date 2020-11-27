using BookListStat.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookListStat.repository
{
    public class BookRepository : IBookRepository
    {
        private List<Book> books;

        public BookRepository()
        {
            books = new List<Book>()
            {
                new Book { Book_id = 1, Book_Name= "Science" ,Cost = 100 },
                new Book { Book_id = 2, Book_Name= "Social" ,Cost = 150 },
                new Book { Book_id = 3, Book_Name= "English" ,Cost = 200 },
                new Book { Book_id = 4, Book_Name= "Biology" ,Cost = 250 },
                new Book { Book_id = 5, Book_Name= "Maths" ,Cost = 300 },
                new Book { Book_id = 6, Book_Name= "check" ,Cost = 10000 },
            };

        }



        public IEnumerable<Book> GetAll()
        {
            var booklist = books.ToList();
            return booklist;
           
        }
        public Book GetById(int Book_id)
        {
            return books.FirstOrDefault(b => b.Book_id == Book_id);
        }

    

       

    }
}
