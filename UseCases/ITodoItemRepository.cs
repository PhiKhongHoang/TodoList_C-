using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace UseCases
{
    public interface ITodoItemRepository
    {
        void Add(TodoItem item);
        void Remove(int id);
        IEnumerable<TodoItem> GetItems();
        TodoItem? GetById(int id);
        void Update(TodoItem item);
    }
}
