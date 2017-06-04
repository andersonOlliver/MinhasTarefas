using MinhasTarefas.Database;
using MinhasTarefas.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MinhasTarefas.ViewModel
{
    public class DetailViewModel : BaseViewModel
    {

        private ObservableCollection<string> days;

        public ObservableCollection<string> Days
        {
            get { return days; }
            set
            {
                days = value;
                OnPropertyChanged("Days");
            }
        }

        public DetailViewModel(string day)
        {
            Title = "Minhas Tarefas";
            Days = new ObservableCollection<string>();

            WeekDB _context = new WeekDB();

            var days = _context.Week.Where(a => a.Name == day).ToList();
            
        }

        public DetailViewModel(DayOfWeek day)
        {
            
            Title = "Minhas Tarefas";
            Days = new ObservableCollection<string>();

            JobDB _context = new JobDB();

            var days = _context.JobsWeek;

            foreach (var dayAux in days)
            {
                Days.Add(dayAux.Day);
            }
        }

        private string dayOfWeekToString(DayOfWeek day)
        {
            switch (day)
            {
                case DayOfWeek.Sunday:
                    return "Domingo";

                case DayOfWeek.Monday:
                    return "Segunda";

                case DayOfWeek.Tuesday:
                    return "Terça";

                case DayOfWeek.Wednesday:
                    return "Quarta";

                case DayOfWeek.Thursday:
                    return "Quinta";

                case DayOfWeek.Friday:
                    return "Sexta";

                case DayOfWeek.Saturday:
                    return "Sábado";

                default:
                    return "";
            }
        }
    }
}
