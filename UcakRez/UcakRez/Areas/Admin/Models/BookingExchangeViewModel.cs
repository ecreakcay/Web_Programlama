namespace UcakRez.Areas.Admin.Models
{
    public class BookingExchangeViewModel
    {

            public Dashboarddata dashboardData { get; set; }
            public Region[] regions { get; set; }
            public Nationalcasestime[] nationalCasesTimes { get; set; }
        

        public class Dashboarddata
        {
            public int active { get; set; }
            public int confirmed { get; set; }
            public int deaths { get; set; }
            public int deltaConfirmed { get; set; }
            public int deltaDeaths { get; set; }
            public int deltaRecovered { get; set; }
            public int recovered { get; set; }
            public string state { get; set; }
            public string stateCode { get; set; }
            public object stateNotes { get; set; }
            public DateTime lastUpdatedTime { get; set; }
        }

        public class Region
        {
            public string state { get; set; }
            public int stateCode { get; set; }
            public int confirmed { get; set; }
            public int active { get; set; }
            public int recovered { get; set; }
            public int deaths { get; set; }
            public DateTime lastUpdatedTime { get; set; }
        }

        public class Nationalcasestime
        {
            public int dailyConfirmed { get; set; }
            public int dailyDeceased { get; set; }
            public int dailyRecovered { get; set; }
            public string date { get; set; }
        }



    }
}
