using MinhasTarefas.Model;
using MinhasTarefas.Model.Util;
using System.Collections.ObjectModel;

namespace MinhasTarefas.ViewModel
{
    public class DayViewModel : BaseViewModel
    {

        private ObservableCollection<JobUtil> eventList;

        public ObservableCollection<JobUtil> EventList
        {
            get { return eventList; }
            set
            {
                eventList = value;
                OnPropertyChanged("EventList");
            }
        }

        public DayViewModel(JobPerDay jobs)
        {
            Title = jobs.Day;
            EventList = new ObservableCollection<JobUtil>();

            foreach (var job in jobs.Jobs) 
            {
                EventList.Add(job);
            }
        }

    }
}
