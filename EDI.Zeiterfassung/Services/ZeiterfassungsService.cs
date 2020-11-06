using EDI.Zeiterfassung.Extensions;
using EDI.Zeiterfassung.Model;
using EDI.Zeiterfassung.Model.Enums;
using EDI.Zeiterfassung.Service;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EDI.Zeiterfassung.Services
{
    public interface IZeiterfassungsService
    {
        Task<PersonalDataProviderClient> GetInstanceAsync();

        /// <summary>
        /// Es wird der Personalstammsatz zurückgegeben
        /// </summary>
        /// <param name="betrieb">Betrieb</param>
        /// <param name="employeeId">Personalnummer</param>
        /// <returns>Personalstammsatz</returns>
        Task<EmployeeInfo> GetEmployeeInfo(CompanyEnum betrieb, int employeeId);
        Task<List<EmployeeBaseInfo>> GetEmployeeList(CompanyEnum betrieb);

        /// <summary>
        /// Zeiterfassungsdetails in ausgewähltem Zeitraum
        /// </summary>
        /// <param name="betrieb">Betrieb</param>
        /// <param name="employeeId">Personalnummer</param>
        /// <param name="From">Datum von</param>
        /// <param name="To">Datum bis</param>
        /// <returns>Zeiterfassungsdetails</returns>
        Task<List<EmployeeTimeDetail>> GetEmployeeTimeDetails(CompanyEnum betrieb, int employeeId, DateTime From, DateTime To);

        /// <summary>
        /// Aktueller Anwesenheitsstatusstatus einer Person. Information kommt live aus Zeiterfassungssystem
        /// </summary>
        /// <param name="betrieb">Betrieb</param>
        /// <param name="employeeId">Personalnummer</param>
        /// <returns>Anwesenheitsstatusstatus</returns>
        Task<EmployeePresenceStatus> GetEmployeePresenceStatus(CompanyEnum betrieb, int employeeId);
        Task<List<EmployeeCheckIn>> GetEmployeeCheckIns(CompanyEnum betrieb, int employeeId, DateTime ForDate);
    }

    public class ZeiterfassungsService : IZeiterfassungsService
    {
        public async Task<PersonalDataProviderClient> GetInstanceAsync()
        {
            return await Task.Run(() => new PersonalDataProviderClient());
        }

        /// <summary>
        /// Es wird der Personalstammsatz zurückgegeben
        /// </summary>
        /// <param name="betrieb">Betrieb</param>
        /// <param name="employeeId">Personalnummer</param>
        /// <returns>Personalstammsatz</returns>
        public async Task<EmployeeInfo> GetEmployeeInfo(CompanyEnum betrieb, int employeeId)
        {
            var client = await GetInstanceAsync();
            var employeeInfo = await client.getPersonalAsync(1, 5555);
            //var employeeInfo = await client.getPersonalAsync((int)betrieb, employeeId);

            //Error Handling
            if (employeeInfo.errorList.Length > 0) ZeiterfassungsServiceExtensions.ErrorHandling("GetEmployeeInfo", employeeInfo.errorList);

            return employeeInfo.ToEmployeeInfo();
        }

        /// <summary>
        /// Es wird eine Liste der Mitarbeiter ausgegeben
        /// </summary>
        /// <param name="betrieb">Betrieb</param>
        /// <returns></returns>
        public async Task<List<EmployeeBaseInfo>> GetEmployeeList(CompanyEnum betrieb)
        {
            var client = await GetInstanceAsync();
            var employeeList = await client.getPersonalListAsync((int)betrieb);

            //Error Handling
            if (employeeList.errorList.Length > 0) ZeiterfassungsServiceExtensions.ErrorHandling("GetEmployeeList", employeeList.errorList);

            return employeeList.ToEmployeeList();
        }

        /// <summary>
        /// Zeiterfassungsdetails in ausgewähltem Zeitraum
        /// </summary>
        /// <param name="betrieb">Betrieb</param>
        /// <param name="employeeId">Personalnummer</param>
        /// <param name="From">Datum von</param>
        /// <param name="To">Datum bis</param>
        /// <returns>Zeiterfassungsdetails</returns>
        public async Task<List<EmployeeTimeDetail>> GetEmployeeTimeDetails(CompanyEnum betrieb, int employeeId, DateTime From, DateTime To)
        {
            var client = await GetInstanceAsync();

            var employeeTimeDetails = await client.getZeiterfassungAsync((int)betrieb, employeeId, From.FromDate(), To.FromDate(), "1");

            //Error Handling
            if (employeeTimeDetails.errorList.Length > 0) ZeiterfassungsServiceExtensions.ErrorHandling("GetEmployeeTimeOverview", employeeTimeDetails.errorList);

            return employeeTimeDetails.ToEmployeeTimeDetails();
        }

        /// <summary>
        /// Aktueller Anwesenheitsstatusstatus einer Person. Information kommt live aus Zeiterfassungssystem
        /// </summary>
        /// <param name="betrieb">Betrieb</param>
        /// <param name="employeeId">Personalnummer</param>
        /// <returns>Anwesenheitsstatusstatus</returns>
        public async Task<EmployeePresenceStatus> GetEmployeePresenceStatus(CompanyEnum betrieb, int employeeId)
        {
            var client = await GetInstanceAsync();
            var employeePresenceStatus = await client.getPersonalStatusAsync((int)betrieb, employeeId);

            //Error Handling
            if (employeePresenceStatus.errorList.Length > 0) ZeiterfassungsServiceExtensions.ErrorHandling("GetEmployeePresenceStatus", employeePresenceStatus.errorList);

            return employeePresenceStatus.ToEmployeePresenceStatus();
        }

        /// <summary>
        /// Gibt eine Liste mit allen Statusänderungen an einem Tag zurück
        /// </summary>
        /// <param name="betrieb">Betrieb</param>
        /// <param name="employeeId">Personalnummer</param>
        /// <param name="ForDate">Abgfrage Datum</param>
        /// <returns>Liste mit allen Statusänderungen an einem Tag</returns>
        public async Task<List<EmployeeCheckIn>> GetEmployeeCheckIns(CompanyEnum betrieb, int employeeId, DateTime AskForDate)
        {
            var client = await GetInstanceAsync();

            var employeeCheckIns = await client.getPersonalStatusListAsync((int)betrieb, employeeId, AskForDate.FromDate());

            //Error Handling
            if (employeeCheckIns.errorList.Length > 0) ZeiterfassungsServiceExtensions.ErrorHandling("GetEmployeeCheckIns", employeeCheckIns.errorList);

            return employeeCheckIns.ToEmployeeCheckIns();
        }
    }
}
