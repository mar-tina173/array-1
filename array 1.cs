// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int[] notas = new int[5];
string[] estudiantes = new string[] { "vale", "ivan", "cami" };
int[] promedio = new int[estudiantes.Length];

for (int i = 0; i < estudiantes.Length; i++)
{
    Console.WriteLine($"{estudiantes[i]} por favor ingrese sus 5 calificaciones");
    for (int j = 0; j < notas.Length; j++)
    {
        notas[j] = Convert.ToInt16(Console.ReadLine());
        promedio[i] = promedio[i] + notas[j];
    }
}
for (int i = 0; i < estudiantes.Length; i++)
{
    Console.WriteLine($"{estudiantes[i]}, usted obtuvo un promedio de {promedio[i] / 5}");
}

