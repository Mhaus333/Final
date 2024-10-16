using System;  

namespace Patient
{
    public class Patient1
    {
        private string v1;
        private string v2;
        private string v3;
        private string v4;
        private int v;
        private string v5;
        private string v6;

        public Patient1(string v1, string v2, string v3, string v4, string v5, string v6)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
            this.v4 = v4;
            this.v5 = v5;
            this.v6 = v6;
        }

        public Patient1(int v, string v1, string v2, string v3, string v4, string v5, string v6)
        {
            this.MedicalRecordNumber = MedicalRecordNumber;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Birthday = Birthday;
            this.BloodType = BloodType;
            this.Hemoglobin = Hemoglobin;
        }

        //properties
        public int MedicalRecordNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set;  }
        public DateTime Birthday { get; set; }
        public string BloodType { get; set; }
        public string SocialSecurity { get; set; }
        public double Hemoglobin { get; set; }
        public string Age
        {
            get { return getAge(); }
        }

        public void display()
        {
            Console.WriteLine("Patient Information:");
            Console.WriteLine($"Medical Record Number: {MedicalRecordNumber}");
            Console.WriteLine($"First Name: {FirstName}");
            Console.WriteLine($"Last Name: {LastName}");
            Console.WriteLine($"Birthday: {Birthday.ToShortDateString()}");
            Console.WriteLine($"Blood Type: {BloodType}");
            Console.WriteLine($"Social Secrutiy No.: {SocialSecurity}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Hemoglobin: {Hemoglobin}");

        }

        private string getAge()
        {
            if (Birthday == DateTime.MinValue)
            {
                return "Unknown";
            }
            return (DateTime.Now.Year - Birthday.Year).ToString();
        }
       
        }

    }