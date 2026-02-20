namespace ReadingOGEdata;

class Program
{
    static void Main(string[] args)
    {
        string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "OGEdata.csv");
        using StreamReader reader = new StreamReader(filePath);
        reader.ReadLine();
        string line;

        while ((line = reader.ReadLine()) != null)
        {
            string[] words = line.Split(',');
            //
            if ()
            {
            }
            else
            {
            }
        }
        reader.Close();
    }
}


public struct Employee
{
    public Employee(string Display_Name, string First_Name, string Last_Name, string Work_Email, string cloudLifecycleState, string IdentityID, bool IsManager, string Department, string jobTitle, string uid, string Access_Type, string Access_Source_Name, string Access_Display_Name, string Access_Description)
    {
        this.Display_Name = Display_Name;
        this.First_Name = First_Name;
        this.Last_Name = Last_Name;
        this.Work_Email = Work_Email;
        if(cloudLifecycleState == "active"){ this.cloudLifecycleState = true; }else{ this.cloudLifecycleState = false; }
        this.IdentityID = IdentityID;
        this.IsManager = IsManager;
        this.Department = Department;
        this.jobTitle = jobTitle;
        this.uid = uid;
        this.Access_Type = Access_Type;
        this.Access_Source_Name = Access_Source_Name;
        this.Access_Display_Name = Access_Display_Name;
        this.Access_Description = Access_Description;
    }
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
