using EDI.Zeiterfassung.Model.Enums;
using System;

namespace EDI.Zeiterfassung.Model
{
    public class EmployeeTimeDetail : ModelBase
    {
        /// <summary>
        /// Abwesenheitskennzeichen Halbtag 1 
        /// </summary>
        public string AbsentKey1 { get; set; }

        /// <summary>
        /// Abwesenheitskennzeichen Halbtag 2 
        /// </summary>
        public string AbsentKey2 { get; set; }

        /// <summary>
        /// Arbeitszeit Brutto
        /// </summary>
        public TimeSpan GrossWorktime { get; set; }

        /// <summary>
        /// Arbeitszeit Netto Anwesenheit
        /// </summary>
        public TimeSpan NetWorktime { get; set; }

        /// <summary>
        /// Arbeitszeit Differenz Brutto
        /// </summary>
        public TimeSpan GrossWorktimeDifference { get; set; }

        /// <summary>
        /// Arbeitszeit Differenz Netto
        /// </summary>
        public TimeSpan NetWorktimeDifference { get; set; }

        /// <summary>
        /// Arbeitszeit Dienstgang
        /// </summary>
        public TimeSpan WorktimeOffSite { get; set; }

        /// <summary>
        /// Arbeitszeit Soll
        /// </summary>
        public TimeSpan TargetWorktime { get; set; }

        /// <summary>
        /// Arbeitszeit Saldo Brutto 
        /// </summary>
        public TimeSpan GrossWorktimeBalance { get; set; }

        /// <summary>
        /// Arbeitszeit Saldo Summe
        /// </summary>
        public TimeSpan WorktimeBalanceSum { get; set; }

        /// <summary>
        /// Arbeitszeit Überstunden
        /// </summary>
        public TimeSpan WorkOvertime { get; set; }

        /// <summary>
        /// Datum Anwesenheit 
        /// </summary>
        public DateTime PresenceDate { get; set; }

        /// <summary>
        /// Datum Anwesenheit 2
        /// </summary>
        public DateTime PresenceDate2 { get; set; }

        /// <summary>
        /// Fabrikskalendertag
        /// </summary>
        public int FactoryDate { get; set; }

        /// <summary>
        /// Art des Zeiterfassungsdatensatzes
        /// </summary>
        public int TimeType { get; set; }
    }
}
