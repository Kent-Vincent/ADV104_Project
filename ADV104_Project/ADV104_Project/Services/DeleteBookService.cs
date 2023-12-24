// DeleteBookService.cs
using ADV104_Project.Data;
using ADV104_Project.Entities;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace ADV104_Project.Services
{
    public class DeleteBookService
    {
        private readonly DataContext _dataContext;

        public DeleteBookService(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<bool> ConfirmDeleteBook(int bookId)
        {
            // Retrieve the book by ID
            var book = await _dataContext.Books.FirstOrDefaultAsync(b => b.ID == bookId);

            if (book == null)
            {
                return false;
            }

            // You can implement additional logic here to show a confirmation dialog
            // For simplicity, we're assuming the deletion is confirmed

            // Delete the book
            _dataContext.Books.Remove(book);
            await _dataContext.SaveChangesAsync();

            // Deletion successful
            return true;
        }
    }
}
