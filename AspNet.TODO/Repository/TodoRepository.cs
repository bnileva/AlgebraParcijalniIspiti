using AspNet.TODO.Models;

namespace AspNet.TODO.Repository
{
    public class TodoRepository
    {
        private static List<Todo> _todos;

        public TodoRepository()
        {
           _todos = CreateTasks();
        }

        public List<Todo> CreateTasks()
        {
            var TodoList = new List<Todo>
            {
                new Todo {Id = 1, Task = "Dućan" },
                new Todo {Id = 2, Task = "Šoping", TaskDue = "Saturday"},
                new Todo {Id = 3, Task = "Teretana", TaskDue = "Monday" },
                new Todo {Id = 4, Task = "Parcijalni ispit", TaskDue = "Monday" },
                new Todo {Id = 5, Task = "Dućan", TaskDue = "Thursday" },
            };

            return TodoList;
        }

        public List<Todo> GetTodos()
        {
            return _todos;
        }

    }
}
