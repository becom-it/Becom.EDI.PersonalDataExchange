using Becom.EDI.PersonalDataExchange.Model.Enums;
using Becom.EDI.PersonalDataExchange.Services;
using System;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace IsyZeiterfassungDemo
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            IZeiterfassungsService service = new ZeiterfassungsService();

            var info = await service.GetEmployeeInfo(CompanyEnum.Austria, 5555);
            Console.WriteLine(JsonSerializer.Serialize(info, new JsonSerializerOptions { WriteIndented = true }));
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            var empList = await service.GetEmployeeList(CompanyEnum.Austria);
            Console.WriteLine(JsonSerializer.Serialize(empList, new JsonSerializerOptions { WriteIndented = true }));
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            var timeDetails = await service.GetEmployeeTimeDetails(CompanyEnum.Austria, 5555, new DateTime(2020, 10, 1), new DateTime(2020, 10, 30));
            Console.WriteLine(JsonSerializer.Serialize(timeDetails, new JsonSerializerOptions { WriteIndented = true }));
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            var presenceStatus = await service.GetEmployeePresenceStatus(CompanyEnum.Austria, 5555);
            Console.WriteLine(JsonSerializer.Serialize(presenceStatus, new JsonSerializerOptions { WriteIndented = true }));
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            var checkins = await service.GetEmployeeCheckIns(CompanyEnum.Austria, 5555, new DateTime(2020, 11, 5));
            Console.WriteLine(JsonSerializer.Serialize(checkins, new JsonSerializerOptions { WriteIndented = true }));
            Console.ReadKey();
        }

        public static async Task Call()
        {
            var httpClient = new HttpClient();
            var xml = @"<soapenv:Envelope xmlns:soapenv=""http://schemas.xmlsoap.org/soap/envelope/"" xmlns:per=""http://WHEDI1/PersonalDataExchange"">";
            xml += @"
                <soapenv:Header/>
                   <soapenv:Body>
                      <per:getPersonal>
                         <btrm>001</btrm>
                         <pern>5555</pern>
                      </per:getPersonal>
                   </soapenv:Body>
                </soapenv:Envelope>
                ";
            var httpContent = new StringContent(xml, Encoding.UTF8, "text/xml");
            var result = await httpClient.PostAsync("http://hitsrvtedi2:20304/PersonalDataExchange", httpContent);
            var content = await result.Content.ReadAsStringAsync();
            Console.WriteLine(result.StatusCode);
            Console.WriteLine(content);
        }

    }
}
