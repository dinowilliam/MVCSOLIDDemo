namespace MVCSOLIDDemo.Domain.Models
{
    class City : BaseDomainModel, ICity {

        private readonly ISubdivision _subdivision;      
        
        public string Code { get; set; }

        public string Name { get; set; }

        public ISubdivision Subdivision => _subdivision;  

        public void SetSubdivision(ISubdivision subdivision) { 
        
        }

    }

}
