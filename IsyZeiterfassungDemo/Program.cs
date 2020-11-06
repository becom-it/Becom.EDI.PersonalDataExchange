using EDI.Zeiterfassung.Model.Enums;
using EDI.Zeiterfassung.Services;
using System;
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

            //var data = await service.GetEmployeeInfo(CompanyEnum.Austria, 5555);

            var data = await service.GetEmployeeList(CompanyEnum.Austria);

            Console.WriteLine(System.Text.Json.JsonSerializer.Serialize(data));

            Console.ReadKey();
        }
    }
}
