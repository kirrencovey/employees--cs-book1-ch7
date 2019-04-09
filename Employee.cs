using System;
using System.Collections.Generic;

namespace classes
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public DateTime StartDate { get; }
        public Employee (string startDate) {
            StartDate = Convert.ToDateTime(startDate);
        }
    }
}