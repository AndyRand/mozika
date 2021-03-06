using System;
using System.Collections.Generic;
using Mozika.Domain.Converters;
using Mozika.Domain.Entities;

namespace Mozika.Domain.ApiModels
{
    public class EmployeeApiModel : IConvertModel<EmployeeApiModel, Employee>
    {
        public int EmployeeId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Title { get; set; }
        public int? ReportsTo { get; set; }
        public string ReportsToName { get; set; }
        public DateTime? BirthDate { get; set; }
        public DateTime? HireDate { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string PostalCode { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public List<CustomerApiModel> Customers { get; set; }
        public EmployeeApiModel Manager { get; set; }
        public ICollection<EmployeeApiModel> DirectReports { get; set; }

        public Employee Convert() =>
            new Employee
            {
                EmployeeId = EmployeeId,
                LastName = LastName,
                FirstName = FirstName,
                Title = Title,
                ReportsTo = ReportsTo,
                BirthDate = BirthDate,
                HireDate = HireDate,
                Address = Address,
                City = City,
                State = State,
                Country = Country,
                PostalCode = PostalCode,
                Phone = Phone,
                Fax = Fax,
                Email = Email
            };
    }
}