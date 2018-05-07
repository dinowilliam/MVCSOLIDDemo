namespace MVCSOLIDDemo.Domain.Models
{
    class Country : BaseDomainModel, ICountry    {

        public string ISOCodeAlpha2 { get; set; }

        public string ISOCodeAlpha3 { get; set; }

        public string ISOCodeNumeric { get; set; }

        public string LongName { get; set; }

        public string ShortName { get; set; }

        public bool Independent { get; set; }

    }
}
