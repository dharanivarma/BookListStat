using BookListStat.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookListStat.repository
{
     public interface IBookRepository
    {
        IEnumerable<Book> GetAll();
        Book GetById(int Book_id);

    }
}
