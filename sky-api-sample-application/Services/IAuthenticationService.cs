using System;
using System.Net.Http;

namespace CHS.SkyApiAuthCodeFlow
{
    public interface IAuthenticationService
    {
        HttpResponseMessage ExchangeCodeForAccessToken(string code);
        HttpResponseMessage RefreshAccessToken();
        Uri GetAuthorizationUri();
        bool IsAuthenticated();
        void LogOut();
    }
}