using ADV104_Project.Data;
using ADV104_Project.Entities;
using System.Threading.Tasks;

namespace ADV104_Project.Services
{
    public class AddBookService
    {
        private readonly DataContext _context;

        public AddBookService(DataContext context)
        {
            _context = context;
        }

        public async Task AddBookAsync(Book newBook)
        {
            _context.Books.Add(newBook);

            await _context.SaveChangesAsync();
        }
    }
}