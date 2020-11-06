using EDI.Zeiterfassung.Model.Enums;
using EDI.Zeiterfassung.Services;
using System;
using System.Net.Http;
using System.Numerics;
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

            //IZeiterfassungsService service = new ZeiterfassungsService();

            //var data = await service.GetEmployeeInfo(CompanyEnum.Austria, 5555);

            //var data = await service.GetEmployeeList(CompanyEnum.Austria);

            //Console.WriteLine(System.Text.Json.JsonSerializer.Serialize(data));

            await Call();

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
