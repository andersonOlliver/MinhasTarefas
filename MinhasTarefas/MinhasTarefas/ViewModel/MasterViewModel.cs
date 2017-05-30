using MinhasTarefas.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhasTarefas.ViewModel
{
    public class MasterViewModel: BaseViewModel
    {

        public User User { get; set; }

        public MasterViewModel()
        {
            Title = "Master";
            User = new User("1", "Olliver", "user.png");
        }
    }
}
