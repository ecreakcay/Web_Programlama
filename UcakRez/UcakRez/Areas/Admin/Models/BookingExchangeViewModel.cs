namespace UcakRez.Areas.Admin.Models
{
    public class BookingExchangeViewModel
    {
            public Countries_Stat[] countries_stat { get; set; }
            public string statistic_taken_at { get; set; }
            public World_Total world_total { get; set; }
        

        public class World_Total
        {
            public string total_cases { get; set; }
            public string new_cases { get; set; }
            public string total_deaths { get; set; }
            public string new_deaths { get; set; }
            public string total_recovered { get; set; }
            public string active_cases { get; set; }
            public string serious_critical { get; set; }
            public string total_cases_per_1m_population { get; set; }
            public string deaths_per_1m_population { get; set; }
            public string statistic_taken_at { get; set; }
        }

        public class Countries_Stat
        {
            public string country_name { get; set; }
            public string cases { get; set; }
            public string deaths { get; set; }
            public string region { get; set; }
            public string total_recovered { get; set; }
            public string new_deaths { get; set; }
            public string new_cases { get; set; }
            public string serious_critical { get; set; }
            public string active_cases { get; set; }
            public string total_cases_per_1m_population { get; set; }
            public string deaths_per_1m_population { get; set; }
            public string total_tests { get; set; }
            public string tests_per_1m_population { get; set; }
        }


    }
}
