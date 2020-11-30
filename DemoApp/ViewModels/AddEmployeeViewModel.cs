using static DemoApp.Includes.Constants;
using DemoApp.Includes;
using Stylet;
using System.Windows;
using DemoApp.Events;

namespace DemoApp.ViewModels
{
    public class AddEmployeeViewModel : Screen
    {
        private MainWindowViewModel mainWindow;
        private EmployeeAccess myEmployeeDatabase;
        private EventAggregator myEventAggregator;

        public string ID            { get; set; }
        public string Name          { get; set; }
        public string Address       { get; set; }
        public string Standing      { get; set; }
        public string Position      { get; set; }
        public string FamilyMembers { get; set; }
        public string FamilyOf      { get; set; }

        public bool IsFamilyVis     { get; set; }
        public bool IsEmployeeVis   { get; set; }

        public Visibility EmployeeVisibility { get; set; }
        public Visibility FamilyVisibility   { get; set; }

        public AddEmployeeViewModel(MainWindowViewModel _mainWindow)
        {
            mainWindow = _mainWindow;

            myEventAggregator = EventAggregatorSG.Instance.getAggregator();

            myEmployeeDatabase = new EmployeeAccess();

            IsFamilyVis   = false;
            IsEmployeeVis = true;

            EmployeeVisibility = Visibility.Visible;
            FamilyVisibility   = Visibility.Hidden;
        }

        public void ChangeVisibility()
        {
            if (IsFamilyVis)
            {
                IsFamilyVis   = false;
                IsEmployeeVis = true;

                EmployeeVisibility = Visibility.Visible;
                FamilyVisibility   = Visibility.Hidden;

            }
            else
            {
                IsFamilyVis   = true;
                IsEmployeeVis = false;

                EmployeeVisibility = Visibility.Hidden;
                FamilyVisibility   = Visibility.Visible;
            }

            ClearTextBox();

            NotifyOfPropertyChange(() => EmployeeVisibility);
            NotifyOfPropertyChange(() => FamilyVisibility);
            NotifyOfPropertyChange(() => IsEmployeeVis);
            NotifyOfPropertyChange(() => IsFamilyVis);
        }

        private void ClearTextBox()
        {
            ID            = "";
            Name          = "";
            Standing      = "";
            Position      = "";
            Address       = "";
            FamilyMembers = "";
            FamilyOf      = "";

            NotifyOfPropertyChange(() => ID);
            NotifyOfPropertyChange(() => Name);
            NotifyOfPropertyChange(() => Standing);
            NotifyOfPropertyChange(() => Position);
            NotifyOfPropertyChange(() => Address);
            NotifyOfPropertyChange(() => FamilyMembers);
            NotifyOfPropertyChange(() => FamilyOf);
        }
        public void AddToDatabase()
        {
            if (IsFamilyVis)
            {
                myEmployeeDatabase.AddPerson("*|" + FamilyOf + "|" + ID + "|" + Name + "|" + Standing);
            }
            else
            {
                myEmployeeDatabase.AddPerson(ID + "|" + Name + "|" + Position + "|" + Address + "|" + FamilyMembers);

                myEventAggregator.Publish(new PersonAddedEvent());
            }

            ClearTextBox();
        }

        public void LoadMainMenu()
        {
            mainWindow.SetNewScreen(Screens.MENU);
        }
    }
}
