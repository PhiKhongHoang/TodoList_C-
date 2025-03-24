using System.ComponentModel.DataAnnotations;

namespace TodoList.Models
{
    public class Item
    {
        public int Id { get; set; }

        [Required]
        public string Text  { get; set; }
        public bool IsComplete { get; set; }
    }
}
