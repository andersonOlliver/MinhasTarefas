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
    public class DayViewModel : BaseViewModel
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

        public DayViewModel()
        {
            Days = new ObservableCollection<Day>();

            WeekDB _context = new WeekDB();

            foreach (var day in _context.Week)
            {
                Days.Add(day);
            }
        }

    }
}
