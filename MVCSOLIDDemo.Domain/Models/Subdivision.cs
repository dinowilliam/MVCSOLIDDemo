namespace MVCSOLIDDemo.Domain.Models{

    using MVCSOLIDDemo.Domain.Models.Contracts;

    class Subdivision : BaseDomainModel, ISubdivision {

        public ICountry Country { get; set; }

        public string Code { get; set; }

        public string Name { get; set; }

        public SubdivisionCategory Category { get; set; }

        public void SetCountry(ICountry country) { 
        
        }

    }
}
