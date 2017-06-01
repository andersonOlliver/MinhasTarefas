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


        public DetailViewModel(string day)
        {
            Title = "Minhas Tarefas";
            Days = new ObservableCollection<Day>();

            WeekDB _context = new WeekDB();

            var days = _context.Week.Where(a => a.Name == day).ToList();

            foreach(var dayAux in days)
            {
                Days.Add(dayAux);
            }
        }

        public DetailViewModel(DayOfWeek day)
        {
            
            Title = "Minhas Tarefas";
            Days = new ObservableCollection<Day>();

            WeekDB _context = new WeekDB();

            var days = _context.Week.Where(a => a.DayOnCalendar.DayOfWeek == day).ToList();

            foreach (var dayAux in days)
            {
                Days.Add(dayAux);
            }
        }
    }
}
