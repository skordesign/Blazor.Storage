using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Blazor.Storage
{
    public interface ILocalStorage
    {
        ValueTask<T> Get<T>(string key);
        ValueTask<string> Set (string key, object value);
        ValueTask<object> Clear ();
        ValueTask<object> Remove (string key);
        ValueTask<int> Length { get; }
    }
}
