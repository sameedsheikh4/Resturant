using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text;

namespace Services
{
    public interface IHttpClientHelper
    {
        Uri CreateRequestUri(string relativePath, string queryString = "");
        HttpContent CreateHttpContent<T>(T content);
    }

    public class HttpClientHelper: IHttpClientHelper
    {
        public Uri CreateRequestUri(string relativePath, string queryString = "")
        {
            var uriBuilder = new UriBuilder(relativePath);
            uriBuilder.Query = queryString;
            return uriBuilder.Uri;
        }

        public HttpContent CreateHttpContent<T>(T content)
        {
            var json = JsonConvert.SerializeObject(content, MicrosoftDateFormatSettings);
            return new StringContent(json, Encoding.UTF8, "application/json");
        }

        public JsonSerializerSettings MicrosoftDateFormatSettings
        {
            get
            {
                return new JsonSerializerSettings
                {
                    DateFormatHandling = DateFormatHandling.MicrosoftDateFormat
                };
            }
        }
    }
}
