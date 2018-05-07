namespace MVCSOLIDDemo.Domain.Models{

    using MVCSOLIDDemo.Domain.Models.Contracts;

    class Subdivision : BaseDomainModel, ISubdivision {

        private readonly ICountry _country;

        public string Code { get; set; }

        public string Name { get; set; }

        public SubdivisionCategory Category { get; set; }

        public ICountry Country => _country;

        public void SetCountry(ICountry country) { 
        
        }

    }
}
