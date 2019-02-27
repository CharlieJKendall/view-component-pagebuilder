using System;

namespace ViewComponentsTest.Models.DataModels
{
    public class CustomerModel
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime DateOfBirth { get; set; }

        public CustomerModel(string firstName, string lastName, DateTime dateOfBirth)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.DateOfBirth = dateOfBirth;
        }
    }
}
