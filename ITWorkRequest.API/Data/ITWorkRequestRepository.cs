using System.Threading.Tasks;

namespace ITWorkRequest.API.Data
{
    public class ITWorkRequestRepository : IITWorkRequestRepository
    {
        private readonly DataContext _context;
        public ITWorkRequestRepository(DataContext context)
        {
            _context = context;

        }
        public void Add<T>(T entity) where T : class
        {
            _context.Add(entity);
        }

        public void Delete<T>(T entity) where T : class
        {
           _context.Remove(entity);
        }

        public async Task<bool> SaveAll()
        {
             return await _context.SaveChangesAsync() > 0;
        }
    }
}