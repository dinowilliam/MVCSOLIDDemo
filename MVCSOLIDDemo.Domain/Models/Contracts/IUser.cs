using System;
using System.Collections.Generic;

namespace MVCSOLIDDemo.Domain.Models.Contracts {

    interface IUser : IAgent {
           
        string Name { get; set; }

        string Surname { get; set; }

        string Email { get; set; }

        string Password { get; set; }

        string Gender { get; set; }

        DateTime? DateOfBirth { get; set; }

        int Age { get; }

        IEnumerable<IAddress> Addresses { get; }        

        void AddAddress(IAddress address);

        void RemoveAddress(IAddress address);

        void SetMainAddress(IAddress address);

    }
}
