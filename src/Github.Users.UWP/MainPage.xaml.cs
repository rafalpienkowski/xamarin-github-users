using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;
using Github.Users.Common.ViewModels;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Github.Users.UWP
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private readonly UsersViewModel _usersViewModel = new UsersViewModel();

        public MainPage()
        {
            this.InitializeComponent();
        }

        protected async override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            await _usersViewModel.RetrieveUsers();
        }
    }
}
