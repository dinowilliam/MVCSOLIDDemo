using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCSOLIDDemo.Utils.Algorithms.Mathematics.Types {
    
    public class Complex {

        public float Real { get; set; } = (float) 0.0;
        public float Imaginary { get; set; } = (float) 0.0;
                
        public Complex() {
        }
        
        public Complex(float real, float imaginary) {
            this.Real = real;
            this.Imaginary = imaginary;
        }

        public static Complex operator +(Complex a, Complex b) {            
            return new Complex(a.Real + b.Real, a.Imaginary + b.Imaginary);;
        }        
       
        public static Complex operator -(Complex a, Complex b) {            
            return new Complex(a.Real - b.Real, a.Imaginary - b.Imaginary);;
        }
               
        public static Complex operator *(Complex a, Complex b) {            
            return new Complex((a.Real * b.Real) - (a.Imaginary * b.Imaginary), (a.Real * b.Imaginary + (a.Imaginary * b.Real)));
        }
                                             
        public static Complex FromPolarToRectangular(double r, double radians) {
            
            float real = (float) (r * Math.Cos(radians));
            float imaginary = (float) (r * Math.Sin(radians));

            return new Complex(real, imaginary);
        }
                     
        public float Magnitude {
            get {
                return (float) Math.Sqrt(Math.Pow(Real, 2) + Math.Pow(Imaginary, 2));
            }
        }
        
        public float Phase {
            get {
                return (float) Math.Atan(Imaginary / Real);
            }
        }

        public override string ToString() {            

            return Real.ToString() + " " + Imaginary.ToString() + "i";;
        }

    }

}
