// void WriteLine(string Message){
//     Console.WriteLine(Message);
// }

// WriteLine("Hola");

// int sumemelo(int x,int y){
//         return x+y;
// }

// Console.WriteLine(sumemelo(3,4));

// double dividamelo(int x,int y){
//         if (y == 0)
//         {
//             throw new ArgumentException($"No se puede dividir por el el numero {y}");
//         }
//         return x/y;
// }

// Console.WriteLine(dividamelo(1,0));

int[] Numero = new int[]{1,2,3,4,5,6,7,8,9,10};

int NumberPares(int[] k ){

    int aux =0;
    for (int i = 0; i < k.Length; i++)
    {
        if (k[i] % 2 == 0) aux++; 
    }

    return aux;
}


NumberPares(Numero);