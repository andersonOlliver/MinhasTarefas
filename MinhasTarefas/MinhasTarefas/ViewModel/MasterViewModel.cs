using MinhasTarefas.Model;
using MinhasTarefas.View;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MinhasTarefas.ViewModel
{
    public class MasterViewModel: BaseViewModel
    {

        public User User { get; set; }

        public ObservableCollection<MasterPageItem> MenuItens { get; }

        public Command<MasterPageItem> ShowCommand { get; }


        public MasterViewModel()
        {
            Title = "Menu";
            User = new User("1", "Olliver", "user.png");
            MenuItens = new ObservableCollection<MasterPageItem>(new[]
            {
                new MasterPageItem("Estatísticas", "icon.png"),
                new MasterPageItem("Calendário", "calendar.png"),
                new MasterPageItem("Configurações", "settings.png", typeof(SettingPage)),
                new MasterPageItem("Sobre", "about.png", typeof(AboutPage))
            });

            ShowCommand = new Command<MasterPageItem>(ExecuteShowCommand);
        }

        async void ExecuteShowCommand(MasterPageItem masterPageItem)
        {
            Page page = Activator.CreateInstance(masterPageItem.TargetType) as Page;
            await App.NavigateMasterDetail(page);
        }
    }
}
