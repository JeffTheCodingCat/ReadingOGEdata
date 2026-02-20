namespace ReadingOGEdata;

class Program
{
    static void Main(string[] args)
    {
        List<AccessItem> data = Read();

    }
    public static List<AccessItem> Read()
    {
        string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "OGEdata.csv");
        using StreamReader reader = new StreamReader(filePath);
        List<AccessItem> records = new List<AccessItem>();
        reader.ReadLine();
        string line;
        while ((line = reader.ReadLine()) != null)
        {
            string[] parts = line.Split(',');
            AccessItem accitem = new AccessItem
            {
                Display_Name = parts[0],
                First_Name = parts[1],
                Last_Name = parts[2],
                Work_Email = parts[3],
                if(parts[4] == "active"){ cloudLifecycleState = true; }else{ cloudLifycycleState = false; },
                IdentityID = parts[5],
                IsManager = parts[6],
                Department = parts[7],
                jobTitle = parts[8],
                uid = parts[9],
                Access_Type = parts[10],
                Access_Source_Name = parts[11],
                Access_Display_Name = parts[12],
                Access_Description = parts[13]
            }
        }
        reader.Close();
        return null;
    }
}


public struct AccessItem
{
    public string Display_Name { get; set; }
    public string First_Name { get; set; }
    public string Last_Name { get; set; }
    public string Work_Email { get; set; }
    public bool cloudLifecycleState { get; set; }
    public string IdentityID { get; set; }
    public bool IsManager { get; set; }
    public string Department { get; set; }
    public string jobTitle { get; set; }
    public string uid { get; set; }
    public string Access_Type { get; set; }
    public string Access_Source_Name { get; set; }
    public string Access_Display_Name { get; set; }
    public string Access_Description { get; set; }

}
