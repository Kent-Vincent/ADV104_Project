using System.Collections.Generic;
using System.Linq;
using ADV104_Project.Data;
using ADV104_Project.Entities;

namespace ADV104_Project.Services
{
    public class FetchBookService
    {
        private readonly DataContext dataContext;

        public FetchBookService(DataContext context)
        {
            dataContext = context;
        }

        public List<Book> GetAllBooks()
        {
            return dataContext.Books.ToList();
        }

        public Book GetBookById(int id)
        {
            return dataContext.Books.FirstOrDefault(book => book.ID == id);
        }
    }
}
