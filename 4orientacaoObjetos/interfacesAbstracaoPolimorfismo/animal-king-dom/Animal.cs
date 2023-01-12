// using System;

public abstract class Animal
{
    public abstract string ScientificName { get; }
    public abstract bool CanEatMeat { get; }
    public abstract bool CanEaVegetables { get; }

    public void Eat()
    {
        var animal = this.GetType().Name.ToLower();
        string food;
        if (CanEatMeat && CanEaVegetables)
        {
            var randon = new Random();
            food = randon.Next(0, 2) == 0 ? "meat" : "vegetables";
        }
        else if (CanEatMeat) food = "meat";
        else if (CanEaVegetables) food = "vegetables";
        else throw new InvalidOperationException($"{animal} can`t eat anything!");
        Console.WriteLine($"The {animal} has eaten some {food}");
    }
}