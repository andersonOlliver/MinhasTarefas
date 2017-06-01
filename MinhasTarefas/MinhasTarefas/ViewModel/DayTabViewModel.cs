using MinhasTarefas.Database;
using MinhasTarefas.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhasTarefas.ViewModel
{
    public class DayTabViewModel : BaseViewModel
    {

        private ObservableCollection<Day> days;

        public ObservableCollection<Day> Days
        {
            get { return days; }
            set
            {
                days = value;
                OnPropertyChanged("Days");
            }
        }

        public DayTabViewModel(string day)
        {
            Days = new ObservableCollection<Day>();

            WeekDB _context = new WeekDB();

            var days = _context.Week.Where(a => a.Name == day).ToList();

            foreach(var dayAux in days)
            {
                Days.Add(dayAux);
            }
        }
    }
}
