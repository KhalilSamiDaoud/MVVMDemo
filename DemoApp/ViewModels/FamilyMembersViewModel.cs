using DemoApp.Models;
using Stylet;

namespace DemoApp.ViewModels
{
    public class FamilyMembersViewModel : Screen
    {
        public FamilyMembersModel FamilyMember { get; set; }

        public FamilyMembersViewModel(FamilyMembersModel _familyMember)
        {
            FamilyMember = _familyMember;

            DisplayName = FamilyMember.Name;
        }

        public string FamilyOf
        {
            get { return "Employee ID: " + FamilyMember.FamilyOf; }
        }

        public string ID
        {
            get { return "Family Member ID: " + FamilyMember.ID; }
        }

        public string Name
        {
            get { return "Name [First Last]: " + FamilyMember.Name; }
        }

        public string Standing
        {
            get { return "Relationship : " + FamilyMember.Standing; }
        }
    }
}
