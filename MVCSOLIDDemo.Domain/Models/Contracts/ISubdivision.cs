namespace MVCSOLIDDemo.Domain.Models {
    
    using MVCSOLIDDemo.Domain.Models.Contracts;
    
    public interface ISubdivision : IBaseDomainModel {

        ICountry Country { get; }

        string Code { get; set; }

        string Name { get; set; }

        SubdivisionCategory Category { get; set; }

        void SetCountry(ICountry country);

    }
}

