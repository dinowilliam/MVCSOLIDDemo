using MVCSOLIDDemo.Domain.Models.Contracts;

namespace MVCSOLIDDemo.Domain.Models {
    public interface ICity : IBaseDomainModel {

        ISubdivision Subdivision { get; set; }

        string Code { get; set; }

        string Name { get; set; }

        void SetSubdivision(ISubdivision subdivision);

    }
}