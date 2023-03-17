namespace Tennis;

public class Torneo
{
    public string nombre;
    public int premio;
    public IJugador[] jugadores = new IJugador[2];
    private Random ramdom;

    public Torneo(string nombre, int premio)
    {
        this.nombre = nombre;
        this.premio = premio;
        this.ramdom = new Random();
    }

    public void AgregarJugador(IJugador jugador)
    {
        if(this.jugadores[0] != null)
        {
            this.jugadores[1] = jugador;
        } else{
            this.jugadores[0] = jugador;
        }

    }

    public int JugarSet()
    {
        return this.ramdom.Next(0,3);
    }

    public void JugarPartido()
    {
        int player1 = 0;
        int player2 = 0;

        for(int i = 0; i<5; i++)
        {
            if(this.JugarSet() == 1)
            {
                player1++;
            }else{
                player2++;
            }
        }
        if(player1 > player2)
        {
            Console.WriteLine($"Ganador es el jugador: {this.jugadores[0].nombre}");
        }else{
            Console.WriteLine($"Ganador es el jugador: {this.jugadores[0].nombre}");
        }
    }

}