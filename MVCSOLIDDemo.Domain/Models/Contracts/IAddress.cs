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

        ICity City { get; }

        void SetCity(ICity city);

    }
}
