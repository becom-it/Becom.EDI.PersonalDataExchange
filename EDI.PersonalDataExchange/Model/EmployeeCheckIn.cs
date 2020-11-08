using Becom.EDI.PersonalDataExchange.Model.Enums;
using System;

namespace Becom.EDI.PersonalDataExchange.Model
{
    public class EmployeeCheckIn : ModelBase
    {
        /// <summary>
        /// Abgefragtes Datum
        /// </summary>
        public DateTime AskedForDate { get; set; }

        /// <summary>
        /// Kenneichen ob Anwesend oder Abwesend: AN = Anwesend, AB = Abwesend
        /// </summary>
        public PresenceType Type { get; set; }

        /// <summary>
        /// Zeitpunkt der Statusänderung
        /// </summary>
        public DateTime CheckinTime { get; set; }

        /// <summary>
        /// Abwesenheitskennzeichen, Grund für Abwesenheit (z.B.: Pause, Dienstgang)
        /// </summary>
        public string AbsenceType { get; set; }
    }
}
