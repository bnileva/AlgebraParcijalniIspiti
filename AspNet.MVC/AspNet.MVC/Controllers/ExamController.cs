using AspNet.MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspNet.MVC.Controllers
{
    public class ExamController : Controller
    {
        public IActionResult Exam()
        {
            var autori = new List<Author>()
            {
                new Author() { Name = "J.K.", Surname = "Rowling", BirthYear = 1965 },
                new Author() { Name = "George R.R.", Surname = "Martin", BirthYear = 1948 },
                new Author() { Name = "J.R.R.", Surname = "Tolkien", BirthYear = 1892 }
            };

            var knjige = new List<Book>()
            {
                new Book() { Author = autori[0], Title = "Harry Potter and the Sorcerer's Stone", PublishYear = "1997"},
                new Book() { Author = autori[1], Title = "Game of Thrones", PublishYear = "1996" },
                new Book() { Author = autori[2], Title = "The Lord of the Rings", PublishYear = "1954" },
                new Book() { Author = autori[0], Title = "Harry Potter and the Chamber of Secrets", PublishYear = "1998" },
                new Book() { Author = autori[2], Title = "The Hobbit", PublishYear = "1937" }
            };

            return View(knjige);
        }
    }
}
