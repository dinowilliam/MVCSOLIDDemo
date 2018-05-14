namespace MVCSOLIDDemo.Domain.Models {

    using MVCSOLIDDemo.Domain.Models.Contracts;

    public class Address : BaseDomainModel, IAddress {

        private ICity _city;      

        public ICity City => _city;       

        public string AddressDescription { get; set; }

        public string Complement { get; set; }

        public int Number{ get; set; }

        public string PostalCode  { get; set; }

        public string PostBox { get; set; }              
        
        public AddressStatus AddressStatus { get; set; }

        public void SetCity(ICity city) {

            if(!_city.Equals(city)){

                _city = city;
            }

        }

    }

}
