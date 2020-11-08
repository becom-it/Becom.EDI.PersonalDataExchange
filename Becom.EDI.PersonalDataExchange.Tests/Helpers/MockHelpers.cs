using Becom.EDI.PersonalDataExchange.Model.Config;
using Becom.EDI.PersonalDataExchange.Services;
using Microsoft.Extensions.Logging.Abstractions;
using Moq;
using Moq.Protected;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Becom.EDI.PersonalDataExchange.Tests.Helpers
{
    public class MockHelpers
    {
        public static (NullLogger<ZeiterfassungsService> logger, 
            Mock<IHttpClientFactory> mockFactory, 
            Mock<HttpMessageHandler> mockHttpMessageHandler, 
            PersonalDataExchangeConfig config) GetMocks(string result)
        {
            var logger = new NullLogger<ZeiterfassungsService>();

            var mockFactory = new Mock<IHttpClientFactory>();
            var mockHttpMessageHandler = new Mock<HttpMessageHandler>();
            mockHttpMessageHandler.Protected()
                .Setup<Task<HttpResponseMessage>>("SendAsync", ItExpr.IsAny<HttpRequestMessage>(), ItExpr.IsAny<CancellationToken>())
                .ReturnsAsync(new HttpResponseMessage
                {
                    StatusCode = System.Net.HttpStatusCode.OK,
                    Content = new StringContent(result)
                })
                .Verifiable();

            var config = ConfigHelper.GetConfig();

            return (logger, mockFactory, mockHttpMessageHandler, config);
        }
    }
}
