using MVCSOLIDDemo.Domain.Models.Contracts;

namespace MVCSOLIDDemo.Domain.Models {
    public interface ISubdivision : IBaseDomainModel {

        ICountry Country { get; set; }

        string Code { get; set; }

        string Name { get; set; }

        SubdivisionCategory Category { get; set; }

        void SetCountry(ICountry country);

    }
}

namespace MVCSOLIDDemo.Domain.Models.Contracts {
    public enum SubdivisionCategory {

        FederalDistric = 0,
        State = 1,
        Province = 2

    }
}