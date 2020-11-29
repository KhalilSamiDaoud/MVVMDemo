﻿using static DemoApp.Includes.Constants;
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
            mainWindow.SetNewScreen(Screens.MENU);
        }
    }
}
