using System.Collections.Generic;
using MVCapi.Models;

namespace MVCapi.DataRepository{
    public interface IBookRepo{
        IEnumerable<Book> GetAllBooks();
        Book GetBookById(int id);
         
    }
}