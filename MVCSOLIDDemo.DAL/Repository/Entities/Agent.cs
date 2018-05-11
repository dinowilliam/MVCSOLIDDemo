using System;
using System.ComponentModel.DataAnnotations;

namespace MVCSOLIDDemo.DAL.Repository.Entities
{
    public class Agent {

        public Guid Id { get; set; }

        public AgentType AgentType { get; set; }

        public string Code { get; set; }
        
        public string Name { get; set; }
        
        public string Description { get; set; }
        
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [DataType(DataType.Password)]
        public string Password { get; set; }
        
        public string Gender { get; set; }

        public DateTime DateOfEmerge { get; set; }        

        public DateTime CreatedAt { get; set; }

        public DateTime DisabledAt { get; set; }

        public DateTime UpdatedAt { get; set; }

        public DateTime DeletedAt { get; set; }

    }
}