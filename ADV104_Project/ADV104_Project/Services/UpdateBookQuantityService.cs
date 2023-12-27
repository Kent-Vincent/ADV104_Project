
using System.Threading.Tasks;
using ADV104_Project.Data;
using ADV104_Project.Entities;
using Microsoft.EntityFrameworkCore;

namespace ADV104_Project.Services
{
    public class UpdateBookQuantityService
    {
        private readonly DataContext dataContext;

        public UpdateBookQuantityService(DataContext context)
        {
            dataContext = context;
        }

        public async Task UpdateBookQuantityAsync(string bookTitle, string bookGenre, int quantityToAdd)
        {
            var book = await dataContext.Books
                .FirstOrDefaultAsync(b => b.Title == bookTitle && b.Description == bookGenre);

            if (book != null)
            {
                book.Quantity += quantityToAdd;
                await dataContext.SaveChangesAsync();
            }
            // You may want to handle the case where the book with the specified title and genre is not found.
        }
    }
}
