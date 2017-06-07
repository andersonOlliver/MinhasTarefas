using MinhasTarefas.Model;
using MinhasTarefas.Model.Util;
using MinhasTarefas.ViewModel;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MinhasTarefas.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DayPage : ContentPage
    {
        public DayPage(DayWeek day)
        {
            InitializeComponent();

            BindingContext = new DayViewModel(day);
        }
    }
}
