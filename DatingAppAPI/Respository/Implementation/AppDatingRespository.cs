using DatingAppAPI.Data;
using DatingAppAPI.Model;
using DatingAppAPI.Respository.Interface;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;

namespace DatingAppAPI.Respository.Implementation
{
    public class AppDatingRespository: IAppDatingRespository
    {
        private readonly DataContext _context;

        public AppDatingRespository(DataContext context)
        {
            this._context = context;
        }

        public async Task<List<AppUser>> GetUsers()
        {
            var users = await _context.Users.ToListAsync();
            return users;
        }

        public async Task<AppUser> GetUserById(int id)
        {
            var user = await _context.Users.FindAsync(id);
            return user;
        }
    }
}
