using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF2Homework
{
    public class Vehicle //Added public to make this accessible in CSF2Homework
    {

        //Fields
        private string _make;
        private string _model;
        private int _year;
        private float _weight;

        //Properties
        public string Make
        {
            get { return _make; }
            set { _make = value; }
        }//end Make

        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }//end Model

        public int Year
        {
            get { return _year; }
            set { _year = value; }
        }//end Year

        public float Weight
        {
            get { return _weight; }
            set { _weight = value; }
        }//end Weight

        //Constructors
        public Vehicle(string make, string model, int year, float weight)
        {
            //Property = parameter
            //PascalCase = camelCase
            Make = make;
            Model = model;
            Year = year;
            Weight = weight;
        }//end FQCTOR (Fully Qualified Constructor)

        public Vehicle() //default CTOR
        {
        }

        //Methods
        public override string ToString()
        {
            return string.Format($"VEHICLE INFO\n" +
                                 $"============\n" +
                                 $" Make: {Make}\n" +
                                 $"Model: {Model}\n" +
                                 $" Year: {Year}\n" +
                                 $"  GVW: {Weight:n0} lbs");
        }//end ToString()

    }//end Class

}//end Namespace
