// Em uma struct é permitido que se utilize construtor e métodos para se ter mais controle dos valores manipulados, veja na alteração a seguir:

//Incializando  struct com construtor
Schedule now = new Schedule(10,30,0,"AM");
Console.WriteLine("Horario: "+ now.getSchedule());
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

// Note que para esta nova implementação foi utilizado o comando new que aciona o construtor da struct , esse por sua vez recebe os valores via passagem de parâmetros e atribui as propriedades internas da struct.