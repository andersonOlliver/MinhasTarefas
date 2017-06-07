using MinhasTarefas.Database;
using MinhasTarefas.Model;
using MinhasTarefas.Model.Util;
using MinhasTarefas.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MinhasTarefas.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetailPage : TabbedPage
    {
        public DetailPage()
        {
            InitializeComponent();
            Icon = "agenda.png";
            BindingContext = new DetailViewModel(DateTime.Now.DayOfWeek);
            JobDB _context = new JobDB();

            List<DayWeek> allDays = WeekDB.Days;

            foreach (var day in allDays)
            {
                Children.Add(new DayPage(day));
            }
        }
    }
}
