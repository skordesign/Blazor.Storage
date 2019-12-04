using Microsoft.JSInterop;
using System;
using System.Threading.Tasks;

namespace Blazor.Storage
{
    public class LocalStorage : ILocalStorage
    {
        private readonly IJSRuntime _jSRuntime;
        public LocalStorage(IJSRuntime jSRuntime)
        {
            if (jSRuntime == null)
                throw new JSException("Null jsRuntime");
            _jSRuntime = jSRuntime;
        }
        public Task<int> Length => _jSRuntime.InvokeAsync<int>("skorStorage.length");

        public Task Clear()
        {
            return _jSRuntime.InvokeAsync<object>("skorStorage.clear");
        }

        public async Task<T> Get<T>(string key)
        {
            Console.WriteLine("Get " +
            _jSRuntime.GetType().Name);
            return await _jSRuntime.InvokeAsync<T>("skorStorage.get", key);
        }

        public Task Remove(string key)
        {
            return _jSRuntime.InvokeAsync<object>("skorStorage.remove", key);
        }

        public Task Set(string key, object value)
        {
            return _jSRuntime.InvokeAsync<string>("skorStorage.set", key, value);
        }
    }
}
