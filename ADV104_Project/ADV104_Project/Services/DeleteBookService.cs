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
            var book = await _dataContext.Books.FirstOrDefaultAsync(b => b.ID == bookId);

            if (book == null)
            {
                return false;
            }

            _dataContext.Books.Remove(book);
            await _dataContext.SaveChangesAsync();
            return true;
        }
    }
}
