namespace MVCSOLIDDemo.Domain.Models {
    using MVCSOLIDDemo.Domain.Models.Contracts;
    
    public interface ICountry : IBaseDomainModel {

        string ISOCodeAlpha2 { get; set; }
       
        string ISOCodeAlpha3 { get; set; }
        
        string ISOCodeNumeric { get; set; }
        
        string LongName { get; set; }
        
        string ShortName { get; set; }
        
        bool Independent { get; set; }

    }
}