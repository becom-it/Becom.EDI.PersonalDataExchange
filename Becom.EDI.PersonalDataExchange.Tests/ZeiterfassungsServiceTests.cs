﻿using Becom.EDI.PersonalDataExchange.Model;
using Becom.EDI.PersonalDataExchange.Model.Config;
using Becom.EDI.PersonalDataExchange.Services;
using Becom.EDI.PersonalDataExchange.Tests.Helpers;
using FluentAssertions;
using Microsoft.Extensions.Logging.Abstractions;
using Moq;
using Moq.Protected;
using System.Collections.Generic;
using System.Linq;
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
            
            info.FirstName.Should().Be("Michael");
            info.LastName.Should().Be("Prattinger");
            info.ManagerDisciplinary.Should().Be(5022);
            info.ManagerProfessional.Should().Be(5022);
            info.EntryDate.Should().Be(new System.DateTime(2018, 4, 3));

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

            var list = await service.GetEmployeeList(Model.Enums.CompanyEnum.Austria);
            
            list.Should().BeOfType<List<EmployeeBaseInfo>>();
            list.Count.Should().Be(4);
            
            list.First().FirstName.Should().Be("Martin");
            list.First().LastName.Should().Be("Auer");
            list.First().EmployeeId.Should().Be(5120);
            
            list.Last().FirstName.Should().Be("Manfred");
            list.Last().LastName.Should().Be("Augustin");
            list.Last().EmployeeId.Should().Be(1425);

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
