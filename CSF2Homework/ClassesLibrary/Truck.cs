using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF2Homework
{
    public class Truck : Vehicle
    {
        //fields

        //properties
        public float LoadCapacityLbs { get; set; }

        //constructors
        public Truck(string make, string model, int year, float weight, int loadCapacityLbs) : base(make, model, year, weight)
        {
            LoadCapacityLbs = loadCapacityLbs;
        }//end Fully qualified CTOR


        //methods
        public override string ToString()
        {
            return base.ToString() + $"\nPayload: {LoadCapacityLbs:n0} lbs";

        }//endToString()

    }//end Class

}//end NameSpace
