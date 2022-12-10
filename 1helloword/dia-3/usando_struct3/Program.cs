﻿// Outra possibilidade permitida ao se utilizar struct é a capacidade de atribuir uma struct completa já inicializada para outra, veja a seguir:
//Incializando uma struct com construtor
Schedule now = new Schedule(10,30,0,"AM");
Console.WriteLine("Horario: "+now.getSchedule());

//atribuindo uma struct iniciada para uma nova struct
Schedule now2 = now;
Console.WriteLine("Horario2: "+now2.getSchedule());
//Criando uma struct
struct Schedule
{
    private int hour, minute, second;
    private string shift;

    //Construtor da struct
    public Schedule(int hour, int minute, int second, string shif) 
    { 
        this.hour = hour % 24;
        this.minute = minute % 60;
        this.second = second % 60;
        this.shift = shif;
    }
    // metodo da struct
    public string getSchedule() 
    { 
        return hour.ToString()+ ":" + minute.ToString() + ":" + second.ToString()+" "+shift;
    }
}
