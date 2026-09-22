using System.Diagnostics.CodeAnalysis;

int[] notas = { 18, 20, 15, 12};

Console.WriteLine("Notas del estudiante: ");
for (int i = 0; i < notas.Length; i++)
{
    Console.WriteLine($"Nota {i+1}: {notas[i]}");
}
//Calcular el promedio de las notas
int suma = 0; //Suma cada nota a la variablee
for (int i = 0; i < notas.Length; i++)
{
    suma += notas[i]; // Suma cada nota a la variable suma
}
double promedio = (double)suma/notas.Length;
Console.WriteLine($"Promedio: {promedio:F2}"); //Calcular el promedio