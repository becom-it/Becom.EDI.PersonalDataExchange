using System;
using System.Collections.Generic;
using System.Text;

namespace Becom.EDI.PersonalDataExchange.Tests.Helpers
{
    public class ResponseContents
    {
        public static string GetEmployeeInfoResponse()
        {
            return "<?xml version=\"1.0\" ?><S:Envelope xmlns:S=\"http://schemas.xmlsoap.org/soap/envelope/\"><S:Body><ns2:getPersonalResponse xmlns:ns2=\"http://WHEDI1/PersonalDataExchange\"><getPersonal><pnazss>1545.0</pnazss><pnbtrm>1</pnbtrm><pneind>30418</pneind><pnfzop>0.0</pnfzop><pnname>Prattinger                    </pnname><pnpern>5555</pnpern><pnurlg>13</pnurlg><pnurlv>0</pnurlv><pnvgsd>5022</pnvgsd><pnvgsf>5022</pnvgsf><pnvnam>Michael             </pnvnam></getPersonal></ns2:getPersonalResponse></S:Body></S:Envelope>";

        }

        public static string GetEmployeeListResponse()
        {
            return "<?xml version=\"1.0\" ?><S:Envelope xmlns:S=\"http://schemas.xmlsoap.org/soap/envelope/\"><S:Body><ns2:getPersonalListResponse xmlns:ns2=\"http://WHEDI1/PersonalDataExchange\"><getPersonalList><personalList><pnbtrm>1</pnbtrm><pnname>Auer                          </pnname><pnpern>5120</pnpern><pnvnam>Martin              </pnvnam></personalList><personalList><pnbtrm>1</pnbtrm><pnname>Augustin                      </pnname><pnpern>8768</pnpern><pnvnam>Doris               </pnvnam></personalList><personalList><pnbtrm>1</pnbtrm><pnname>Augustin                      </pnname><pnpern>3176</pnpern><pnvnam>Karin               </pnvnam></personalList><personalList><pnbtrm>1</pnbtrm><pnname>Augustin                      </pnname><pnpern>1425</pnpern><pnvnam>Manfred             </pnvnam></personalList></getPersonalList></ns2:getPersonalListResponse></S:Body></S:Envelope>";

        }
    }
}
