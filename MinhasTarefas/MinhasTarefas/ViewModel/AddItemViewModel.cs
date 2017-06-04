using MinhasTarefas.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MinhasTarefas.ViewModel
{
    public class AddItemViewModel : BaseViewModel
    {
        public Job Job { get; set; }

        public Command SaveCommand { get; }

        public AddItemViewModel()
        {
            Title = "Adicionar Tarefa";

            Job = new Job();
            SaveCommand = new Command(ExecuteSaveCommand);
        }


        async void ExecuteSaveCommand()
        {

        }
    }
}
