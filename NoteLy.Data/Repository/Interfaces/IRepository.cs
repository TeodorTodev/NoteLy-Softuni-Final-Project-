namespace NoteLy.Data.Repository.Interfaces
{
    public interface IRepository<TType, TId>
    {
        TType GetById(TId id);

        Task<TType> GetByIdAsync(TId id);

        IEnumerable<TType> GetAll();

        Task<IEnumerable<TType>> GetAllAsync();

        IQueryable<TType> GetAllAttached();

        void Add(TType item);

        Task AddAsync(TType item);

        bool Delete(TId id);

        Task<bool> DeleteAsync(TId id);

        Task DeleteRangeAsync(IEnumerable<TType> items);

        bool Update(TType item);

        Task<bool> UpdateAsync(TType item);
    }
}
