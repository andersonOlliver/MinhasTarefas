using MinhasTarefas.ViewModel;
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
    public partial class DayTabPage : ContentPage
    {
        public DayTabPage(string day)
        {
            InitializeComponent();

            Title = day;
            
            BindingContext = new DayTabViewModel(day);
        }
    }
}
