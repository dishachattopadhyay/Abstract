namespace StudentApi;
public class Student{
    public int Id{get;set;}
    public string Name{get; set;}=string.Empty;
    public int Age{get;set;}
    public string city{get;set;}=string.Empty;
    private int password ;
    public string Password 
    {
        set{
            password = value.GetHashCode();

        }

        get{
            return "";
        }
    }

}