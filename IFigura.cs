namespace figuras;

interface IFigura
{
    public int alto {get; set;} //Propiedades de la clase que se heredan en los objetos

    public int ancho {get; set;} 

    public int area();

}