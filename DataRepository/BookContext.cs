using Microsoft.EntityFrameworkCore;
using MVCapi.Models;

namespace MVCapi.DataRepository{
    public class BookContext:DbContext{
        public BookContext(DbContextOptions<BookContext> opt):base(opt){

        }

        public DbSet<Book> Books { get; set; }
    }
}