using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public interface IHttpClientHelper
    {
        Uri CreateRequestUri(string relativePath, string queryString = "");
        HttpContent CreateHttpContent<T>(T content);
        Task<T> ResponseParsingAsync<T>(HttpResponseMessage response);
        Task<IEnumerable<T>> ResponseParsingListAsync<T>(HttpResponseMessage response);
    }

    public class HttpClientHelper : IHttpClientHelper
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

        public async Task<T> ResponseParsingAsync<T>(HttpResponseMessage response)
        {
            var responseStream = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<T>(responseStream);
        }

        public async Task<IEnumerable<T>> ResponseParsingListAsync<T>(HttpResponseMessage response)
        {
            var responseStream = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<IEnumerable<T>>(responseStream);
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
