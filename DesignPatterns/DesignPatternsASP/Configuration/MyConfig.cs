namespace DesignPatternsASP.Configuration
{
    public class MyConfig // seria la representacion del objeto del appsettings.json
    {
        public string PathLog { get; set; }

        public decimal ForeignPercentage { get; set; }
        public decimal LocalPercentage { get; set; }

        public decimal Extra { get; set; }

    }
}
