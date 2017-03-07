using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace B2CQuickstart
{
    public partial class App : Application
    {
        public static PublicClientApplication AuthenticationClient { get; set; }

        // Step #1: Add Azure AD B2C tenant information.

        // Tenant and Policies supplied in sample by Xamarin
        /*
        public static string ClientId = "8ca648fd-2dc3-4ff1-aa4c-e9bd5543f2d0";
        public static string SignUpSignInPolicy = "B2C_1_SignInSignUp";
        public static string Authority = "https://login.microsoftonline.com/momentsapp.onmicrosoft.com/";
        */

        // Test Tenant and Policies
        public static string ClientId = "377cd8c6-a9df-4a55-aac5-8055475a550f";
        public static string SignUpSignInPolicy = "B2C_1_DefaultSignInSignUp";
        public static string Authority = "https://login.microsoftonline.com/BlueMetalElkay.onmicrosoft.com/";


        public static string[] Scopes = { ClientId };

        public App()
        {
            InitializeComponent();

            AuthenticationClient = new PublicClientApplication(ClientId);

            MainPage = new NavigationPage (new LoginPage());
        }
    }
}
