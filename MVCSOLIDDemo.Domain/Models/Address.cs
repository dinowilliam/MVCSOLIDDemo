namespace MVCSOLIDDemo.Domain.Models {

    using MVCSOLIDDemo.Domain.Models.Contracts;

    class Address : BaseDomainModel, IAddress {

        private readonly ICity _city;      

        public string AddressDescription { get; set; }

        public string Complement { get; set; }

        public int Number{ get; set; }

        public string PostalCode  { get; set; }

        public string PostBox { get; set; }      

        public ICity City => _city;       

        public void SetCity(ICity city) {

        }

    }
}
