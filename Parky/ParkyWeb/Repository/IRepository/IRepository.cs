namespace ParkyWeb.Repository.IRepository
{
    public interface IRepository<T> where T : class
    {
        Task<T> GetAsync(string url, int id, string Token);
        Task<IEnumerable<T>> GetAllAsync(string url, string Token);
        Task<bool> CreateAsync(string url, T obj, string Token);
        Task<bool> UpdateAsync(string url, T obj, string Token);
        Task<bool> DeleteAsync(string url, int Id, string Token);
    }
}
