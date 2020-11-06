using EDI.Zeiterfassung.Model;
using EDI.Zeiterfassung.Model.Enums;
using EDI.Zeiterfassung.Service;
using System;
using System.Collections.Generic;

namespace EDI.Zeiterfassung.Extensions
{
    public static class ZeiterfassungsServiceExtensions
    {
        public static EmployeeInfo ToEmployeeInfo(this personal source)
        {
            var ret = new EmployeeInfo();
            ret.Company = (CompanyEnum)source.pnbtrm;
            ret.EmployeeId = Convert.ToInt32(source.pnpern);
            ret.FirstName = source.pnvnam;
            ret.LastName = source.pnname;
            ret.ManagerDisciplinary = Convert.ToInt32(source.pnvgsd);
            ret.ManagerProfessional = Convert.ToInt32(source.pnvgsf);
            ret.EntryDate = source.pneind.ToDateShort();
            ret.WorktimeSaldo = TimeSpan.FromMinutes(source.pnazss);
            ret.FreeTimeOption = TimeSpan.FromHours(source.pnfzop);
            ret.HolidayAvailiable = source.pnurlg;
            ret.HolidayUsed = source.pnurlv;
            return ret;
        }

        public static List<EmployeeBaseInfo> ToEmployeeList(this personalList source)
        {
            var ret = new List<EmployeeBaseInfo>();
            foreach(var p in source.personalList1)
            {
                var emp = new EmployeeBaseInfo
                {
                    Company = (CompanyEnum)p.pnbtrm,
                    EmployeeId = Convert.ToInt32(p.pnpern),
                    FirstName = p.pnvnam,
                    LastName = p.pnname
                };
                ret.Add(emp);
            }
            return ret;
        }

        public static List<EmployeeTimeDetail> ToEmployeeTimeDetails(this zeiterfassungList source)
        {
            var ret = new List<EmployeeTimeDetail>();
            foreach(var z in source.zeiterfassungList1)
            {
                var d = new EmployeeTimeDetail
                {
                    Company = (CompanyEnum)z.pnbtrm,
                    EmployeeId = Convert.ToInt32(z.pnpern),
                    AbsentKey1 = z.zeaht1,
                    AbsentKey2 = z.zeaht2,
                    GrossWorktime = TimeSpan.FromMinutes(z.zeazbr),
                    GrossWorktimeDifference = TimeSpan.FromMinutes(z.zeazdb),
                    WorktimeOffSite = TimeSpan.FromMinutes(z.zeazdi),
                    NetWorktimeDifference = TimeSpan.FromMinutes(z.zeazdn),
                    NetWorktime = TimeSpan.FromMinutes(z.zeazna),
                    GrossWorktimeBalance = TimeSpan.FromMinutes(z.zeazsb),
                    TargetWorktime = TimeSpan.FromMinutes(z.zeazso),
                    WorktimeBalanceSum = TimeSpan.FromMinutes(z.zeazss),
                    WorkOvertime = TimeSpan.FromMinutes(z.zeazue),
                    PresenceDate = z.zedate.ToDate(),
                    PresenceDate2 = z.zedat2.ToDate2(),
                    FactoryDate = Convert.ToInt32(z.zefkal),
                    TimeType = z.zesart
                };
                ret.Add(d);
            }
            return ret;
        }

        public static EmployeePresenceStatus ToEmployeePresenceStatus(this personalStatus source)
        {
            return new EmployeePresenceStatus
            {
                Company = (CompanyEnum)source.pnbtrm,
                EmployeeId = Convert.ToInt32(source.pnpern),
                CurrentDate = source.z1date.ToDate(),
                Type = source.z1stat == "AN" ? PresenceType.AN : PresenceType.AB
            };
        }

        public static List<EmployeeCheckIn> ToEmployeeCheckIns(this personalStatusList source)
        {
            var ret = new List<EmployeeCheckIn>();
            foreach(var status in source.personalStautsList)
            {
                var checkin = new EmployeeCheckIn
                {
                    Company = (CompanyEnum)status.pnbtrm,
                    EmployeeId = Convert.ToInt32(status.pnpern),
                    AskedForDate = status.z1date.ToDate(),
                    Type = status.z1stat == "AN" ? PresenceType.AN : PresenceType.AB,
                    CheckinTime = status.z1date.ToDate().Date.AddHours(Convert.ToDouble(status.z1time.Substring(0,2))).AddMinutes(Convert.ToDouble(status.z1time.Substring(3, 2))),
                    AbsenceType = status.z1aht1
                };
                ret.Add(checkin);
            }
            return ret;
        }

        public static DateTime ToDateShort(this long source)
        {
            var strSource = source.ToString();
            var strYear = strSource.Substring(strSource.Length - 2);
            var strMonth = strSource.Substring(strSource.Length - 4, 2);
            var strDay = strSource.Length > 5 ? strSource.Substring(0, 2) : strSource.Substring(0, 1);

            var strFullYear = Convert.ToInt32(strYear) > 80 ? $"19{strYear}" : $"20{strYear}";

            return new DateTime(Convert.ToInt32(strDay), Convert.ToInt32(strMonth), Convert.ToInt32(strFullYear));
        }

        public static DateTime ToDate(this long source)
        {
            var strSource = source.ToString();
            var strYear = strSource.Substring(0, 4);
            var strMonth = strSource.Substring(2, 2);
            var strDay = strSource.Substring(4, 2);

            return new DateTime(Convert.ToInt32(strDay), Convert.ToInt32(strMonth), Convert.ToInt32(strYear));
        }

        public static DateTime ToDate2(this long source)
        {
            var strSource = source.ToString();
            var strYear = strSource.Substring(4, 4);
            var strMonth = strSource.Substring(2, 2);
            var strDay = strSource.Substring(0, 2);

            return new DateTime(Convert.ToInt32(strDay), Convert.ToInt32(strMonth), Convert.ToInt32(strYear));
        }

        public static long FromDate(this DateTime source)
        {
            var year = source.ToString("yy");
            var month = source.ToString("MM");
            var day = source.ToString("dd");
            if (day.StartsWith("0")) day = day.Substring(1, 1);
            return Convert.ToInt64($"{day}{month}{year}");
        }

        public static void ErrorHandling(string source, error[] errors)
        {
            var exs = new List<Exception>();
            foreach(var err in errors)
            {
                exs.Add(new Exception($"({err.erco}): {err.ertx}"));
            }
            throw new AggregateException($"Error in {source}", exs);
        }
    }
}
