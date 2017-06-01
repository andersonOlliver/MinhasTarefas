﻿using MinhasTarefas.Database;
using MinhasTarefas.Model.Util;
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
    public partial class DetailPage : TabbedPage
    {
        public DetailPage()
        {
            InitializeComponent();
            BindingContext = new DetailViewModel(DateTime.Now.DayOfWeek);
            JobDB _context = new JobDB();

            List<JobPerDay> allDays = new List<JobPerDay>();
            

            foreach (var day in _context.JobsWeek)
            {
                allDays.Add(day);
            }


            allDays = allDays.Distinct().ToList();

            foreach (var day in allDays)
            {
                DayPage aux = new DayPage(day);
                aux.Icon = "icon.png";
                Children.Add(aux);
            }

        }
    }
}