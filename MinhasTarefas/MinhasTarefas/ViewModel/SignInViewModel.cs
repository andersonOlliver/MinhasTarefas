using MinhasTarefas.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhasTarefas.ViewModel
{
    public class SignInViewModel : BaseViewModel
    {

        public string Username { get; set; }

        public string Password { get; set; }

        public User User { get; set; }

        public SignInViewModel()
        {
            Title = "Entrar";
        }
    }
}
