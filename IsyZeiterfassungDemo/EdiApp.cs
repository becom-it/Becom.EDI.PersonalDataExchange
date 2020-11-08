using Becom.EDI.PersonalDataExchange.Model.Enums;
using Becom.EDI.PersonalDataExchange.Services;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace IsyZeiterfassungDemo
{
    public class EdiApp
    {
        private readonly ILogger<EdiApp> _logger;
        private readonly IZeiterfassungsService _zeiterfassungsService;

        public EdiApp(ILogger<EdiApp> logger, IZeiterfassungsService zeiterfassungsService)
        {
            _logger = logger;
            _zeiterfassungsService = zeiterfassungsService;
        }

        public async Task Run()
        {
            _logger.LogInformation($"Application Started at {DateTime.UtcNow}");

            var info = await _zeiterfassungsService.GetEmployeeInfo(CompanyEnum.Austria, 5555);
            _logger.LogInformation(JsonSerializer.Serialize(info, new JsonSerializerOptions { WriteIndented = true }));

            var empList = await _zeiterfassungsService.GetEmployeeList(CompanyEnum.Austria);
            _logger.LogInformation(JsonSerializer.Serialize(empList, new JsonSerializerOptions { WriteIndented = true }));

            var timeDetails = await _zeiterfassungsService.GetEmployeeTimeDetails(CompanyEnum.Austria, 5555, new DateTime(2020, 10, 1), new DateTime(2020, 10, 30));
            _logger.LogInformation(JsonSerializer.Serialize(timeDetails, new JsonSerializerOptions { WriteIndented = true }));

            var presenceStatus = await _zeiterfassungsService.GetEmployeePresenceStatus(CompanyEnum.Austria, 5555);
            _logger.LogInformation(JsonSerializer.Serialize(presenceStatus, new JsonSerializerOptions { WriteIndented = true }));


            var checkins = await _zeiterfassungsService.GetEmployeeCheckIns(CompanyEnum.Austria, 5555, new DateTime(2020, 11, 5));
            _logger.LogInformation(JsonSerializer.Serialize(checkins, new JsonSerializerOptions { WriteIndented = true }));

        }
    }
}
