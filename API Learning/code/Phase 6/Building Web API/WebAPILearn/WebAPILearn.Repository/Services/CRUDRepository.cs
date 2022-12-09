using Microsoft.EntityFrameworkCore;
using WebAPILearn.Models.Data;

namespace WebAPILearn.Repositories.Services
{
    public class CRUDRepository<T> : ICRUDRepository<T> where T : class
    {
        private readonly ProductDbContext _productDbContext;
        private readonly DbSet<T> _entity;

        public string Message { get; set; } = string.Empty;

        public CRUDRepository(ProductDbContext productDbContext)
        {
            _productDbContext = productDbContext;
            _entity = _productDbContext.Set<T>();
        }

        #region GetALLAsync
        public async Task<IEnumerable<T>> GetAllAsync()
        {
            try
            {
                List<T> entities = await _entity.ToListAsync();
                if (entities.Count == 0)
                {
                    Message = "No records found";
                }
                return entities;
            }
            catch (Exception ex)
            {
                Message = ex.Message;
                return Enumerable.Empty<T>();
            }
        }
        #endregion

        #region GetByIdAsync
        public async Task<T> GetByIdAsync(int id)
        {
            try
            {
                T entity = await _entity.FindAsync(id);
                if (entity == null)
                {
                    Message = "Record not found";
                }
                return entity;
            }
            catch (Exception ex)
            {
                Message = ex.Message;
                return null;
            }
        }
        #endregion

        #region InsertAsync
        public async Task<bool> InsertAsync(T entity)
        {
            try
            {
                if (entity == null)
                {
                    Message = "Entity is empty";
                    return false;
                }
                await _entity.AddAsync(entity);
                await _productDbContext.SaveChangesAsync();
                Message = "Record added successfully";
                return true;
            }
            catch (Exception ex)
            {
                Message = ex.Message;
                return false;
            }
        }
        #endregion

        #region InsertRangeAsync
        public async Task<bool> InsertRangeAsync(List<T> entities)
        {
            try
            {
                if (entities.Count == 0)
                {
                    Message = "No record in list";
                    return false;
                }
                await _entity.AddRangeAsync(entities);
                await _productDbContext.SaveChangesAsync();
                Message = "All records added successfully";
                return true;
            }
            catch (Exception ex)
            {
                Message = ex.Message;
                return false;
            }
        }
        #endregion

        #region UpdateAsync
        public async Task<bool> UpdateAsync(int id, T entity)
        {
            try
            {
                if (entity == null)
                {
                    Message = "Entity is empty";
                    return false;
                }
                T oldEntity = await _entity.FindAsync(id);
                if (oldEntity == null)
                {
                    Message = "Record not found";
                    return false;
                }
                _entity.Entry(oldEntity).State = EntityState.Detached; // Here we detached oldStock instance So application dosn't ganarate "The instance of entity type cannot be tracked because another instance with the same key value for {'Id'} is already being tracked" exception.
                                                                       // 
                _entity.Update(entity);
                await _productDbContext.SaveChangesAsync();
                Message = "Record updated successfully";
                return true;
            }
            catch (Exception ex)
            {
                Message = ex.Message;
                return false;
            }
        }
        #endregion

        #region DeleteAsync
        public async Task<bool> DeleteAsync(int id)
        {
            try
            {
                T entity = await _entity.FindAsync(id);
                if (entity == null)
                {
                    Message = "Record not found";
                    return false;
                }
                _entity.Remove(entity);
                await _productDbContext.SaveChangesAsync();
                Message = "Recorde deleted suceessfully";
                return true;
            }
            catch (Exception ex)
            {
                Message = ex.Message;
                return false;
            }
        }
        #endregion
    }
}
