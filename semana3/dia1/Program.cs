namespace jogo_da_velha{

    public class Program
    {    
        public static void Main(string[] args)
        {
            // JogoDaVelha Game = new();
            var Game = new JogoDaVelha();
            Game.Movimento(2, 2, 'x');             
        }   
    }
}







        // Game.RandomNumber();
        // do
        // {
        //     Game.ChooseNumber();
        //     Game.AnalyzePlay();
        // }while(Game.randomValue != Game.userValue);