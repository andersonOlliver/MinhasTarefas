using MinhasTarefas.Database;
using MinhasTarefas.Model;
using MinhasTarefas.Model.Util;
using MinhasTarefas.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MinhasTarefas.ViewModel
{
    public class AddJobViewModel : BaseViewModel
    {
        public Job Job { get; set; }

        public bool Dom { get; set; }
        public bool Seg { get; set; }
        public bool Ter { get; set; }
        public bool Qua { get; set; }
        public bool Qui { get; set; }
        public bool Sex { get; set; }
        public bool Sab { get; set; } 

        public Command SaveCommand { get; }

        public AddJobViewModel():base("Adicionar Tarefa")
        {
            Initialize();
            Job = new Job();
            SaveCommand = new Command(ExecuteSaveCommand);
        }

        private void Initialize()
        {
            Dom = false;
            Seg = false;
            Ter = false;
            Qua = false;
            Qui = false;
            Sex = false;
            Sab = false;
        }

         void ExecuteSaveCommand()
        {
            JobDB _database = new JobDB();

            if (Dom)
            {
                Job.Day = DayWeek.Dom;
                _database.Save(Job);
            }
            if (Seg)
            {
                Job.Day = DayWeek.Seg;
                _database.Save(Job);
            }
            if (Ter)
            {
                Job.Day = DayWeek.Ter;
                _database.Save(Job);
            }
            if (Qua)
            {
                Job.Day = DayWeek.Qua;
                _database.Save(Job);
            }
            if (Qui)
            {
                Job.Day = DayWeek.Qui;
                _database.Save(Job);
            }
            if (Sex)
            {
                Job.Day = DayWeek.Sex;
                _database.Save(Job);
            }
            if (Sab)
            {
                Job.Day = DayWeek.Sab;
                _database.Save(Job);
            }

            //falta remover a página atual
            RemovePageFromStack();
        }

        private void RemovePageFromStack()
        {
            var existingPages = navigation.NavigationStack.ToList();
            foreach (var page in existingPages)
            {
                if (page.GetType() == typeof(AddJobPage))
                    navigation.RemovePage(page);
            }
        }
    }
}
