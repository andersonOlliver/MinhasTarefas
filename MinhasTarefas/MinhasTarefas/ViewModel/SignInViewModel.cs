using MinhasTarefas.Helpers;
using MinhasTarefas.Model;
using MinhasTarefas.Service;
using MinhasTarefas.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace MinhasTarefas.ViewModel
{
    public class SignInViewModel : BaseViewModel
    {

        public string Username { get; set; }
        public string Password { get; set; }

        public User User { get; set; }

        private readonly AzureService _azureService;
        INavigation navigation;

        ICommand loginCommand;
        public ICommand LoginSocialCommand =>
            loginCommand ?? (loginCommand = new Command(async () => await ExecuteLoginSocialCommandAsync()));


        public SignInViewModel()
        {
            Title = "Entrar";

            _azureService = DependencyService.Get<AzureService>();
            navigation = App.MasterDetail.Detail.Navigation;
        }

        async Task ExecuteLoginSocialCommandAsync()
        {
            if(!(await LoginAsync()))
            {
                return;
            }
            else
            {
                RemovePageFromStack();
                App.MasterDetail.Master.BindingContext = new MasterViewModel();
            }
            
        }

        private void RemovePageFromStack()
        {
            var existingPages = navigation.NavigationStack.ToList();
            foreach(var page in existingPages)
            {
                if (page.GetType() == typeof(SignInPage))
                    navigation.RemovePage(page);
            }
        }

        public Task<bool> LoginAsync()
        {
            if (Settings.IsLoggedIn)
                return Task.FromResult(true);

            return _azureService.LoginAsync();
        }
    }
}
