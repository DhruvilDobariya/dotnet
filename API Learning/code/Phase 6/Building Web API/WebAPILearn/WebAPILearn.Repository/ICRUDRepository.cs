namespace WebAPILearn.Repositories
{
    public interface ICRUDRepository<T> where T : class
    {
        string Message { get; set; }
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetByIdAsync(int id);
        Task<bool> InsertAsync(T entity);
        Task<bool> InsertRangeAsync(List<T> entities);
        Task<bool> UpdateAsync(T entity);
        Task<bool> DeleteAsync(int id);

    }
}