using System.Collections.Generic;
using System.Linq;
using ADV104_Project.Data;
using ADV104_Project.Entities;

namespace ADV104_Project.Services
{
    public class FetchRentedBookService
    {
        private readonly DataContext dataContext;

        public FetchRentedBookService(DataContext context)
        {
            dataContext = context;
        }

        public List<RentBook> GetAllRentedBooks()
        {
            return dataContext.RentBooks.ToList();
        }
    }
}
