using System;

namespace ViewsService.MainViews
{
    public class CovidData
    {
        public string iso_code{ get; set; }
        public string continent{ get; set; }
        public string location{ get; set; }
        public DateTime date{ get; set; }
        public int total_cases{ get; set; }
        public int new_cases{ get; set; }
        public int total_deaths{ get; set; }
        public int new_deaths{ get; set; }
        public int hosp_patients{ get; set; }
        public int positive_rate{ get; set; }
        public int people_vaccinated{ get; set; }
        public int people_fully_vaccinated{ get; set; }
        public int new_vaccinations{ get; set; }
        public int people_fully_vaccinated_per_hundred{ get; set; }
    }
}
