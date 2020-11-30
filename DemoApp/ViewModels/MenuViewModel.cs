using static DemoApp.Includes.Constants;
using Stylet;

namespace DemoApp.ViewModels
{
    public class MenuViewModel : Screen
    {
        private MainWindowViewModel mainWindow;
        public MenuViewModel(MainWindowViewModel _mainWindow)
        {
            mainWindow = _mainWindow;
        }

        public void LoadAddEmployees()
        {
            mainWindow.SetNewScreen(Screens.ADD_EMPLOYEES);
        }

        public void LoadViewEmployees()
        {
            mainWindow.SetNewScreen(Screens.VIEW_EMPLOYEES);
        }

        public void Exit()
        {
            mainWindow.RequestClose();
        }
    }
}
