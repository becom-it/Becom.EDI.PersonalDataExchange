using EDI.PersonalDataExchange.Model;
using EDI.PersonalDataExchange.Model.Enums;
using Microsoft.Extensions.Logging;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace EDI.PersonalDataExchange.Services
{
    interface IZeiterfassungsService
    {
        /// <summary>
        /// Es wird der Personalstammsatz zurückgegeben
        /// </summary>
        /// <param name="betrieb">Betrieb</param>
        /// <param name="employeeId">Personalnummer</param>
        /// <returns>Personalstammsatz</returns>
        Task<EmployeeInfo> GetEmployeeInfo(CompanyEnum betrieb, int employeeId);
    }

    public class ZeiterfassungsService : IZeiterfassungsService
    {
        private readonly ILogger<ZeiterfassungsService> _logger;
        private readonly IHttpClientFactory _httpClientFactory;

        public ZeiterfassungsService(ILogger<ZeiterfassungsService> logger, IHttpClientFactory httpClientFactory)
        {
            _logger = logger;
            _httpClientFactory = httpClientFactory;
        }

        public async Task<EmployeeInfo> GetEmployeeInfo(CompanyEnum betrieb, int employeeId)
        {
            try
            {
                var xml = @"<soapenv:Envelope xmlns:soapenv=""http://schemas.xmlsoap.org/soap/envelope/"" xmlns:per=""http://WHEDI1/PersonalDataExchange"">
                                <soapenv:Header/>
                                <soapenv:Body>
                                    <per:getPersonal>
                                        <btrm>company</btrm>
                                        <pern>employeeid</pern>
                                    </per:getPersonal>
                                </soapenv:Body>
                            </soapenv:Envelope>"
                .Replace("company", ((int)betrieb).ToString())
                .Replace("employeeid", ((int)employeeId).ToString());

                var result = await callEndpoint(xml);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error calling GetEmployeeInfo (getPersonal): {ex.Message}", ex);
            }
        }

        private async Task<string> callEndpoint(string xml)
        {
            try
            {
                var httpContent = new StringContent(xml, Encoding.UTF8, "text/xml");

                var client = _httpClientFactory.CreateClient("edi");

                var result = await client.PostAsync("http://hitsrvtedi2:20304/PersonalDataExchange", httpContent);
                if (result.IsSuccessStatusCode)
                {
                    return await result.Content.ReadAsStringAsync();
                } else
                {
                    throw new Exception($"Endpoint HTTP error {result.StatusCode}");
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error calling endpoint: {ex.Message}", ex);
            }
        }

        private void parseXml(string xml)
        {
            try
            {
                XDocument doc = XDocument.Parse(xml);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error parsing xml result: {ex.Message}", ex);
            }
        }
    }
}
