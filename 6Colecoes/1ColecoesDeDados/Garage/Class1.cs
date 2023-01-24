namespace Garage;

public class Garage
{
    public List<string> Vehicles { get; set; } = new List<string>();

    public int AddVehicle(string vehicle)
    {
        Vehicles.Add(vehicle);

        return Vehicles.Count;
        // Todo objeto do tipo List<T> contém o atributo Count, que nos diz a quantidade atual de elementos na lista.
    }

    public int RemoveVehicle(string vehicle)
    {
        Vehicles.Remove(vehicle);

        return Vehicles.Count;
    }

    public int FindVehiclePosition(string vehicle)
    {
        return Vehicles.IndexOf(vehicle);
    }
}