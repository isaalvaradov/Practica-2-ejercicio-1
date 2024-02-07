

Console.Write("Ingrese el número de filas de la matriz: ");
int filas = int.Parse(Console.ReadLine());

Console.Write("Ingrese el número de columnas de la matriz: ");
int columnas = int.Parse(Console.ReadLine());

int[,] matriz = new int[filas, columnas];
Random rand = new Random();


for (int f = 0; f < filas; f++)
{
    for (int c = 0; c < columnas; c++)
    {
        matriz[f, c] = rand.Next(100);
        Console.Write($"   {matriz[f, c]}");
    }
    Console.WriteLine();
}


int sumaEsquinas = matriz[0, 0] + matriz[0, columnas - 1] + matriz[filas - 1, 0] + matriz[filas - 1, columnas - 1];


Console.WriteLine($"La suma de las esquinas de la matriz es: {sumaEsquinas}");


