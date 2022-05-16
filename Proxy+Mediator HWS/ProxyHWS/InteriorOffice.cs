using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy_Mediator_HWS
{
    public class InteriorOffice : IInteriorOffice, IServiceMachine
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public float BirthDate { get; set; }
        public string Location { get; set; }
        public int ID { get; set; }
        public int Passportexp { get; set; }

        public InteriorOffice(string firstname, string lastname, float birthDate, string location, int iD, int passportexp)
        {
            Firstname = firstname;
            Lastname = lastname;
            BirthDate = birthDate;
            Location = location;
            ID = iD;
            Passportexp = passportexp;
        }

        public void BirthCert()
        {
            Console.WriteLine($"the child {Firstname + Lastname} born at {BirthDate}.");
        }

        public void ChangeFirstName()
        {
            Console.WriteLine("Type the first name you want");
            string Newfirstname = Console.ReadLine();
            this.Firstname = Newfirstname;
            Console.WriteLine($"Your new first name is {this.Firstname}");
        }

        public void ChangeLastName()
        {
            Console.WriteLine("Type the last name you want");
            string Newlastname = Console.ReadLine();
            this.Lastname = Newlastname;
            Console.WriteLine($"Your new last name is {this.Lastname}");
        }

        public void ChangeLocation()
        {
            Console.WriteLine("Type the location you want");
            string Newlocation = Console.ReadLine();
            this.Location = Newlocation;
            Console.WriteLine($"Your new location is {this.Location}");
        }

        public void RenewPassport()
        {
            Console.WriteLine("type the year your passport is expired");
            int PassExp=int.Parse(Console.ReadLine());
            this.Passportexp=PassExp+10;
            Console.WriteLine($"your new Passport exp date is {PassExp}")
        }

        public void WatchInfo()
        {
            Console.WriteLine($"{Firstname}\n{Lastname}\n{BirthDate}\n{ID}\n{Location}");
        }
    }
}
