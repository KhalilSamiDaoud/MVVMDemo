using static DemoApp.Includes.Constants;
using DemoApp.Events;
using Stylet;
using DemoApp.Includes;

namespace DemoApp.ViewModels
{
    public class MainWindowViewModel : Conductor<IScreen>, IHandle<PersonAddedEvent>
    {
        private string _employeesTracked;
        private EventAggregator myEventAggregator;
        private EmployeeAccess myEmployeeDatabase;

        public MainWindowViewModel()
        {
            myEventAggregator = EventAggregatorSG.Instance.getAggregator();
            myEventAggregator.Subscribe(this);

            myEmployeeDatabase = new EmployeeAccess();

            CountEmployees();
            ActivateItem(new MenuViewModel(this));
        }

        public void SetNewScreen(Screens newView)
        {
            switch (newView)
            {
                case Screens.MENU:
                    ActivateItem(new MenuViewModel(this));
                    break;
                case Screens.ADD_EMPLOYEES:
                    ActivateItem(new AddEmployeeViewModel(this));
                    break;
                case Screens.VIEW_EMPLOYEES:
                    ActivateItem(new ViewEmployeesViewModel(this));
                    break;
                default:
                    break;
            }
        }

        public string EmployeesTracked
        {
            get { return _employeesTracked; }
            set
            {
                _employeesTracked = "Employees In System: " + value;

                NotifyOfPropertyChange(() => EmployeesTracked);
            }
        }

        private void CountEmployees()
        {
            string[] employees = myEmployeeDatabase.GetEmployees();

            EmployeesTracked = employees.Length.ToString();
        }

        public void Handle(PersonAddedEvent message)
        {
            CountEmployees();
        }
    }
}
