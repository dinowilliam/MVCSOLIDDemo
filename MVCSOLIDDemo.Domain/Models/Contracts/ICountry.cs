using MVCSOLIDDemo.Domain.Models.Contracts;

namespace MVCSOLIDDemo.Domain.Models {
    public interface ICountry : IBaseDomainModel {
        string ISOCodeAlpha2 { get; set; }
        string ISOCodeAlpha3 { get; set; }
        string ISOCodeNumeric { get; set; }
        string LongName { get; set; }
        string ShortName { get; set; }
        bool Independent { get; set; }
    }
}