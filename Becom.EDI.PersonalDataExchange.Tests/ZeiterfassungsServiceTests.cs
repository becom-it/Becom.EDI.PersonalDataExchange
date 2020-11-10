using Becom.EDI.PersonalDataExchange.Model;
using Becom.EDI.PersonalDataExchange.Model.Config;
using Becom.EDI.PersonalDataExchange.Services;
using Becom.EDI.PersonalDataExchange.Tests.Helpers;
using FluentAssertions;
using Microsoft.Extensions.Logging.Abstractions;
using Moq;
using Moq.Protected;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace Becom.EDI.PersonalDataExchange.Tests
{
    public class ZeiterfassungsServiceTests
    {
        [Fact]
        public async Task GetEmployeeInfoTest()
        {
            //Arrange
            var mocks = MockHelpers.GetMocks(ResponseContents.GetEmployeeInfoResponse());


            //Act
            var service = new ZeiterfassungsService(mocks.logger, mocks.mockFactory.Object, mocks.config);

            var info = await service.GetEmployeeInfo(Model.Enums.CompanyEnum.Austria, 5555);
            info.Should().BeOfType<EmployeeInfo>();

            mocks.mockHttpMessageHandler.Protected().Verify(
                "SendAsync",
                Times.Exactly(1),
                ItExpr.Is<HttpRequestMessage>(req =>
                req.Method == HttpMethod.Post &&
                req.RequestUri.ToString() == mocks.config.Endpoint &&
                req.Content.ReadAsStringAsync().GetAwaiter().GetResult() == RequestContents.GetEmployeeInfoRequestContent()),
                ItExpr.IsAny<CancellationToken>());
        }

        [Fact]
        public async Task GetEmployeeListTest()
        {
            //Arrange
            var mocks = MockHelpers.GetMocks(ResponseContents.GetEmployeeListResponse());

            //Act
            var service = new ZeiterfassungsService(mocks.logger, mocks.mockFactory.Object, mocks.config);

            var info = await service.GetEmployeeList(Model.Enums.CompanyEnum.Austria);
            info.Should().BeOfType<EmployeeInfo>();

            mocks.mockHttpMessageHandler.Protected().Verify(
                "SendAsync",
                Times.Exactly(1),
                ItExpr.Is<HttpRequestMessage>(req =>
                req.Method == HttpMethod.Post &&
                req.RequestUri.ToString() == mocks.config.Endpoint &&
                req.Content.ReadAsStringAsync().GetAwaiter().GetResult() == RequestContents.GetEmployeeListRequestContent()),
                ItExpr.IsAny<CancellationToken>());
        }
    }
}
