namespace ReadingOGEdata;

class Program
{
    static void Main(string[] args)
    {
        List<AccessItem> data = Read();
        Console.WriteLine($"Total records read: {data.Count}");
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
            string[] columns = line.Split(',');
            AccessItem accitem = new AccessItem
            {
                Display_Name = columns[0],
                First_Name = columns[1],
                Last_Name = columns[2],
                Work_Email = columns[3],
                cloudLifecycleState = columns[4],
                IdentityID = columns[5],
                IsManager = columns[6],
                Department = columns[7],
                jobTitle = columns[8],
                uid = columns[9],
                Access_Type = columns[10],
                Access_Source_Name = columns[11],
                Access_Display_Name = columns[12],
                Access_Description = columns[13]
            };
            records.Add(accitem);
        }
        reader.Close();
        return records;
    }
}


public struct AccessItem
{
    public string Display_Name { get; set; }
    public string First_Name { get; set; }
    public string Last_Name { get; set; }
    public string Work_Email { get; set; }
    public string cloudLifecycleState { get; set; }
    public string IdentityID { get; set; }
    public string IsManager { get; set; }
    public string Department { get; set; }
    public string jobTitle { get; set; }
    public string uid { get; set; }
    public string Access_Type { get; set; }
    public string Access_Source_Name { get; set; }
    public string Access_Display_Name { get; set; }
    public string Access_Description { get; set; }

}
