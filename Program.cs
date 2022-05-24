// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int[] array = { 1, 2, 3, 4, 5 };
int resto =0;
int total = 0;

foreach(var valor in array)
{
    resto = valor % 2;
    if(resto == 0)
    {
        Console.WriteLine(valor);
        total += valor;
    }
}

Console.WriteLine($"Total: {total}");