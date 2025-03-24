using Entities;
using UseCases;

namespace Infratructure
{
    public class InMemoryTodoItemRepository : ITodoItemRepository
    {
        private readonly List<TodoItem> _items;

        public InMemoryTodoItemRepository()
        {
            _items = new List<TodoItem>();
        }

        public void Add(TodoItem item)
        {
            _items.Add(item);
        }

        public void Remove(int id)
        {
            var item = _items.FirstOrDefault(x => x.Id == id);
            if (item != null)
            {
                _items.Remove(item);
            }
        }

        public TodoItem? GetById(int id)
        {
            return _items.FirstOrDefault(_x => _x.Id == id);
        }

        public IEnumerable<TodoItem> GetItems()
        {
            return _items;
        }

        public void Update(TodoItem item)
        {
            var existingItem = _items.FirstOrDefault(item => item.Id == item.Id);
            if (existingItem != null)
            {
                existingItem.Text = item.Text;
                existingItem.IsComplete = item.IsComplete;
            }
        }
    }
}
