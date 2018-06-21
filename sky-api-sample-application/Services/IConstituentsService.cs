using System.Net.Http;

namespace CHS.SkyApiAuthCodeFlow
{
    public interface IConstituentsService
    {
        HttpResponseMessage GetConstituent(string id);
        HttpResponseMessage GetConstituents();
    }
}