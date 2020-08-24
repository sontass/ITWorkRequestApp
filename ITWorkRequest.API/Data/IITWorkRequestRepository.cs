using System.Threading.Tasks;

namespace ITWorkRequest.API.Data
{
    public interface IITWorkRequestRepository
    {
        void Add<T>(T entity)  where T: class;
        void Delete<T>(T entity) where T: class;
        Task<bool> SaveAll();
        //Task<IEnumerable<User>> GetUsers();
        // Task<PagedList<User>> GetUsers(UserParams userParams);
        // Task<User> GetUser(int id);
        // Task<Photo> GetPhoto(int id);
        // Task<Photo> GetMainPhotoForUser(int userId);
        // Task<Like> GetLike(int userId , int recipientId);
    }
}