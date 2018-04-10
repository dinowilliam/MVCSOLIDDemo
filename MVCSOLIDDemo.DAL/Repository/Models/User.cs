using System;
using System.Collections.Generic;
using System.Linq;

namespace MVCSOLIDDemo.DAL.Repository.Models
{
    public class User
    {
        public Guid? Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }        
        public int Active{ get; set; }
        public string Sex { get; set; }
    }
}