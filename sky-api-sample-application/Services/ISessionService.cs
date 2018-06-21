using System.Net.Http;

namespace CHS.SkyApiAuthCodeFlow
{
    public interface ISessionService
    {
        void SetTokens(HttpResponseMessage response);
        void ClearTokens();
        string GetAccessToken();
        string GetRefreshToken();

        void SetStringValue(string value);
        string GetStringValue(string value);
    }
}