namespace UserDetailsClient.Core.Features.LogOn
{
    public static class B2CConstants
    {
        // Azure AD B2C Coordinates
        public static string Tenant = "luckythemudhound.onmicrosoft.com";
        public static string AzureADB2CHostname = "luckythemudhound.b2clogin.com";
        public static string ClientID = "e191829f-1fd5-48ae-8d83-531ddd3f0dee";
        public static string PolicySignUpSignIn = "B2C_1_susi_1";
        public static string PolicyEditProfile = "b2c_1_edit_profile";
        public static string PolicyResetPassword = "b2c_1_reset";

        public static string[] Scopes = { "https://luckythemudhound.onmicrosoft.com/api/test.read" };

        public static string AuthorityBase = $"https://{AzureADB2CHostname}/tfp/{Tenant}/";
        public static string AuthoritySignInSignUp = $"{AuthorityBase}{PolicySignUpSignIn}";
        public static string AuthorityEditProfile = $"{AuthorityBase}{PolicyEditProfile}";
        public static string AuthorityPasswordReset = $"{AuthorityBase}{PolicyResetPassword}";
        public static string IOSKeyChainGroup = "com.luckythemudhound.mobile";
    }
}