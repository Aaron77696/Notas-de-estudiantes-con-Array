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

// Determinar la nota más alta y la más baja
int notaMasAlta = notas[0]; // Inicializar la nota más alta con la primera nota
int notaMasBaja = notas[0]; // Inicializar la nota más baja con la primera nota

for (int i = 1; i < notas.Length; i++)
{
    if (notas[i] > notaMasAlta)
    {
        notaMasAlta = notas[i]; // Actualizar la nota más alta si se encuentra una mayor
    }

    if (notas[i] < notaMasBaja)
    {
        notaMasBaja = notas[i]; // Actualizar la nota más baja si se encuentra una menor
    }
}

Console.WriteLine($"Nota más alta: {notaMasAlta}");
Console.WriteLine($"Nota más baja: {notaMasBaja}");