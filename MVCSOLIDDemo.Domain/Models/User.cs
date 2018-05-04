using MVCSOLIDDemo.Domain.Models.Contracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace MVCSOLIDDemo.Domain.Models {
    public class User : IUser {

      
        private const int DaysInAYear = 365;

        private readonly ICollection<IAddress> _addresses;

        public User(string name, string surname, string email, string password, string sex, DateTime? dateOfBirth) : this() {
            Name = name;
            Surname = surname;
            Email = email;
            Password = password;
            Sex = sex;
            DateOfBirth = dateOfBirth;
        }

        internal User() {
        }

        public Guid Id { get; set; }

        public DateTime? CreatedAt { get; set; }

        public DateTime? DisabledAt { get; set; }

        public DateTime? UpdatedAt { get; set; }

        public DateTime? DeletedAt { get; set; }

        public Boolean IsEnabled {
            get {
                if (CreatedAt.HasValue && DisabledAt.HasValue == false && DeletedAt.HasValue == false) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }

        public Boolean IsDeleted {
            get {
                if (DeletedAt.HasValue == false) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string Sex { get; set; }

        public DateTime? DateOfBirth { get; set; }

        public int Age {
            get {
                TimeSpan Years = DateTime.Now - DateOfBirth.Value;
                return Years.Days/DaysInAYear;
            }
        }

        public IEnumerable<IAddress> Addresses => _addresses;

        public void AddAddress(IAddress address) {

        }

        public void RemoveAddress(IAddress address) {

        }

        public void SetMainAddress(IAddress address) {

        }

    }
}