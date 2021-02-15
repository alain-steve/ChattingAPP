using System;

namespace API.Extensions
{
    public static class DateTimeExtensions
    {
        public static int CalculateAge(this DateTime dob)
        {
            var today = DateTime.Now;
            var age = today.Year - dob.Year;
            //  date of dob > date of today(but in dob year hence the {-age}) 
            // it implies that the year is the same here and is ignored, we are comparing only dates
            //to determine if the birthday has passed or not          
            if (dob.Date > today.AddYears(-age))
            {
                // if the birth date hasn't passed then we remove 1 from the age
                age--;
            }
            return age;
        }
    }
}