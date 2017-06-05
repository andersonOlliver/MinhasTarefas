using Microsoft.WindowsAzure.MobileServices;
using MinhasTarefas.Authentication;
using MinhasTarefas.Helpers;
using MinhasTarefas.Model;
using MinhasTarefas.Service;
using MinhasTarefas.Service.Util;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Xamarin.Forms;

[assembly: Xamarin.Forms.Dependency(typeof(AzureService))]
namespace MinhasTarefas.Service
{
    public class AzureService
    {

        List<AppServiceIdentity> identities = null;

        public MobileServiceClient Client { get; set; } = null;

        public static bool UseAuth { get; set; } = false;

        public void Initialize()
        {
            Client = new MobileServiceClient(Connection.AppUrl);

            if(!string.IsNullOrWhiteSpace(Settings.AuthToken) && !string.IsNullOrWhiteSpace(Settings.UserId))
            {
                Client.CurrentUser = new MobileServiceUser(Settings.UserId)
                {
                    MobileServiceAuthenticationToken = Settings.AuthToken
                };
            }
        }

        public async Task<bool> LoginAsync()
        {
            Initialize();

            var auth = DependencyService.Get<IAuthentication>();
            var user = await auth.Login(Client, MobileServiceAuthenticationProvider.Facebook);

            if(user == null)
            {
                Settings.AuthToken = string.Empty;
                Settings.UserId = string.Empty;
                Settings.UserName = "Usuário";
                Settings.UserProfile = "user.png";

                Device.BeginInvokeOnMainThread(async () =>
                {
                    await App.Current.MainPage.DisplayAlert("Ops!", "Não conseguimos efetuar o seu login, tente novamente!", "OK");
                });

                return false;
            }
            else
            {
                identities = await Client.InvokeApiAsync<List<AppServiceIdentity>>("/.auth/me");
                
                var userToken = identities[0].AccessToken;
                var requestUrl = $"https://graph.facebook.com/v2.9/me/?fields=id,name,picture,cover&access_token={userToken}";
                var httpClient = new HttpClient();
                var userJson = await httpClient.GetStringAsync(requestUrl);
                var facebookProfile = JsonConvert.DeserializeObject<FacebookProfile>(userJson);

                Settings.AuthToken = user.MobileServiceAuthenticationToken;
                Settings.UserId = user.UserId;
                Settings.UserName = facebookProfile.Name;
                Settings.UserProfile = facebookProfile.Picture.Data.Url;
                Settings.UserCover = facebookProfile.Cover.Source;
            }
            return true;
        }
    }
}
