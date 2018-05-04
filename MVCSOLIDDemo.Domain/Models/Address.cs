using MVCSOLIDDemo.Domain.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCSOLIDDemo.Domain.Models {
    class Address : IAddress {

        private readonly ICountry _country;

        private readonly ISubdivision _subdivision;

        private readonly ICity _city;

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

        public string AddressDescription { get; set; }

        public string Complement { get; set; }

        public int Number{ get; set; }

        public string PostalCode  { get; set; }

        public string PostBox { get; set; }

        public ICountry Country => _country;

        public ISubdivision Subdivision => _subdivision;

        public ICity City => _city;

        public void SetCountry(ICountry country) {

        }

        public void SetSudivison(ISubdivision subdivision) {

        }

        public void SetCity(ICity city) {

        }

    }
}
