namespace car.Test;

class Car
{
    public double _topSpeedKph;
    public double TopSpeed
    {
        get{return _topSpeedKph;}
        set{_topSpeedKph = value;}
    }

    public static double KphToMph(double kph)
    {
        return kph / 1.61;
    }
    public double TopSpeedMph
    {
        get { return Car.KphToMph(_topSpeedKph); }
    }

}