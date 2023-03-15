using figuras;

Cuadrado cuadrado = new Cuadrado(); //Tipos de valor por referencia

cuadrado.alto = 10;
cuadrado.ancho = 10;

Console.WriteLine("Area de un cuadrado: "+cuadrado.area());

Triangulo triangulo = new Triangulo(5,5); // Aplicación del metodo constructor

Console.WriteLine("Area de un triangulo: "+triangulo.area()); // No me interesa como se calcula el area, si no que me traiga el area = encapsulamiento                                       