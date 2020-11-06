using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace ClientApp.Handler
{
    public class KBDelegatingHandler : DelegatingHandler
    {
        private readonly ILogger _logger;
        public KBDelegatingHandler(ILogger Logger)
        {
            _logger = Logger;
        }

        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage requestMessage, CancellationToken cancellationToken)
        {
            HttpResponseMessage httpResponse;

            try
            {
                httpResponse = await base.SendAsync(requestMessage, cancellationToken);
            }
            catch(Exception ex)
            {
                _logger.LogError(ex, "Failed to run http query {RequestUri}", requestMessage.RequestUri);

                throw new ApplicationException(ex.ToString());
            }

            if (httpResponse.IsSuccessStatusCode)
            {
                return httpResponse;
            }
            else
            {
                var data = await httpResponse.Content.ReadAsStringAsync();

                //ErrorDetails Err = new ErrorDetails(httpResponse.StatusCode, (data != null) ? data : httpResponse.ReasonPhrase, "");
                throw new ApplicationException("Null entity error");
            }
        }
    }
}
