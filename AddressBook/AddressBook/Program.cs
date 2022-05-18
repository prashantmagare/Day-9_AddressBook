
using System.Collections;

namespace AddressBookSystem
{
    public class AddressBook
    {
        //Fields
        public string FirstName, LastName, Address, City, State, Zip, PhoneNumber, Email;
        internal class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Welcome To Address Book Program");

                AddressBook a = new AddressBook(); //Object

                ArrayList addbook = new ArrayList(); //Arraylist use to store all fields

                Console.WriteLine("Enter First Name ");
                a.FirstName = Convert.ToString(Console.ReadLine());
                addbook.Add(a.FirstName);
                Console.WriteLine("Enter Last Name");
                a.LastName = Convert.ToString(Console.ReadLine());
                addbook.Add(a.LastName);
                Console.WriteLine("Enter Address ");
                a.Address = Convert.ToString(Console.ReadLine());
                addbook.Add(a.Address);
                Console.WriteLine("Enter city");
                a.City = Convert.ToString(Console.ReadLine());
                addbook.Add(a.City);
                Console.WriteLine("Enter state");
                a.State = Convert.ToString(Console.ReadLine());
                addbook.Add(a.State);
                Console.WriteLine("Enter zip");
                a.Zip = Convert.ToString(Console.ReadLine());
                addbook.Add(a.Zip);
                Console.WriteLine("Enter Phone Number");
                a.PhoneNumber = Convert.ToString(Console.ReadLine());
                addbook.Add(a.PhoneNumber);
                Console.WriteLine("Enter Email");
                a.Email = Convert.ToString(Console.ReadLine());
                addbook.Add(a.Email);

                Console.WriteLine("\nGiven Detail Are : \n");   //it prints all the addressbook details
                Console.WriteLine("First Name = " + addbook[0]);
                Console.WriteLine("Last Name = " + addbook[1]);
                Console.WriteLine("Address = " + addbook[2]);
                Console.WriteLine("City = " + addbook[3]);
                Console.WriteLine("State = " + addbook[4]);
                Console.WriteLine("Zip = " + addbook[5]);
                Console.WriteLine("Phone Number = " + addbook[6]);
                Console.WriteLine("Email = " + addbook[7]);



            }
        }
    }
}