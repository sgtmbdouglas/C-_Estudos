namespace Students;
public static class Class1
{
    public static List<string> Start()
    {
        var schoolClass = new List<string>();
        return schoolClass;
    }
    public static List<string> AddStudents(List<string> schooClass, string name)
    {
        schooClass.Add(name);
        return schooClass;
    }
    public static List<string> OrderStudents(List<string> schooClass)
    {
        schooClass.Sort();
        return schooClass;
    }
    public static List<string> RemoveStudents(List<string> schooClass, string name)
    {
        schooClass.Remove(name);
        return schooClass;
    }
}
