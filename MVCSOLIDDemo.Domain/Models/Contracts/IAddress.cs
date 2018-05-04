using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCSOLIDDemo.Domain.Models.Contracts {
    public interface IAddress : IBaseDomainModel {

        string AddressDescription { get; set; }

        string Complement { get; set; }

        int Number { get; set; }

        string PostalCode { get; set; }

        string PostBox { get; set; }

        ICountry Country { get; }

        ISubdivision Subdivision { get; }

        ICity City { get; }

        void SetCountry(ICountry country);

        void SetSudivison(ISubdivision subdivision);

        void SetCity(ICity city);

    }
}
