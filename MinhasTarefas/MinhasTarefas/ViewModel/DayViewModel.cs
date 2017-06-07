using MinhasTarefas.Database;
using MinhasTarefas.Model;
using MinhasTarefas.Model.Util;
using System.Collections.ObjectModel;

namespace MinhasTarefas.ViewModel
{
    public class DayViewModel : BaseViewModel
    {
        private JobDB _database;
        private ObservableCollection<Job> eventList;

        public ObservableCollection<Job> EventList
        {
            get { return eventList; }
            set
            {
                eventList = value;
                OnPropertyChanged("EventList");
            }
        }

        public DayViewModel(DayWeek day)
        {
            Title = DayWeekToString(day);
            EventList = new ObservableCollection<Job>();
            _database = new JobDB();
            var dataList = _database.GetJobsDay(day);
            foreach(var data in dataList)
            {
                EventList.Add(data);
            }
        }

        private string DayWeekToString(DayWeek day)
        {
            switch (day)
            {
                case DayWeek.Dom:
                    return "Domingo";

                case DayWeek.Seg:
                    return "Segunda-feira";

                case DayWeek.Ter:
                    return "Terça-feira";

                case DayWeek.Qua:
                    return "Quarta-feira";

                case DayWeek.Qui:
                    return "Quinta-feira";

                case DayWeek.Sex:
                    return "Sexta-feira";

                case DayWeek.Sab:
                    return "Sábado";

                default:
                    return "";
            }
        }
    }
}
