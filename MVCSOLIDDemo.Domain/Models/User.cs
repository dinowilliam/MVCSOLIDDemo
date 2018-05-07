using System;
using System.Collections.Generic;

namespace MVCSOLIDDemo.Domain.Models {

    using MVCSOLIDDemo.Domain.Models.Contracts;
    using System.Linq;

    public class User : Agent, IUser  {
      
        private const int DaysInAYear = 365;

        private List<IAddress> _addresses;

        public User(string name, string surname, string email, string password, string gender, DateTime? dateOfBirth, List<IAddress> addresses) : this() {
            Name = name;
            Surname = surname;
            Email = email;
            Password = password;
            Gender = gender;
            DateOfBirth = dateOfBirth;

            SetAddresses(addresses);
        }

        internal User() {
        }       

        public string Name { get; set; }

        public string Surname { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string Gender { get; set; }

        public DateTime? DateOfBirth { get; set; }

        public int Age {

            get {
                TimeSpan Period = DateTime.Now - DateOfBirth.Value;
                return Period.Days/DaysInAYear;
            }

        }

        public IEnumerable<IAddress> Addresses => _addresses;

        private void SetAddresses(List<IAddress> addresses) {

            _addresses = _addresses != null ? _addresses : new List<Address>().ToList<IAddress>();

            if(!_addresses.Equals(addresses)) {
                
                _addresses = addresses;
                
            }
        
        }

        public void AddAddress(IAddress address) {
            
            if(!_addresses.Contains(address)) {

                _addresses.Add(address);

            }

        }

        public void RemoveAddress(IAddress address) {
            
            if(_addresses.Contains(address)){

                _addresses.Remove(address);

            }

        }

        public void SetMainAddress(IAddress address) {

            if(_addresses.Contains(address)){                       
                
                _addresses.Remove(address);

                _addresses.ForEach(a => { a.AddressStatus = AddressStatus.NormalAddress; });                                
                
                address.AddressStatus = AddressStatus.MainAddress;
                _addresses.Add(address);

            }

        }

    }
}