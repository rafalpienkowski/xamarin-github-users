using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Github.Users.Common.Concrete;
using Github.Users.Common.Contracts;
using Github.Users.Common.Models;

namespace Github.Users.Common.ViewModels
{
    public class UsersViewModel
    {
        public ObservableCollection<User> Users { get; private set; } = new ObservableCollection<User>();

        private readonly IUsersRepository _usersRepository = new UsersRepository();

        public async Task RetrieveUsers()
        {
            var users = await _usersRepository.GetAllAsync();
            Users.Clear();

            foreach (var user in users)
            {
                Users.Add(user);
            }
        }

    }
}
