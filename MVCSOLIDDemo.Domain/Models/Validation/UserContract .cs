using FluentValidator.Validation;
using MVCSOLIDDemo.Domain.Models.Validation.Contracts;

namespace MVCSOLIDDemo.Domain.Models.Validation
{
    public class UserContract : IContract<User> {

        public ValidationContract Contract { get; }

        public UserContract(User user) {

            Contract = new ValidationContract()
                .Requires()
                .HasMinLen(user.Name, 3, "Name", "First Name should have at least 3 chars")
                .HasMaxLen(user.Name, 2, "Name", "First Name should not have more than 3 chars")
                .HasMinLen(user.Surname, 3, "Surname", "Last Name should have at least 3 chars")
                .HasMaxLen(user.Surname, 2, "Surname", "Last Name should not have more than 3 chars");
        }

    }
}
