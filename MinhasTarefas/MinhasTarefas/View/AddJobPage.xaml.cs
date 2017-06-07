﻿using MinhasTarefas.ViewModel;
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
    public partial class AddJobPage : ContentPage
    {
        public AddJobPage()
        {
            InitializeComponent();
            BindingContext = new AddJobViewModel();
        }
    }
}
    