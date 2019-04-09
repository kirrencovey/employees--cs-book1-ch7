using System;

namespace classes
{
    class Program
    {
        static void Main()
        {
            // Create an instance of a company. Name it whatever you like.
            Company NashvilleZoo = new Company("Nashville Zoo", "01/01/1998");

            // Create three employees
            Employee kCovey = new Employee("07/13/2013") {
                FirstName = "Kirren",
                LastName = "Covey",
                Title = "Hoofstock Keeper"
            };

            Employee kHackett = new Employee("03/17/2013") {
                FirstName = "Kayce",
                LastName = "Hackett",
                Title = "Bird Keeper"
            };

            Employee mMartino = new Employee("05/06/2010") {
                FirstName = "Matt",
                LastName = "Martino",
                Title = "Reptile Keeper"
            };

            // Assign the employees to the company

            NashvilleZoo.HireEmployee(kCovey);
            NashvilleZoo.HireEmployee(kHackett);
            NashvilleZoo.HireEmployee(mMartino);

            /*
                Iterate the company's employee list and generate the
                simple report shown above
            */

            NashvilleZoo.ListEmployees();
        }
    }
}
