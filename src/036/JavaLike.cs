public class JavaLike
{
    // private fields - stage 1 in security
    private string Name;
    private int Age;

    // I still need to give my program access
    public string GetName()
    {
        return Name;
    }
    public void SetName(string value)
    {
        Name = value;
    }

    public int GetAge()
    {
        return Age;
    }
    public void SetAge(int value)
    {
        Age = value;
    }
}