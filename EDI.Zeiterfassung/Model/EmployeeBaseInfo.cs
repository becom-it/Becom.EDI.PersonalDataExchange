using EDI.Zeiterfassung.Model.Enums;

namespace EDI.Zeiterfassung.Model
{
    public class EmployeeBaseInfo : ModelBase
    {
        /// <summary>
        /// Vorname
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Nachname
        /// </summary>
        public string LastName { get; set; }
    }
}
