using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Blazor.Storage
{
    public interface ILocalStorage
    {
        Task<T> Get<T>(string key);
        Task Set(string key, object value);
        Task Clear();
        Task Remove(string key);
        Task<int> Length { get; }
    }
}
