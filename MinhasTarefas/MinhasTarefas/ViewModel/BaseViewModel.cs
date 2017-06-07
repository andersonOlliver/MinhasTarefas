using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MinhasTarefas.ViewModel
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        public string Title { get; set; }
        protected INavigation navigation;

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName]string propertyName = null) { 
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public BaseViewModel(){}
        public BaseViewModel(string title)
        {
            Title = title;
            navigation = App.MasterDetail.Detail.Navigation;
        }

        protected bool SetProperty<T>(ref T storage, T value, [CallerMemberName]string propertyName = null)
        {
            if(EqualityComparer<T>.Default.Equals(storage, value))
            {
                return false;
            }

            storage = value;
            OnPropertyChanged(propertyName);

            return true;
        }

        public async Task PushAsync<TViewModel>(params object[] args) where TViewModel : BaseViewModel
        {
            var viewModelType = typeof(TViewModel);

            var viewModelTypeName = viewModelType.Name;
            var viewModelWordLength = "ViewModel".Length;
            var viewTypeName = $"MinhasTarefas.View.{viewModelTypeName.Substring(0, viewModelTypeName.Length - viewModelWordLength)}Page";//faltando
            var viewType = Type.GetType(viewTypeName);

            var page = Activator.CreateInstance(viewType) as Page;

            var viewModel = Activator.CreateInstance(viewModelType, args);
            if(page != null)
            {
                page.BindingContext = viewModel;
            }

            //await Application.Current.MainPage.Navigation.PushAsync(page);
            await App.NavigateMasterDetail(page);
        }
    }
}
