using static DemoApp.Includes.Constants;
using Stylet;

namespace DemoApp.ViewModels
{
    public class MainWindowViewModel : Conductor<Screen>
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
                case Screens.EDIT_EMPLOYEE:
                    ActivateItem(new EditEmployeeViewModel(this));
                    break;
                default:
                    break;
            }
        }
    }
}
