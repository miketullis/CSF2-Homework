using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF2Homework
{
    public class Customer
    {
        //fields 

        //properties
        public string CustomerID { get; set; }
        public string FirstName{ get; set; }
        public string LastName { get; set; }
        public ContactInfo ContactInformation { get; set; }

        
        //constructors
        public Customer(string customerID, string firstName, string lastName, ContactInfo contactInformation)
        {
            CustomerID = customerID;
            FirstName = firstName;
            LastName = lastName;
            ContactInformation = contactInformation;
        }

        //methods
        public override string ToString()
        {
            return string.Format($"CUSTOMER INFO\n" +
                                 $"=============\n" +
                                 $" Customer ID: {CustomerID}\n" +
                                 $"  First Name: {FirstName}\n" +
                                 $"   Last Name: {LastName}\n\n" +
                                 $"{ContactInformation}\n");

        }//end ToString()



    }//end class
}//end namespace
