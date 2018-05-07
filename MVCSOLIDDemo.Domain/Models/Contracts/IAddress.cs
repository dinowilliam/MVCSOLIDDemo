namespace MVCSOLIDDemo.Domain.Models.Contracts {

    public interface IAddress : IBaseDomainModel {

        string AddressDescription { get; set; }

        string Complement { get; set; }

        int Number { get; set; }

        string PostalCode { get; set; }

        string PostBox { get; set; }    

        ICity City { get; }

        AddressStatus AddressStatus { get; set; }

        void SetCity(ICity city);

    }

}
