
using MinhasTarefas.Model;
using Xamarin.Forms;

namespace MinhasTarefas.ViewModel
{
    public class PerfilViewModel : BaseViewModel
    {

        public User User { get; set; }

        public PerfilViewModel()
        {
            Title = "Perfil";
            User = new User("1", "Olliver", "user.png");
        }
    }
}
