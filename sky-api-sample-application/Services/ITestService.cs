using System;
using System.Net.Http;

namespace CHS.SkyApiAuthCodeFlow
{
    public interface ITestService
    {
        void GetSession();
        void StoreSession();
    }
}