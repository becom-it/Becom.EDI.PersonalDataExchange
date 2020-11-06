using EDI.Zeiterfassung.Model.Enums;
using System;

namespace EDI.Zeiterfassung.Model
{
    public class EmployeePresenceStatus : ModelBase
    {
        /// <summary>
        /// Aktuelles Tagesdatum
        /// </summary>
        public DateTime CurrentDate { get; set; }

        /// <summary>
        /// Kenneichen ob Anwesend oder Abwesend: AN = Anwesend, AB = Abwesend
        /// </summary>
        public PresenceType Type { get; set; }
    }
}
