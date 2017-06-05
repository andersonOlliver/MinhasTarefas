using MinhasTarefas.Authentication;
using MinhasTarefas.iOS.Authentication;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.WindowsAzure.MobileServices;
using System.Threading.Tasks;
using MinhasTarefas.Helpers;

[assembly: Xamarin.Forms.Dependency(typeof(SocialAuthentication))]
namespace MinhasTarefas.iOS.Authentication
{
    public class SocialAuthentication : IAuthentication
    {
        public async Task<MobileServiceUser> Login(MobileServiceClient client,
            MobileServiceAuthenticationProvider provider, 
            IDictionary<string, string> parameters = null)
        {
            try
            {
                var current = GetController();
                var user = await client.LoginAsync(current, provider);

                Settings.AuthToken = user?.MobileServiceAuthenticationToken ?? string.Empty;
                Settings.UserId = user?.UserId ?? string.Empty;

                return user;
            }
            catch(Exception ex) {
                throw;
            }
        }

        private UIKit.UIViewController GetController()
        {
            var window = UIKit.UIApplication.SharedApplication.KeyWindow;
            var root = window.RootViewController;

            if (root == null) return null;

            var current = root;
            while(current.PresentedViewController != null)
            {
                current = current.PresentedViewController;
            }
            return current;
        }
    }
}
