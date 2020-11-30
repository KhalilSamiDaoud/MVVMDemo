using DemoApp.Models;
using Stylet;

namespace DemoApp.ViewModels
{
    public class EmployeeViewModel : Screen
    {
        private EmployeeModel Employee { get; set; }

        public EmployeeViewModel(EmployeeModel _employee)
        {
            Employee = _employee;

            DisplayName = Employee.Name;
        }

        public string ID
        {
            get { return "Employee ID: " + Employee.ID; }
        }

        public string Name
        {
            get { return "Name [First Last]: " + Employee.Name; }
        }

        public string Address
        {
            get { return "Address: " + Employee.Address; }
        }

        public string Position
        {
            get { return "Position: " + Employee.Position; }
        }

        public string FamilyMembers
        {
            get { return "Family Members: " + Employee.FamilyMembers; }
        }
    }
}
