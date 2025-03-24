using Entities;
using Infratructure;
using UseCases;

namespace TestProject
{
    public class UnitTest1
    {
        [Fact]
        public void CreateTodoItem_And_Set_Complete_Test()
        {
            var mockRepository = new InMemoryTodoItemRepository();
            var todoListManager = new TodoListManager(mockRepository);  

            var todoItem = new TodoItem { Id = 1, Text = "Test" };

            todoListManager.Add(todoItem);
            todoListManager.Update(1);

            Assert.True(todoListManager.GetTodoItems().First().IsComplete);
            Assert.Equal("Test", todoListManager.GetTodoItems().First().Text);

        }
    }
}