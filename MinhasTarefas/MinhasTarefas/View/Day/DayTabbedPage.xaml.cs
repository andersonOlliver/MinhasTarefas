using MinhasTarefas.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MinhasTarefas.View.Day
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DayTabbedPage : TabbedPage
    {
        public DayTabbedPage()
        {
            InitializeComponent();

            

            WeekDB _context = new WeekDB();

            List<string> allDays = new List<string>();

            foreach(var day in _context.Week)
            {
                allDays.Add(day.Name);
            }


            allDays = allDays.Distinct().ToList();

            foreach(var day in allDays)
            {
                DayTabPage aux = new DayTabPage(day);
                aux.Icon = "icon.png";
                Children.Add(aux);
            }
        }
    }
}
