using System;
using System.Collections.Generic;
using System.Linq;

namespace MVCSOLIDDemo.Domain.Models {
    using MVCSOLIDDemo.Domain.Models.Contracts;
    using MVCSOLIDDemo.Domain.Models.Validation;
    using MVCSOLIDDemo.Domain.Models.Validation.Contracts;
    using MVCSOLIDDemo.Utils.Helpers.Primitives;

    public class User : Agent, IUser {
            
        private List<IAddress> _addresses;

        public User(string name, string surname, string username, string email, string password, string confirmPassword, string gender, DateTime? dateOfBirth, List<IAddress> addresses) : this() {
            Name = name;
            Surname = surname;
            Username = username;
            Email = email;
            Password = StringHelper.HashSHA512(password);
            Gender = gender;
            DateOfBirth = dateOfBirth;

            SetAddresses(addresses);
            ValidationContract = (IContract<User>) Activator.CreateInstance(typeof(UserContract), this);

            ValidationContract.Contract.AreEquals(Password, StringHelper.HashSHA512(confirmPassword), "", "As senhas devem ser identicas");
        }

        internal User() {
            ValidationContract = (IContract<User>)Activator.CreateInstance(typeof(UserContract), this);
        }       

        public string Name { get; set; }

        public string Surname { get; set; }

        public string Username { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string Gender { get; set; }

        public DateTime? DateOfBirth { get; set; }

        public int Age {

            get {
                TimeSpan Period = DateTime.Now - DateOfBirth.Value;
                return Period.Days/SpaceTimeHelper.DaysInThisYear;
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

        public bool Authenticate(string username, string password) {
            if (Username == username && Password == StringHelper.HashSHA512(password))
                return true;

            ValidationContract.Contract.AddNotification("User", "Usuário ou senha não parecem estar certos!");
            return false;
        }

    }
}