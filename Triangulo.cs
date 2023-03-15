namespace figuras;

class Triangulo : IFigura
{
    public Triangulo(int alto, int baseT) //Metodo constructor
    {
        this.alto = alto;
        this.ancho = baseT;
    }

    public int alto {get; set;} 

    public int ancho {get; set;}

    public int area()
    {
        return (this.alto*this.ancho)/2;
    }
}