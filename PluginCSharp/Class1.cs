using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Principal;
using Windows.System;
using Windows.Foundation;
using Windows.System.Threading;

namespace PluginCSharp
{
    public sealed class Class1
    {
        public static IAsyncOperation<string> getUserInfo()
        {

            return Task.Run<string>(async () =>
            {
                var users = await User.FindAllAsync(UserType.LocalUser);

                //string user = System.Threading.Thread.CurrentPrincipal.Identity.toString();

                return users.ToString();
                //var user = (string)await users.FirstOrDefault().GetPropertyAsync(KnownUserProperties.AccountName);
                //var domain = "";

                //if (string.IsNullOrEmpty(user))
                //{
                //    var domainWithUser = (string)await users.FirstOrDefault().GetPropertyAsync(KnownUserProperties.DomainName);
                //    domain = domainWithUser.Split('\\')[0];
                //    user = domainWithUser.Split('\\')[1];
                //}
                //string userName = user;//Environment.GetEnvironmentVariable("USERNAME");//.Security.Principal.WindowsIdentity.GetCurrent().Name;
                //return userName;
            }).AsAsyncOperation();
        }
    }
}
