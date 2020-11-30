using static DemoApp.Includes.Constants;
using DemoApp.Includes;
using DemoApp.Models;
using Stylet;

namespace DemoApp.ViewModels
{
    public class ViewEmployeesViewModel : Conductor<IScreen>.Collection.OneActive
    {
        private MainWindowViewModel mainWindow;
        private EmployeeAccess myEmployeeDatabase;
        private EmployeeModel _selectedEmployee;

        public BindableCollection<EmployeeModel> myEmployees { get; set; }

        public ViewEmployeesViewModel(MainWindowViewModel _mainWindow)
        {
            mainWindow = _mainWindow;
            myEmployeeDatabase = new EmployeeAccess();
            myEmployees = new BindableCollection<EmployeeModel>();

            RetreiveEmployees();
        }

        public EmployeeModel SelectedEmployee
        {
            get { return _selectedEmployee;  }
            set
            {
                this._selectedEmployee = value;

                this.Items.Add(new EmployeeViewModel());
                //NotifyOfPropertyChange(() => )
            }
        }

        public void RetreiveEmployees()
        {
            string[] employees = myEmployeeDatabase.GetEmployees();

            foreach(string x in employees)
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
