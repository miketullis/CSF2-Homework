using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF2Homework
{
    public class ContactInfo //Added public to make this accessible in CSF2Homework
    {

        //Fields
        private string _streetAddress;
        private string _city;
        private string _state;
        private string _zip;
        private string _phone;
        private string _email;
        
        //Properties
        public string StreetAddress
        {
            get { return _streetAddress; }
            set { _streetAddress = value; }
        }//end Street Address

        public string City
        {
            get { return _city; }
            set { _city = value; }
        }//end City

        public string State
        {
            get { return _state; }
            set { _state = value; }
        }//end State

        public string Zip
        {
            get { return _zip; }
            set { _zip = value; }
        }//end Zip
        
        public string Phone
        {
            get { return _phone; }
            set { _phone = value; }
        }//end Phone
               
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }//end Email


        //Constructors
        public ContactInfo(string streetAddress, string city, string state, string zip, string phone, string email)
        {
            //Property = parameter
            //PascalCase = camelCase
            StreetAddress = streetAddress;
            City = city;
            State = state;
            Zip = zip;
            Phone = phone;
            Email = email;
        }//end FQCTOR (Fully Qualified Constructor)

        public ContactInfo() //default CTOR
        {
        }

        //Methods
        public override string ToString()
        {
            return string.Format($"CONTACT INFO\n" +
                                 $"=============\n" +
                                 $"Address: {StreetAddress}\n" +
                                 $"   City: {City}\n" +
                                 $"  State: {State}\n" +
                                 $"    Zip: {Zip}\n" +
                                 $"Phone #: {Phone}\n" +
                                 $"  Email: {Email}\n");

        }//end ToString()

    }//end Class

}//end Namespace