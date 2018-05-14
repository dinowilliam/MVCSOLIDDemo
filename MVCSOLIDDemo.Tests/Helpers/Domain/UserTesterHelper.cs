using System;

namespace MVCSOLIDDemo.Tests.Helpers.Domain
{
    using MVCSOLIDDemo.Domain.Models;
    using MVCSOLIDDemo.Domain.Models.Contracts;

    public static class UserTesterHelper {

        public static string Name { get { return "Fulano"; } }
        public static string Surname { get { return "Beltrano e Ciclano"; } }
        public static string Email { get { return "fulano@internet.com"; } }
        public static string Password { get { return "6512830FDF6336825E5202CE0BDD1677E6973A60AD85D258BF0ECC5F02280C98035732E6F32CD4261569C7A70E236397C7347463DAE53F593CB0A6E65F5134EA"; } }
        public static string Gender { get { return "Masculino"; } }
        public static DateTime DateOfBirth { get { return DateTime.Now.AddYears(AgeIncrement); } }

        public static IAddress AddressExpected {
            
            get {

                 var city = new City() {
                    Code = "0001",  
                    Name = "Metropolis"
                  };

                 var address = new Address() {

                    AddressDescription = "Rua Ficticia",
                    Complement = "Bairro de Marduina",
                    Number = 2005,
                    PostalCode = "1565236",
                    PostBox = "144545454",
                    AddressStatus = AddressStatus.MainAddress

                };
                
                address.SetCity(city);

                return address;
             }

        }

        public static int AgeIncrement { get { return -37; } }
        public static int ExpectedAge { get { return 37; } }

    }
}
