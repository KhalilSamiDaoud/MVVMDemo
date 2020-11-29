namespace DemoApp.Models
{
    public class EmployeeModel
    {
        public int ID { get; set; }
        public int FamilyMembers { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public string Address { get; set; }

        public EmployeeModel(int _id, int _familyMembers, string _name, string _position, string _address)
        {
            this.ID = _id;
            this.FamilyMembers = _familyMembers;
            this.Name = _name;
            this.Position = _position;
            this.Address = _address;
        }

        public string ToEntry()
        {
            return ID.ToString() + "|" + Name + "|" + Position + "|" + Address + "|" + FamilyMembers.ToString();
        }
    }
}
