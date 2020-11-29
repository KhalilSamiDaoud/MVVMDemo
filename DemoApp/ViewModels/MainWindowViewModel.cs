using static DemoApp.Includes.Constants;
using Stylet;

namespace DemoApp.ViewModels
{
    public class MainWindowViewModel : Conductor<IScreen>
    {
        public MainWindowViewModel()
        {
            ActivateItem(new MenuViewModel(this));
        }

        public void SetNewScreen(Screens newView)
        {
            switch (newView)
            {
                case Screens.MENU:
                    ActivateItem(new MenuViewModel(this));
                    break;
                case Screens.EDIT_EMPLOYEES:
                    ActivateItem(new EditEmployeeViewModel(this));
                    break;
                case Screens.VIEW_EMPLOYEES:
                    ActivateItem(new ViewEmployeesViewModel(this));
                    break;
                default:
                    break;
            }
        }
    }
}
