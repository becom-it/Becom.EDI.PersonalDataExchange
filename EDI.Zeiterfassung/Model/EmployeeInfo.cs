using System;

namespace EDI.Zeiterfassung.Model
{
    public class EmployeeInfo : EmployeeBaseInfo
    {
        /// <summary>
        /// Vorgesetzter Disziplinär (Personalnummer)
        /// </summary>
        public int ManagerDisciplinary { get; set; }

        /// <summary>
        /// Vorgesetzter Fachlich (Personalnummer)
        /// </summary>
        public int ManagerProfessional { get; set; }

        /// <summary>
        /// Eintrittsdatum
        /// </summary>
        public DateTime EntryDate { get; set; }

        /// <summary>
        /// Arbeitszeit Saldo Summe
        /// </summary>
        public TimeSpan WorktimeSaldo { get; set; }

        /// <summary>
        /// Freizeitoption (offener Stundenpool)
        /// </summary>
        public TimeSpan FreeTimeOption { get; set; }

        /// <summary>
        /// Urlaub Gesamt (Verfügbarer Urlaub)
        /// </summary>
        public int HolidayAvailiable { get; set; }

        /// <summary>
        /// Urlaub Verbraucht (Eingetragener Urlaub)
        /// </summary>
        public int HolidayUsed { get; set; }
    }
}
