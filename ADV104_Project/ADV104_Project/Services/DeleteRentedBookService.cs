using System.Threading.Tasks;
using ADV104_Project.Data;
using ADV104_Project.Entities;
using Microsoft.EntityFrameworkCore;

namespace ADV104_Project.Services
{
    public class DeleteRentedBookService
    {
        private readonly DataContext dataContext;

        public DeleteRentedBookService(DataContext context)
        {
            dataContext = context;
        }

        public async Task DeleteRentedBookAsync(RentBook rentedBook)
        {
            dataContext.RentBooks.Remove(rentedBook);
            await dataContext.SaveChangesAsync();
        }
    }
}