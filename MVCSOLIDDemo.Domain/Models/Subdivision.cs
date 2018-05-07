namespace MVCSOLIDDemo.Domain.Models{

    using MVCSOLIDDemo.Domain.Models.Contracts;

    class Subdivision : BaseDomainModel, ISubdivision {
        
        private ICountry _country;
        
        public ICountry Country => _country;

        public string Code { get; set; }

        public string Name { get; set; }

        public SubdivisionCategory Category { get; set; }        

        public void SetCountry(ICountry country) {

            if(!_country.Equals(country)) {

                _country = country;

            }
        
        }

    }
}
