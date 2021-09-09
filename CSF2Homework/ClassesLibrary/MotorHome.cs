using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF2Homework
{
    public class MotorHome : Vehicle
    {
       //fields

        //properties
        public int NumberOfBeds { get; set; }

        //constructors
        public MotorHome(string make, string model, int year, float weight, int numberOfBeds) : base (make, model, year, weight)
        {
            NumberOfBeds = numberOfBeds;
        }//end Fully qualified CTOR
        

        //methods
        public override string ToString()
        {
            return base.ToString() + $"\n Beds: {NumberOfBeds}";

        }//endToString()

    }//end Class

}//end NameSpace
