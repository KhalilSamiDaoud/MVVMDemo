using static DemoApp.Includes.Constants;
using Stylet;

namespace DemoApp.ViewModels
{
    public class ViewEmployeesViewModel : Conductor<IScreen>
    {
        private MainWindowViewModel mainWindow;

        public ViewEmployeesViewModel(MainWindowViewModel _mainWindow)
        {
            mainWindow = _mainWindow;
        }

        public void LoadMainMenu()
        {
            mainWindow.SetNewScreen(Screens.MENU);
        }
    }
}
