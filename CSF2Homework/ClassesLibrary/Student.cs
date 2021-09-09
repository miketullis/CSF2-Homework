using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF2Homework
{
    public class Student //Added public to make this accessible in CSF2Homework
    {
        //Fields
        private string _firstName;
        private string _lastName;
        private string _studentID;
        private float _studentGPA;

        //Properties
        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }//end FirstName

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }//end LastName
        
        public string StudentID
        {
            get { return _studentID; }
            set { _studentID = value; }
        }//end StudentId

        public float StudentGPA
        {
            get { return _studentGPA; }
            set { _studentGPA = value; }
        }//end StudentGPA

        //Constructors
        public Student(string firstName, string lastName, string studentID, float studentGPA)
        {
            //Property = parameter
            //PascalCase = camelCase
            FirstName = firstName;
            LastName = lastName;
            StudentID = studentID;
            StudentGPA = studentGPA;
        }//end FQCTOR (Fully Qualified Constructor)

        public Student() //default CTOR
        {
        }
        
        //Methods
        public override string ToString()
        {
            return string.Format($"STUDENT INFO\n" +
                                 $"============\n" +
                                 $" First Name: {FirstName}\n" +
                                 $"  Last Name: {LastName}\n" +
                                 $" Student ID: {StudentID}\n" +
                                 $"Current GPA: {StudentGPA:n1}\n");
        }//end ToString()

    }//end Class

}//end Namespace
