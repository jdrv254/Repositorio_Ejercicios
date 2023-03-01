//Realizar una calculadora interactiva que permita sumar,restar,multiplicar y dividir 2 numeros



Console.WriteLine("--------Calculadora------\n Ingrese el numero de la operación que desea: \n 1.Sumar \n 2.Restar \n 3.Multiplicar \n 4.Dividir \n. 5.Salir ");
int opcion = Int32.Parse(Console.ReadLine());
do{
    if(opcion == 5){
        Environment.Exit(0);
    }
    Console.WriteLine("Ingrese el 1er numero: ");
    int x = Int32.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese el 2do numero: ");
    int y = Int32.Parse(Console.ReadLine());
    int resultado = 0;
    
    switch (opcion)
    {
        case 1:
            resultado = x+y;
            Console.WriteLine("La suma de los numeros es: "+resultado);
            Environment.Exit(0);
        break;
        case 2:
            resultado = x-y;
            Console.WriteLine("La suma de los numeros es: "+resultado);
            Environment.Exit(0);        
        break;
        case 3:
            resultado = x*y;
            Console.WriteLine("La suma de los numeros es: "+resultado);
            Environment.Exit(0);
        break;
        case 4:
            if(y == 0){
                Console.WriteLine("No se puede dividir por 0");
                Environment.Exit(0);

            }else{
                    resultado = x/y;
                    Console.WriteLine("La suma de los numeros es: "+resultado);
                    Environment.Exit(0);
            }
        break;
        
        default:
        Console.WriteLine("Opcion no valida");
        break;
    }
    // if(opcion == 1){
    // resultado = x+y;
    // Console.WriteLine("La suma de los numeros es: "+resultado);
    // Environment.Exit(0);   
    // }
    // if(opcion == 2){
    // resultado = x-y;
    // Console.WriteLine("La suma de los numeros es: "+resultado);
    // Environment.Exit(0);
    // }
    // if(opcion == 3){
    // resultado = x*y;
    // Console.WriteLine("La suma de los numeros es: "+resultado);
    // Environment.Exit(0);
    // }
    // if(opcion == 4){
    // resultado = x/y;
    // Console.WriteLine("La suma de los numeros es: "+resultado);
    // Environment.Exit(0);
    // }else{
    // Console.WriteLine("La opcion no esta en el menu");
    // }

}while ( opcion != 5);

