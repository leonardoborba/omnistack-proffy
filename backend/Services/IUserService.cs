using System.Collections.Generic;
using System.Threading.Tasks;
using backend.Models;

namespace backend.Services
{
    public interface IUserService
    {
        Task<IEnumerable<User>> Get();
        Task Create(User user);
    }
}