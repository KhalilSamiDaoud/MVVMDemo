using static DemoApp.Includes.Constants;
using DemoApp.Includes;
using DemoApp.Models;
using Stylet;
using System.Collections.Generic;

namespace DemoApp.ViewModels
{
    public class ViewEmployeesViewModel : Conductor<IScreen>.Collection.OneActive
    {
        private MainWindowViewModel mainWindow;
        private EmployeeAccess myEmployeeDatabase;
        private EmployeeModel _selectedEmployee;
        private List<FamilyMembersModel> myEmployeeFamily;
        public BindableCollection<EmployeeModel> myEmployees { get; set; }

        public ViewEmployeesViewModel(MainWindowViewModel _mainWindow)
        {
            mainWindow = _mainWindow;

            myEmployeeDatabase = new EmployeeAccess();
            myEmployees        = new BindableCollection<EmployeeModel>();
            myEmployeeFamily   = new List<FamilyMembersModel>();

            RetreiveEmployees();
        }

        public EmployeeModel SelectedEmployee
        {
            get { return _selectedEmployee;  }
            set
            {
                _selectedEmployee = value;

                UpdateCurrentEmployee(value);
            }
        }

        private void UpdateCurrentEmployee(EmployeeModel employee)
        {
            Items.Clear();
            Items.Add(new EmployeeViewModel(employee));

            myEmployeeFamily.Clear();
            RetreiveEmployeeFamily(employee);

            foreach (var x in myEmployeeFamily)
            {
                Items.Add(new FamilyMembersViewModel(x));
            }
        }

        public void RetreiveEmployeeFamily(EmployeeModel employee)
        {
            string[] family = myEmployeeDatabase.GetEmployeeFamily(employee.ID);

            foreach(var x in family)
            {
                myEmployeeFamily.Add(new FamilyMembersModel(x));
            }
        }

        public void RetreiveEmployees()
        {
            string[] employees = myEmployeeDatabase.GetEmployees();

            foreach(var x in employees)
            {
                myEmployees.Add(new EmployeeModel(x));
            }

            NotifyOfPropertyChange(() => myEmployees);
        }

        public void LoadMainMenu()
        {
            mainWindow.SetNewScreen(Screens.MENU);
        }
    }
}
