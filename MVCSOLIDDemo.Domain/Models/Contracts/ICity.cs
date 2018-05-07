namespace MVCSOLIDDemo.Domain.Models {
    
    using MVCSOLIDDemo.Domain.Models.Contracts;

    public interface ICity : IBaseDomainModel {

        ISubdivision Subdivision { get; }

        string Code { get; set; }

        string Name { get; set; }

        void SetSubdivision(ISubdivision subdivision);

    }
}