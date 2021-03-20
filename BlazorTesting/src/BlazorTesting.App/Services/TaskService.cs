using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorTesting.App.Services
{
    public class TaskService : ITaskService
    {
        private List<string> items = new();

        public Task AddNewItemAsync(string newItemText)
        {
            items.Add(newItemText);
            return Task.CompletedTask;
        }

        public Task<List<string>> LoadItemsAsync() => Task.FromResult(items);
    }
}
