using Microsoft.WindowsAzure.MobileServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhasTarefas.Authentication
{
    public interface IAuthentication
    {
        Task<MobileServiceUser> Login(MobileServiceClient client, 
            MobileServiceAuthenticationProvider provider,
            IDictionary<string, string> parameters = null);
    }
}
