namespace MVCSOLIDDemo.Domain.Models {
    public class City : BaseDomainModel, ICity {

        private ISubdivision _subdivision;      

        public ISubdivision Subdivision => _subdivision;  
        
        public string Code { get; set; }

        public string Name { get; set; }        

        public void SetSubdivision(ISubdivision subdivision) {

            if(!_subdivision.Equals(subdivision)){
                
                _subdivision = subdivision;
                
            }
        
        }

    }

}
