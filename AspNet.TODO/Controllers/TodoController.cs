using AspNet.TODO.Repository;
using Microsoft.AspNetCore.Mvc;

namespace AspNet.TODO.Controllers
{
    public class TodoController : Controller
    {
        private readonly TodoRepository _repository;

        public TodoController(TodoRepository repository)
        {
            _repository = repository;
        }

        public IActionResult Index()
        {
            return View(_repository.GetTodos());
        }
    }
}
