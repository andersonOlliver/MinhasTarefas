using MinhasTarefas.Helpers;
using MinhasTarefas.Model;
using MinhasTarefas.View;
using System;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace MinhasTarefas.ViewModel
{
    public class MasterViewModel: BaseViewModel
    {

        private User _user;
        public User User
        { get { return _user; }
            set
            {
                SetProperty(ref _user, value);
            }
        }

        public ObservableCollection<MasterPageItem> MenuItens { get; }

        public Command<MasterPageItem> ShowCommand { get; }


        public MasterViewModel()
        {
            Title = "Menu";
            User = new User(
                Settings.UserId, 
                Settings.UserName, 
                Settings.UserProfile,
                Settings.UserCover
                );
            if (!Settings.IsLoggedIn)
            {
                MenuItens = new ObservableCollection<MasterPageItem>(new[]
                {
                    new MasterPageItem("Entrar", "login.png", typeof(SignInPage)),
                    new MasterPageItem("Nova Tarefa", "plus.png", typeof(AddJobPage)),
                    new MasterPageItem("Calendário", "calendar.png", typeof(CalendarPage)),
                    new MasterPageItem("Configurações", "settings.png", typeof(SettingPage)),
                    new MasterPageItem("Sobre", "about.png", typeof(AboutPage))
                });
            }
            else
            {
                MenuItens = new ObservableCollection<MasterPageItem>(new[]
               {
                    new MasterPageItem("Nova Tarefa", "plus.png", typeof(AddJobPage)),
                    new MasterPageItem("Calendário", "calendar.png", typeof(CalendarPage)),
                    new MasterPageItem("Configurações", "settings.png", typeof(SettingPage)),
                    new MasterPageItem("Sobre", "about.png", typeof(AboutPage)),
                    new MasterPageItem("Sair", "logout.png", typeof(SignInPage))
                });
            }
            

            ShowCommand = new Command<MasterPageItem>(ExecuteShowCommand);
        }

        async void ExecuteShowCommand(MasterPageItem masterPageItem)
        {
            Page page = Activator.CreateInstance(masterPageItem.TargetType) as Page;
            await App.NavigateMasterDetail(page);
        }
    }
}
