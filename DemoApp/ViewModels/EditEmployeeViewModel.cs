using Stylet;

namespace DemoApp.ViewModels
{
    public class EditEmployeeViewModel : Screen
    {
        private MainWindowViewModel mainWindow;
        public EditEmployeeViewModel(MainWindowViewModel _mainWindow)
        {
            this.mainWindow = _mainWindow;
        }

        public void LoadMainMenu()
        {

        }
    }
}
