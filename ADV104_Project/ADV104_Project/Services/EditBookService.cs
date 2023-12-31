﻿using ADV104_Project.Data;
using ADV104_Project.Entities;
using System.Linq;

namespace ADV104_Project.Services
{
    public class EditBookService
    {
        private readonly DataContext dataContext;

        public EditBookService(DataContext context)
        {
            dataContext = context;
        }

        public Book GetBookById(int id)
        {
            return dataContext.Books.FirstOrDefault(book => book.ID == id);
        }

        public void UpdateBook(Book updatedBook)
        {
            var existingBook = dataContext.Books.FirstOrDefault(book => book.ID == updatedBook.ID);

            if (existingBook != null)
            {
                existingBook.Title = updatedBook.Title;
                existingBook.Author = updatedBook.Author;
                existingBook.Description = updatedBook.Description;
                existingBook.Quantity = updatedBook.Quantity;

                // Save changes to the database
                dataContext.SaveChanges();
            }
            // Handle the case where the book with the specified ID is not found
            // You might want to throw an exception or handle it based on your requirements
        }
    }
}
