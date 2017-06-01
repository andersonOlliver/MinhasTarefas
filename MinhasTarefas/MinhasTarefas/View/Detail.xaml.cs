﻿using MinhasTarefas.Database;
using MinhasTarefas.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MinhasTarefas.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Detail : TabbedPage
    {
        public Detail()
        {
            InitializeComponent();
            BindingContext = new DetailViewModel(DateTime.Now.DayOfWeek);
            WeekDB _context = new WeekDB();

            List<string> allDays = new List<string>();


        }
    }
}
