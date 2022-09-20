﻿namespace FluentValidationAPI.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Credit { get; set; }
        public int Age { get; set; }
        public int Phone { get; set; }
        public string Email { get; set; }
        public bool Enabled { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public Address Address { get; set; }
        public RegistrationStatus RegistrationStatus { get; set; }
    }

    public enum RegistrationStatus
    {
        WaitingApproval = 1,
        Aproved = 2,
        Notice = 3
    }
}
