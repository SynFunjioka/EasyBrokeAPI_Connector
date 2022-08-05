namespace EasyBrokeAPI_Connector.Model.Location
{
    public class LocalityModel
    {
        public LocalityModel(string name, string fullName, string type)
        {
            Name = name;
            FullName = fullName;
            Type = type;
        }

        public string Name { get; set; }
        public string FullName { get; set; }
        public string Type { get; set; }
    }
}