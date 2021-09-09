using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF2Homework
{
    class TesterProgram
    {
        private static void Main(string[] args)
        {

            #region Students
            //STUDENTS
            Student s1 = new Student();
            s1.FirstName = "Michael";
            s1.LastName = "Tullis";
            s1.StudentID = "S12345";
            s1.StudentGPA = 4.0f;

            Student s2 = new Student("Charlie", "Star", "S98765", Convert.ToSingle(3.6));


            //WRITE TO THE CONSOLE
            Console.WriteLine("\n*** Students Default Constructor ***\n");

            Console.WriteLine(s1);
            Console.WriteLine(s2);

            Console.WriteLine("\n*** Students Fully Qualified Constructor ***\n");

            Console.WriteLine($"STUDENT INFO\n" +
                              $"============\n" +
                              $" First Name: {s1.FirstName}\n" +
                              $"  Last Name: {s1.LastName}\n" +
                              $" Student ID: {s1.StudentID}\n" +
                              $"Current GPA: {s1.StudentGPA:n1}\n");

            Console.WriteLine($"STUDENT INFO\n" +
                              $"============\n" +
                              $" First Name: {s2.FirstName}\n" +
                              $"  Last Name: {s2.LastName}\n" +
                              $" Student ID: {s2.StudentID}\n" +
                              $"Current GPA: {s2.StudentGPA:n1}\n");
            #endregion

            #region Vehicle
            //VEHICLES
            Vehicle v1 = new Vehicle();
            v1.Make = "Pontiac";
            v1.Model = "GTO";
            v1.Year = 1968;
            v1.Weight = 3500;

            Vehicle v2 = new Vehicle("Chevrolet", "Bel Air", 1957, 3273);

            //WRITE TO THE CONSOLE
            Console.WriteLine("\n*** Vehicles Default Constructor ***\n");

            Console.WriteLine(v1);
            Console.WriteLine(v2);

            Console.WriteLine("\n*** Vehicles Fully Qualified Constructor ***\n");

            Console.WriteLine($"VEHICLE INFO\n" +
                              $"============\n" +
                              $" Make: {v1.Make}\n" +
                              $"Model: {v1.Model}\n" +
                              $" Year: {v1.Year}\n" +
                              $"  GVW: {v1.Weight}lbs\n");

            Console.WriteLine($"VEHICLE INFO\n" +
                              $"============\n" +
                              $" Make: {v2.Make}\n" +
                              $"Model: {v2.Model}\n" +
                              $" Year: {v2.Year}\n" +
                              $"  GVW: {v2.Weight}lbs\n");
            #endregion

            #region Login
            //LOGIN
            Login l1 = new Login();
            l1.UserName = "mtullis";
            l1.Password = "Restless-1";

            Login l2 = new Login("acooper", "OleDarkEyes");

            //WRITE TO THE CONSOLE
            Console.WriteLine("\n*** Login Default Constructor ***\n");

            Console.WriteLine(l1);
            Console.WriteLine(l2);

            Console.WriteLine("\n*** Login Fully Qualified Constructor ***\n");

            Console.WriteLine($"LOGIN INFO\n" +
                              $"==========\n" +
                              $"Username: {l1.UserName}\n" +
                              $"Password: {l1.Password}\n");

            Console.WriteLine($"LOGIN INFO\n" +
                              $"==========\n" +
                              $"Username: {l2.UserName}\n" +
                              $"Password: {l2.Password}\n");
            #endregion

            #region ContactInfo
            //CONTACT INFO
            ContactInfo ci1 = new ContactInfo();
            ci1.StreetAddress = "1325 Commonwealth Ave";
            ci1.City = "Boston";
            ci1.State = "MA";
            ci1.Zip = "02134";
            ci1.Phone = "(555)666-7788";
            ci1.Email = "wings1@outlook.com";

            ContactInfo ci2 = new ContactInfo("4135 E Keim Drive", "Paradise Valley", "AZ", "85253", "(555)888-9900", "darkeyes1@outlook.com");

            ContactInfo ci3 = new ContactInfo("507 Elm Steet", "Tarkio", "MO", "64491", "(555)777-8899", "restless1@outlook.com");


            /*
            //WRITE TO THE CONSOLE
            Console.WriteLine("\n*** Contact Info Default Constructor ***\n");

            Console.WriteLine(ci1);
            Console.WriteLine(ci2);
            Console.WriteLine(ci3);

            Console.WriteLine("\n*** Contact Info Fully Qualified Constructor ***\n");

            Console.WriteLine($"CONTACT INFO\n" +
                                 $"=============\n" +
                                 $"Address: {ci1.StreetAddress}\n" +
                                 $"   City: {ci1.City}\n" +
                                 $"  State: {ci1.State}\n" +
                                 $"    Zip: {ci1.Zip}\n" +
                                 $"Phone #: {ci1.Phone}\n" +
                                 $"  Email: {ci1.Email}\n");

            Console.WriteLine($"CONTACT INFO\n" +
                                 $"=============\n" +
                                 $"Address: {ci2.StreetAddress}\n" +
                                 $"   City: {ci2.City}\n" +
                                 $"  State: {ci2.State}\n" +
                                 $"    Zip: {ci2.Zip}\n" +
                                 $"Phone #: {ci2.Phone}\n" +
                                 $"  Email: {ci2.Email}\n");

            Console.WriteLine($"CONTACT INFO\n" +
                                 $"=============\n" +
                                 $"Address: {ci3.StreetAddress}\n" +
                                 $"   City: {ci3.City}\n" +
                                 $"  State: {ci3.State}\n" +
                                 $"    Zip: {ci3.Zip}\n" +
                                 $"Phone #: {ci3.Phone}\n" +
                                 $"  Email: {ci3.Email}\n");

            */
            #endregion
            

            #region Customer
            //CUSTOMER
            Customer cs1 = new Customer("C54321", "Joe", "Perry", ci1);
            Customer cs2 = new Customer("C98765", "Alice", "Cooper", ci2);
            Customer cs3 = new Customer("C54321", "Michael", "Tullis", ci3);

            //WRITE TO THE CONSOLE
            /*
            Console.WriteLine("\n*** Customer Info Default Constructor ***\n");

            Console.WriteLine(cs1);
            Console.WriteLine(cs2);
            Console.WriteLine(cs3);
            */
            #endregion

            #region Credit Card Accounts
            //CREDIT CARD ACCOUNT

            CreditCardAccount cca1 = new CreditCardAccount(445566, cs1, Convert.ToDecimal(587.64), true, Convert.ToDecimal(22.98));
            CreditCardAccount cca2 = new CreditCardAccount(556677, cs2, Convert.ToDecimal(324.37), false, Convert.ToDecimal(11.70));
            CreditCardAccount cca3 = new CreditCardAccount(667788, cs3, Convert.ToDecimal(1225.78), false, Convert.ToDecimal(12.05));

            //WRITE TO THE CONSOLE
            Console.WriteLine("\n*** Credit Card Account Default Constructor ***\n");

            Console.WriteLine(cca1);
            Console.WriteLine(cca2);
            Console.WriteLine(cca3);
            #endregion

            #region Books
            Console.WriteLine("\n\n\n");//blank lines for spacing
            //BOOKS
            Book bk1 = new Book("Jurrasic Park", "Michael Crichton", 573);
            Book bk2 = new Book("Idiocracy: A Guide to Surviving in a Stupid World", "Mike Judge", 366);
            Book bk3 = new Book("A Playa's Guide to Pimpin'", "Silky Smoove", 469);
            Book bk4 = new Book("How to Cook Your Neighbor's Cat", "Cooter Davenport", 144);
            Book bk5 = new Book("Fast Cars and Faster Women", "Rico Suave", 222);
            Book bk6 = new Book("Training Your Pet Human", "Otis Driftwood", 336);

            //WRITE TO THE CONSOLE
            Console.WriteLine("\n*** Books Default Constructor ***\n");

            Console.WriteLine(bk1);
            Console.WriteLine(bk2);
            Console.WriteLine(bk3);
            #endregion
            

            #region Library
            Console.WriteLine("\n\n\n");//blank lines for spacing
            //LIBRARY   
            List<Book> books1 = new List<Book>() { bk2, bk3, bk5, bk6 };
            List<Book> books2 = new List<Book>() { bk1, bk3, bk4 };
            Library lb1 = new Library(books1, "OP Public Library", "105 Main St.", "Overland Park", "Kansas", "66201");
            Library lb2 = new Library(books2, "Truman Public Library", "607 24 Hwy.", "Independence", "MO", "64058");
         

            //WRITE TO THE CONSOLE
            Console.WriteLine("\n*** Library Default Constructor ***\n");

            Console.WriteLine(lb1);
            Console.WriteLine(lb2);
            #endregion


            #region Song
            Console.WriteLine("\n\n\n");//blank lines for spacing
            //SONG
            Song sg1 = new Song("Blackberry Smoke", "Leave A Scar", 215);
            Song sg2 = new Song("Jackyl", "Encore (It Makes My Bic Dig Her)", 480);
            Song sg3 = new Song("Clutch", "Fortunate Son", 143);
            Song sg4 = new Song("Lenny Kravitz", "Are You Gonna Go My Way?", 216);
            Song sg5 = new Song("Joan Jett And The Blackheart", "I Hate Myself For Loving You", 268);
            Song sg6 = new Song("Blackberry Smoke", "Up In Smoke", 210);
            Song sg7 = new Song("Blackberry Smoke", "Restless", 209);
            Song sg8 = new Song("Blackberry Smoke", "Ain't Much Left Of Me", 298);
            Song sg9 = new Song("Blackberry Smoke", "Bottom Of This", 222);
            Song sg10 = new Song("Blackberry Smoke", "Testify", 199);
            Song sg11 = new Song("Blackberry Smoke", "Sanctified Woman", 211);
            Song sg12 = new Song("KISS", "Rock And Roll All Nite (live)", 2265);
                                        

            //WRITE TO THE CONSOLE
            Console.WriteLine("\n***Songs Default Constructor ***\n");
            Console.WriteLine($"{sg1}\n\n{sg2}\n\n{sg3}\n\n{sg4}\n\n{sg5}\n\n{sg12}");
            #endregion


            #region Artist (Album)
            //ALBUM
            List<Song> albumSongs1 = new List<Song>() { sg1, sg2, sg3, sg4, sg5, sg12 };
            List<Song> albumSongs2 = new List<Song>() { sg10, sg11, sg9, sg6, sg1, sg7, sg8 };
            Album a1 = new Album("Party Rock Anthems EP", "Rock", albumSongs1);
            Album a2 = new Album("Going Back To Dixie", "Southern Rock", albumSongs2);
            
            //WRITE TO THE CONSOLE
            Console.WriteLine("\n***Album Default Constructor ***\n");

            Console.WriteLine(a1 + "\n\n");
            Console.WriteLine(a2 + "\n\n");
            #endregion


            #region MotorHome
            Console.WriteLine("\n\n\n");//blank lines for spacing
            //MOTORHOME
            MotorHome mh1 = new MotorHome("Chevrolet", "Pack-N-Go", 1998, 7180, 4);
            MotorHome mh2 = new MotorHome("Chevrolet", "Express", 2010, 12300, 6);
            
            //WRITE TO THE CONSOLE
            Console.WriteLine("\n***MotorHome Default Constructor ***\n");

            Console.WriteLine(" MOTOR HOME\n" + mh1 + "\n\n");
            Console.WriteLine(" MOTOR HOME\n" + mh2 + "\n\n");
            #endregion


            #region Truck
            Console.WriteLine("\n\n\n");//blank lines for spacing
            //MOTORHOME
            Truck tr1 = new Truck("Chevrolet", "Silverado", 2020, 4520, 9300);
            Truck tr2 = new Truck("GMC", "Siera", 2015, 5240, 9400);

            //WRITE TO THE CONSOLE
            Console.WriteLine("\n***MotorHome Default Constructor ***\n");

            Console.WriteLine("   TRUCK\n" + tr1 + "\n\n");
            Console.WriteLine("   TRUCK\n" + tr2 + "\n\n");
            #endregion





        }

    }
}
