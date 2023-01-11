namespace rocket.Test;

class Rocket
{
    public string Name = "Foguete";
    public string Country = "Apátrida";
    public double Speed;

    public Rocket()
    {
    }

    // string Name { get; set; }
    public Rocket(string nome, string country, double speed)
    {
        Name = nome;
        Country = country;
        Speed = speed;
    }
}