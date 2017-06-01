using MinhasTarefas.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MinhasTarefas
{
    public partial class MainPage : MasterDetailPage
    {
        
        public MainPage()
        {

            InitializeComponent();

            this.Master = new Master();
            this.Detail = new NavigationPage(new DetailPage());
            App.MasterDetail = this;
        }
    }
}
