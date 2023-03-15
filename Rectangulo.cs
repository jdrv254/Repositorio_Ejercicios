namespace figuras;

class Rectangulo : IFigura{
    public int alto {get; set;}
    public int ancho {get; set;}
    public int area()
    {
        return this.alto*this.ancho;
    }
}