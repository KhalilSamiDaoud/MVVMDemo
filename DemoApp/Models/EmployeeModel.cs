namespace DemoApp.Models
{
    public class EmployeeModel
    {
        public string ID            { get; set; }
        public string FamilyMembers { get; set; }
        public string Name          { get; set; }
        public string Position      { get; set; }
        public string Address       { get; set; }

        public EmployeeModel(string dataEntry)
        {
            ProcessDataEntry(dataEntry);
        }

        private void ProcessDataEntry(string data)
        {
            string[] tokens = data.Split('|');

            this.ID            = tokens[0];
            this.Name          = tokens[1];
            this.Position      = tokens[2];
            this.Address       = tokens[3];
            this.FamilyMembers = tokens[4];
        }

        public string ToEntry()
        {
            return ID + "|" + Name + "|" + Position + "|" + Address + "|" + FamilyMembers;
        }
    }
}
