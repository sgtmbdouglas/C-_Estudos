// someLocation irá inicializar com os valores de latitude e longitude fornecidos
Coordinate someLocation = new Coordinate(-19.9222072, -43.9339879);

// anotherLocation irá inicializar com os valores de latitude e longitude iguais a 0
Coordinate anotherLocation = new Coordinate();

struct Coordinate
{
    public double Latitude;
    public double Longitude;

    public Coordinate(double latitude, double longitude)
    {
        Latitude = latitude;
        Longitude = longitude;
    }
}
