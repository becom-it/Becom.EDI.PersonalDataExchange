using Becom.EDI.PersonalDataExchange.Model.Enums;

namespace Becom.EDI.PersonalDataExchange.Model
{
    public class ModelBase
    {
        /// <summary>
        /// Betrieb Mandant (Werk z.B: Österreich 001/ Ungarn 002/ Bluetechnix 003)
        /// </summary>
        public CompanyEnum Company { get; set; }

        /// <summary>
        /// Personalnummer
        /// </summary>
        public int EmployeeId { get; set; }
    }
}