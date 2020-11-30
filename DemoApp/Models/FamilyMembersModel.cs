namespace DemoApp.Models
{
    public class FamilyMembersModel
    {
        public string FamilyOf    { get; set; }
        public string ID          { get; set; }
        public string Name        { get; set; }
        public string Standing    { get; set; }

        public FamilyMembersModel(string dataEntry)
        {
            ProcessDataEntry(dataEntry);
        }

        private void ProcessDataEntry(string data)
        {
            string[] tokens = data.Split('|');

            FamilyOf = tokens[1];
            ID       = tokens[2];
            Name     = tokens[3];
            Standing = tokens[4];
        }

        public string ToEntry()
        {
            return "*|" + FamilyOf+ "|" + ID + "|" + Name + "|" + Standing;
        }
    }
}
