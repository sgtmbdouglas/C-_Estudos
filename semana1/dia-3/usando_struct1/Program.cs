//utilizando uma struct

Schedule now;
now.hour = 10;
now.minute = 30;
now.shift = "AM";
Console.WriteLine("Horário: " + now.hour + ":" + now.minute + " " + now.shift);
//Criando uma struct
struct Schedule
{
    public int hour, minute, second;
    public string shift;
}
