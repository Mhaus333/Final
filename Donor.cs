using System;
namespace Patient
{
    public class Donor
    {
        
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string BloodType { get; set; }
        public string Address { get; set; }
        public DateTime Birthday { get; set; }

        public Donor()
        {

        }

        public Donor(string lastName, string firstName, string bloodType, string address, DateTime birthday)
        {
            LastName = lastName;
            FirstName = firstName;
            BloodType = bloodType;
            Address = address;
            Birthday = birthday;
        }
    }


        }

   
