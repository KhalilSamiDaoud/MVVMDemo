using Stylet;
using System.Diagnostics;

namespace DemoApp.ViewModels
{
    public class ShellViewModel : Screen
    {
        public string HelloWorld;
        public ShellViewModel()
        {
        }

        private string _name;
        public string Name
        {
            get { return this._name; }
            set { SetAndNotify(ref this._name, value); }
        }

        public void HelloWorldConsole()
        {
            Name = "Khalil";

            Debug.WriteLine("Hello World!");
        } 
    }
}
