string[] meses = new string[12]{"Enero","Febrero","Marzo","Abril","Mayo","Junio","Julio","Agosto","Septiembre","Octubre","Noviembre","Diciembre"};
int[] cumpleaños = new int[12];
int i = 0;
int a = 0;
int maximo = 0;
int minimo = 0;
string Mx ="";
string Mn ="";
double total_cump = 0;

while ( i < 12)
{
    Console.WriteLine("Cuantos cumplen en: "+meses[i]);
    int cumple_año = Int32.Parse(Console.ReadLine());
    cumpleaños[a] = cumple_año;
    if(cumpleaños[a] > maximo){
        maximo = cumpleaños[a];
        Mx = meses[i];
    }
    if(cumpleaños[a] <= minimo){
        minimo = cumpleaños[a];
        Mn = meses[i];
    }
        Console.WriteLine("En el mes "+meses[i]+" Cumplen "+cumpleaños[a]+" persona/s");
        i = i +1;
        total_cump = total_cump + cumpleaños[a];
        a = a + 1;
        
}

    Console.WriteLine("El mes con más cumpleaños es: "+Mx);
    Console.WriteLine("El mes con más cumpleaños es: "+Mn);
    Console.WriteLine("El promedio de cumpleaños por mes es : "+(total_cump-1)/12);
