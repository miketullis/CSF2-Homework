using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF2Homework
{
    public class Login //Added public to make this accessible in CSF2Homework
    {

        //Fields
        private string _userName;
        private string _password;

        //Properties
        public string UserName
        {
            get { return _userName; }
            set { _userName = value; }
        }//end FirstName

        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }//end LastName



        //Constructors
        public Login(string userName, string password)
        {
            //Property = parameter
            //PascalCase = camelCase
            UserName = userName;
            Password = password;
          }//end FQCTOR (Fully Qualified Constructor)

        public Login() //default CTOR
        {
        }

        //Methods
        public override string ToString()
        {
            return string.Format($"LOGIN INFO\n" +
                                 $"==========\n" +
                                 $"Username: {UserName}\n" +
                                 $"Password: {Password}\n");
        }//end ToString()

    }//end Class

}//end Namespace
