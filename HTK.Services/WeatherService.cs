using HTK.Services.Base;

namespace HTK.Services
{
    /// <summary>
    /// Class for getting weather information
    /// </summary>
    public class WeatherService : WebServiceBase
    {
        // URI to the endpoint.
        // And of course its smart to include the api key in here.
        // Because this will definitely not end up in a public repository on Github!
        protected const string endpoint = "https://api.openweathermap.org/data/2.5/onecall?lat=55.71&lon=9.54&exclude=hourly,current,minutely&appid=eda5a00a0b8ad42d190cda9d47844a10";
    }
}