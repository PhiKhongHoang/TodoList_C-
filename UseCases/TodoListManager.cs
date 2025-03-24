using Entities;

namespace UseCases
{
    public class TodoListManager
    {
        private readonly ITodoItemRepository repository;

        public TodoListManager(ITodoItemRepository repository)
        {
            this.repository = repository;
        }

        public IEnumerable<TodoItem> GetTodoItems()
        {
            return repository.GetItems();
        }

        public void Add(TodoItem item)
        {

            repository.Add(item);
        }

        public void Update(int id)
        {
            var item = repository.GetById(id);
            if (item != null)
            {
                item.IsComplete = true;
                repository.Update(item);
            }
        }

        public void Remove(int id)
        {
            repository.Remove(id);
        }

    }
}
