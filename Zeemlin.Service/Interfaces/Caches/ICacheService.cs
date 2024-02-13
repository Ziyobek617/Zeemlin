namespace Zeemlin.Service.Interfaces.Caches;

public interface ICacheService
{
    Task<T> GetAsync<T>(string key, Func<Task<T>> getData);
    Task SetAsync<T>(string key, T value, TimeSpan expiration);
}
