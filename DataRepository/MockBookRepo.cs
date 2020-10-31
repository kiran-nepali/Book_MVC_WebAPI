using System.Collections.Generic;
using MVCapi.Models;

namespace MVCapi.DataRepository{
    public class MockBookRepo : IBookRepo
    {
        public IEnumerable<Book> GetAllBooks()
        {
            var books = new List<Book>{
                new Book{Id=1,Title="Don Quixote",Writer="Miguel de Cervantes"},
                new Book{Id=2,Title="Lord of the Rings",Writer="J.R.R. Tolkien"},
                new Book{Id=3,Title="Harry Potter and the Sorcerer's Stone",Writer="J.K. Rowling"}                
            };
            return books;
        }

        public Book GetBookById(int id)
        {
            return new Book{Id=1,Title="Don Quixote",Writer="Miguel de Cervantes"};
        }
    }
}