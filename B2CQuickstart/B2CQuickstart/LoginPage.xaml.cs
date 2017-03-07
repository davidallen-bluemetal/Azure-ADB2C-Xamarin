using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Identity.Client;
using Xamarin.Forms;

namespace B2CQuickstart
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        public async void LoginButton_Clicked(object sender, EventArgs e)
        {
            try
            {
                // clear any tokens as if having logged out
                if ((App.AuthenticationClient != null) && (App.AuthenticationClient.UserTokenCache.Count > 0) &&
                    !string.IsNullOrWhiteSpace(App.AuthenticationClient.ClientId))
                {
                    App.AuthenticationClient.UserTokenCache.Clear(App.AuthenticationClient.ClientId);
                }



                // Step #2: Authenticate with Microsoft Authentication Library (MSAL).

                // Authenticate users with Microsoft Authentication Library (MSAL).
                var authenticationResult = await App.AuthenticationClient.AcquireTokenAsync(App.Scopes,
                    "",
                    UiOptions.SelectAccount,
                    string.Empty,
                    null,
                    App.Authority,
                    App.SignUpSignInPolicy);
                // Navigate users into the main portion of our app.
                await Navigation.PushAsync(new AuthenticationSuccessfulPage(authenticationResult));


            }
            catch (Exception ex)
            {
                await DisplayAlert("Error Authenticating", ex.Message, "OK");
            }
        }
    }
}
