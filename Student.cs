using System;

namespace Buffteks3
{
    public class Student
    {
        //PK
        public int StudentID{ get; set; }
        //First Name
        public string FirstName { get; set; }
        //Last name
        public string LastName { get; set; }        
        //phone
        public string PhoneNumber { get; set; }
        //email
        public string Email {get; set; }
        //role
        public string Role { get; set; }

        public override string ToString()
        {
            string output = $"{this.FirstName} {this.LastName}";
            return output;
        }

    }

}