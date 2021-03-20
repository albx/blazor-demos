using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorTesting.App.Services
{
    public interface ITaskService
    {
        Task<List<string>> LoadItemsAsync();

        Task AddNewItemAsync(string newItemText);
    }
}
