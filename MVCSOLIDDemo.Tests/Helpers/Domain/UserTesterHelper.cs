using System;

namespace MVCSOLIDDemo.Tests.Helpers.Domain
{
    using FakeItEasy;
    using MVCSOLIDDemo.Domain.Models;
    using MVCSOLIDDemo.Domain.Models.Contracts;

    public static class UserTesterHelper {

        public static string Name { get { return "Fulano"; } }
        public static string Surname { get { return "Beltrano e Ciclano"; } }
        public static string Email { get { return "fulano@internet.com"; } }
        public static string Password { get { return "6512830FDF6336825E5202CE0BDD1677E6973A60AD85D258BF0ECC5F02280C98035732E6F32CD4261569C7A70E236397C7347463DAE53F593CB0A6E65F5134EA"; } }
        public static string Gender { get { return "Masculino"; } }
        public static DateTime DateOfBirth { get { return DateTime.Now.AddYears(AgeIncrement); } }

        public static ICountry ExpectedCountry {
            get { 
                 var country = A.Fake<Country>(x => new Country()
                    {                     				
                        ISOCodeAlpha2 = "BR",
                        ISOCodeAlpha3 = "BRA",
                        ISOCodeNumeric = "076",
                        ShortName = "Brazil",
                        LongName = "Federative Republic of Brazil",
                        Independent = true
                    }
                );

                return country;
            
            }
        }

        public static ISubdivision ExpectedSubdivision {
            get { 
                 var subdivision = A.Fake<Subdivision>(x => new Subdivision() {
                    Code = " BR-PR",  
                    Name = "Paraná",
                    Category = SubdivisionCategory.State
                   	 	
                  }
                );

                subdivision.SetCountry(ExpectedCountry);

                return subdivision;
            
            }
        }

         public static ICity ExpectedCity {
            get { 
                 var city = A.Fake<City>(x => new City() {
                    Code = "000",  
                    Name = "Curitiba"
                  }
                );

                 city.SetSubdivision(ExpectedSubdivision);

                return city;
            
            }
        }

        public static IAddress ExpectedAddress {
            
            get {                      
                              
                 var address = A.Fake<Address>(x => new Address() {
                    Description = "Rua Ficticia",
                    Complement = "Casa I",
                    District = "Marduina",
                    Number = 2005,
                    PostalCode = "1565236",
                    PostBox = "144545454",
                    AddressStatus = AddressStatus.MainAddress

                });
                
                address.SetCity(ExpectedCity);

                return address;
             }

        }

        public static int AgeIncrement { get { return -37; } }
        public static int ExpectedAge { get { return 37; } }
        
    }
}
