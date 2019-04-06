# SkorBlazor.Storage
Simple localStorage for Blazor
# Get started
#### 1.Install Nuget package or clone and build this project.
Nuget: [SkorBlazor.Storage](https://www.nuget.org/packages/SkorBlazor.Storage/)

#### 2.Add `LocalStorage` service on `Startup.cs`
```csharp
public void ConfigureServices(IServiceCollection services)
{
    ...
    services.AddLocalStorage();
    ...
}
```
#### 3. Inject to `*.cshtml` files and use it :)
Sample:
```csharp

@inject SkorBlazor.Storage.ILocalStorage LocalStorage;
@functions{
    [Parameter]
    string ProjectUid { get; set; }
    async void AddModel()
    {
        LocalStorage.Set("Key","Value");
    }
}
```

# Supported
```csharp
public interface ILocalStorage
{
    Task<T> Get<T>(string key);
    Task Set(string key, object value);
    Task Clear();
    Task Remove(string key);
    Task<int> Length { get; }
}
```
##### Note: If you need more method for this package, feel free to create issue on this repository.