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
    public partial class Master : ContentPage
    {
        public Master()
        {
            InitializeComponent();

            BindingContext = new MasterViewModel();

            buttonA.Clicked += async (sender, e) =>
            {
                await App.NavigateMasterDetail(new A());
            };

            buttonB.Clicked += async (sender, e) =>
            {
                await App.NavigateMasterDetail(new B());
            };

            buttonPerfil.Clicked += async (sender, e) =>
            {
                await App.NavigateMasterDetail(new PerfilPage());
            };
        }
    }
}
