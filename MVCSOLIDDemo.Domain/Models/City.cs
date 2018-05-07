namespace MVCSOLIDDemo.Domain.Models
{
    class City : BaseDomainModel, ICity {

        public ISubdivision Subdivision { get; set; }

        public string Code { get; set; }

        public string Name { get; set; }

        public void SetSubdivision(ISubdivision subdivision) { 
        
        }

    }

}
