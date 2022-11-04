using System;

namespace UC1_CreateUser
{
    internal class AddressBook
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To IFCI Bank");
            CreateUsers us1 = new CreateUsers();
            us1.getDetails("Priyanka", "Rumal", "Jalna", "Maharashtra", 431203, 123455, "priyanka@hmail.com");
            us1.displayDetail();

            Console.WriteLine("");

            CreateUsers us2 = new CreateUsers();
            us1.getDetails("ashvini", "mule", "abad", "Maharashtra", 431120, 123455, "ashvini@gmail.com");
            us1.displayDetail();

        }

    }
    public class CreateUsers
    {
        private string fname;
        private string lname;
        private string city;
        private string state;
        private int zip;
        private int pno;
        private string email;


        public void getDetails(string fname, string lname, string city, string state, int zip, int pno, string email)
        {
            this.fname = fname;
            this.lname = lname;
            this.city = city;
            this.state = city;
            this.zip = zip;
            this.pno = pno;
            this.email = email;
        }

        public void displayDetail()
        {
            Console.WriteLine("First Name :" + fname);
            Console.WriteLine("Last Name :" + lname);
            Console.WriteLine("city :" + city);
            Console.WriteLine("state :" + state);
            Console.WriteLine("zip :" + zip);
            Console.WriteLine("Mobile No :" + pno);
            Console.WriteLine("Email :" + email);
        }
    }
}

