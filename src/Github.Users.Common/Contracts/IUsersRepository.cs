using System.Collections.Generic;
using System.Threading.Tasks;
using Github.Users.Common.Models;

namespace Github.Users.Common.Contracts
{
    public interface IUsersRepository
    {
        Task<IEnumerable<User>> GetAllAsync();
    }
}