using System.ComponentModel.DataAnnotations;

namespace TodoList.Models
{
    public class TodoListViewModel
    {

        [Required]
        public IEnumerable<Item> items {  get; init; }
    }
}
