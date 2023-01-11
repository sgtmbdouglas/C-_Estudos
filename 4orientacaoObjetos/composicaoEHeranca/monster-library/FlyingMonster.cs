namespace monster_library;
public class FlyingMonster: Monster
{
    // public string Name {get; set;}
    public bool IsFlying {get; set;} = false;

    public void Fly()
    {
        Console.WriteLine($"{Name} is flying now!");
        IsFlying = true;
    }

    public void Descend()
    {
        Console.WriteLine($"{Name} is now on the ground");
        IsFlying = false;
    }
}
