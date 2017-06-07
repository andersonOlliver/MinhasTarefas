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

        
        public DetailViewModel(DayOfWeek day)
        {
            
            Title = "Minhas Tarefas";
            Days = new ObservableCollection<string>();

            JobDB _context = new JobDB();

            var days = WeekDB.Days;

            foreach (var dayAux in days)
            {
                Days.Add(DayWeekToString(dayAux));
            }
        }

        private string DayWeekToString(DayWeek day)
        {
            switch (day)
            {
                case DayWeek.Dom:
                    return "Domingo";

                case DayWeek.Seg:
                    return "Segunda";

                case DayWeek.Ter:
                    return "Terça";

                case DayWeek.Qua:
                    return "Quarta";

                case DayWeek.Qui:
                    return "Quinta";

                case DayWeek.Sex:
                    return "Sexta";

                case DayWeek.Sab:
                    return "Sábado";

                default:
                    return "";
            }
        }
    }
}
