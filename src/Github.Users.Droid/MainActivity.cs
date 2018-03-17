using System.Threading.Tasks;
using Android.App;
using Android.Widget;
using Android.OS;
using Github.Users.Common.ViewModels;

namespace Github.Users.Droid
{
    [Activity(Label = "Github.Users.Droid", MainLauncher = true, Icon = "@mipmap/icon")]
    public class MainActivity : ListActivity
    {
        int count = 1;

        protected async override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            ListAdapter = await CreateUsersListAdapater();
        }

        private async Task<UsersListAdapater> CreateUsersListAdapater()
        {
            var usersViewModel = new UsersViewModel();
            await usersViewModel.RetrieveUsers();

            return new UsersListAdapater(this, usersViewModel.Users);
        }
    }
}

