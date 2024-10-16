using System;
using System.ComponentModel.DataAnnotations;

namespace Blood_Banking_Project
    
{
    public class BloodType
    {
        public BloodType BloodTypes { get; set; }
        private string BloodGroup { get; set; }
        private string RhFactor { get; set; }



        public enum EnumBloodType
        {
            [Display(Name = "O+")]
            OPositive,
            [Display(Name = "A+")]
            APositive,
            [Display(Name = "B+")]
            BPositive,
            [Display(Name = "AB+")]
            ABPositive,
            [Display(Name = "O-")]
            ONegative,
            [Display(Name = "A-")]
            ANegative,
            [Display(Name = "B-")]
            BNegative,
            [Display(Name = "AB-")]
            ABNegative,
        }

        public bool IsCompatibleWith(BloodType otherBloodType)
        {
            // Compatibility logic

            if (this.BloodGroup == "O" && otherBloodType.BloodGroup != "O")
                return false;

            if (this.BloodGroup == "A" && otherBloodType.BloodGroup != "A")
                return false;

            if (this.BloodGroup == "B" && otherBloodType.BloodGroup != "B")
                return false;


            if (this.BloodGroup == "AB" && otherBloodType.BloodGroup == "O")
                return false;


            if (this.RhFactor == "negative" && otherBloodType.RhFactor == "positive")
                return false;
            if (this.RhFactor == "positive" && otherBloodType.RhFactor == "negative")
                return true;
            return true; // If no incompatibility found -- method type signature is declared as a boolean or true/false
        }
    }
}



