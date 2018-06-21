using System;
using System.Net.Http;
using Microsoft.AspNetCore.Http;

namespace CHS.SkyApiAuthCodeFlow
{
    public class TestService : ITestService
    {
        private ISessionService _sessionService;
        private IHttpContextAccessor _httpContextAccessor;

        public TestService(ISessionService sessionService, IHttpContextAccessor httpContextAccessor)
        {
            _sessionService = sessionService;
            _httpContextAccessor = httpContextAccessor;
            StoreSession();
            GetSession();
        }

        public void StoreSession()
        {
            _httpContextAccessor.HttpContext.Session.SetString("New", "TestService");
            _sessionService.SetStringValue("Woah");
        }

        public void GetSession()
        {
            var variable = _sessionService.GetStringValue("Test");
        }
    }
}