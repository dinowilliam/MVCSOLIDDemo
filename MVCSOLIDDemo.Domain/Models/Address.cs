using MVCSOLIDDemo.Domain.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCSOLIDDemo.Domain.Models {
    class Address : IAddress {

        public Guid Id { get; set; }

        public DateTime? CreatedAt { get; set; }

        public DateTime? DisabledAt { get; set; }

        public DateTime? UpdatedAt { get; set; }

        public DateTime? DeletedAt { get; set; }

        public Boolean IsEnabled {
            get {
                if (CreatedAt.HasValue && DisabledAt.HasValue == false && DeletedAt.HasValue == false) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }

        public Boolean IsDeleted {
            get {
                if (DeletedAt.HasValue == false) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
    }
}
