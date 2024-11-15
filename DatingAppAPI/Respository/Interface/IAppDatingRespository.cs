using DatingAppAPI.Model;

namespace DatingAppAPI.Respository.Interface
{
    public interface IAppDatingRespository
    {
        public Task<List<AppUser>> GetUsers();
        public Task<AppUser> GetUserById(int id);
    }
}
