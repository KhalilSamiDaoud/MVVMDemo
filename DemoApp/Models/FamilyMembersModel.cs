namespace DemoApp.Models
{
    public class FamilyMembersModel
    {
        public int FamilyOf    { get; set; }
        public int ID          { get; set; }
        public string Name     { get; set; }
        public string Standing { get; set; }

        public FamilyMembersModel(int _familyOf, int _id, string _name, string _standing)
        {
            this.FamilyOf = _familyOf;
            this.ID = _id;
            this.Name = _name;
            this.Standing = _standing;
        }

        public string ToEntry()
        {
            return "*|" + FamilyOf.ToString() + "|" + ID.ToString() + "|" + Name + "|" + Standing;
        }
    }
}
