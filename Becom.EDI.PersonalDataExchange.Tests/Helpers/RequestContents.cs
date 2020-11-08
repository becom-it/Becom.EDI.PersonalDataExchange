namespace Becom.EDI.PersonalDataExchange.Tests.Helpers
{
    public class RequestContents
    {
        public static string GetEmployeeInfoRequestConfig()
        {
            return "<soapenv:Envelope xmlns:soapenv=\"http://schemas.xmlsoap.org/soap/envelope/\" xmlns:per=\"http://WHEDI1/PersonalDataExchange\" ><soapenv:Header/><soapenv:Body><per:getPersonal><btrm>company</btrm><pern>employeeid</pern></per:getPersonal></soapenv:Body></soapenv:Envelope>";
        }

        public static string GetEmployeeInfoRequestContent()
        {
            return "<soapenv:Envelope xmlns:soapenv=\"http://schemas.xmlsoap.org/soap/envelope/\" xmlns:per=\"http://WHEDI1/PersonalDataExchange\" ><soapenv:Header/><soapenv:Body><per:getPersonal><btrm>1</btrm><pern>5555</pern></per:getPersonal></soapenv:Body></soapenv:Envelope>";
        }

        public static string GetEmployeeListRequestConfig()
        {
            return "<soapenv:Envelope xmlns:soapenv=\"http://schemas.xmlsoap.org/soap/envelope/\" xmlns:per=\"http://WHEDI1/PersonalDataExchange\"><soapenv:Header/><soapenv:Body><per:getPersonalList><btrm>company</btrm></per:getPersonalList></soapenv:Body></soapenv:Envelope>";
        }

        public static string GetEmployeeListRequestContent()
        {
            return "<soapenv:Envelope xmlns:soapenv=\"http://schemas.xmlsoap.org/soap/envelope/\" xmlns:per=\"http://WHEDI1/PersonalDataExchange\"><soapenv:Header/><soapenv:Body><per:getPersonalList><btrm>1</btrm></per:getPersonalList></soapenv:Body></soapenv:Envelope>";
        }

        public static string GetEmployeeTimeDetailsRequestConfig()
        {
            return "<soapenv:Envelope xmlns:soapenv=\"http://schemas.xmlsoap.org/soap/envelope/\" xmlns:per=\"http://WHEDI1/PersonalDataExchange\"><soapenv:Header/><soapenv:Body><per:getZeiterfassung><btrm>company</btrm><pern>employeeid</pern><datv>fromdate</datv><datb>todate</datb><sart>1</sart></per:getZeiterfassung></soapenv:Body></soapenv:Envelope>";
        }

        public static string GetEmployeeTimeDetailsRequestContent()
        {
            return "<soapenv:Envelope xmlns:soapenv=\"http://schemas.xmlsoap.org/soap/envelope/\" xmlns:per=\"http://WHEDI1/PersonalDataExchange\"><soapenv:Header/><soapenv:Body><per:getZeiterfassung><btrm>1</btrm><pern>5555</pern><datv>fromdate</datv><datb>todate</datb><sart>1</sart></per:getZeiterfassung></soapenv:Body></soapenv:Envelope>";
        }

        public static string GetEmployeePresenceStatusRequestConfig()
        {
            return "<soapenv:Envelope xmlns:soapenv=\"http://schemas.xmlsoap.org/soap/envelope/\" xmlns:per=\"http://WHEDI1/PersonalDataExchange\"><soapenv:Header/><soapenv:Body><per:getPersonalStatus><btrm>company</btrm><pern>employeeid</pern></per:getPersonalStatus></soapenv:Body></soapenv:Envelope>";
        }

        public static string GetEmployeePresenceStatusRequestContent()
        {
            return "<soapenv:Envelope xmlns:soapenv=\"http://schemas.xmlsoap.org/soap/envelope/\" xmlns:per=\"http://WHEDI1/PersonalDataExchange\"><soapenv:Header/><soapenv:Body><per:getPersonalStatus><btrm>1</btrm><pern>5555</pern></per:getPersonalStatus></soapenv:Body></soapenv:Envelope>";
        }

        public static string GetEmployeeCheckInsRequestConfig()
        {
            return "<soapenv:Envelope xmlns:soapenv=\"http://schemas.xmlsoap.org/soap/envelope/\" xmlns:per=\"http://WHEDI1/PersonalDataExchange\"><soapenv:Header/><soapenv:Body><per:getPersonalStatusList><btrm>company</btrm><pern>employeeid</pern><date>fordate</date></per:getPersonalStatusList></soapenv:Body></soapenv:Envelope>";
        }

        public static string GetEmployeeCheckInsRequestContent()
        {
            return "<soapenv:Envelope xmlns:soapenv=\"http://schemas.xmlsoap.org/soap/envelope/\" xmlns:per=\"http://WHEDI1/PersonalDataExchange\"><soapenv:Header/><soapenv:Body><per:getPersonalStatusList><btrm>1</btrm><pern>5555</pern><date>fordate</date></per:getPersonalStatusList></soapenv:Body></soapenv:Envelope>";
        }
    }
}
